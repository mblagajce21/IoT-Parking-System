using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace BusinessLayer
{
    public class SensorDataReceiver
    {
        private const int port = 55655; 
        private Socket listener;
        private Thread receiveThread;

        public event EventHandler<ParkingStatusEventArgs> ParkingStatusUpdated;

        public SensorDataReceiver()
        {
            receiveThread = new Thread(StartListening);
            receiveThread.Start();
        }

        private void StartListening()
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    Socket handler = listener.Accept();
                    Thread clientThread = new Thread(() => HandleClient(handler));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void HandleClient(Socket clientSocket)
        {
            byte[] bytes = new byte[1024];
            string data = null;

            try
            {
                while (true)
                {
                    int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }

                string[] spaceData = data.Replace("<EOF>", "").Split(';');
                int spaceId = int.Parse(spaceData[0]);
                bool occupied = bool.Parse(spaceData[1]);
                string licensePlate = spaceData.Length > 2 ? spaceData[2] : null;

                ParkingStatusUpdated?.Invoke(this, new ParkingStatusEventArgs(spaceId, occupied, licensePlate));

                byte[] msg = Encoding.ASCII.GetBytes("Data received successfully");
                clientSocket.Send(msg);
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void Close()
        {
            listener.Close();
            receiveThread.Abort();
        }
    }

    public class ParkingStatusEventArgs : EventArgs
    {
        public int SpaceId { get; }
        public bool Occupied { get; }
        public string LicensePlate { get; }

        public ParkingStatusEventArgs(int spaceId, bool occupied, string licensePlate)
        {
            SpaceId = spaceId;
            Occupied = occupied;
            LicensePlate = licensePlate;
        }
    }
}
