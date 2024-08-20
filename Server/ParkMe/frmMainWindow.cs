using BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkMe
{
    public partial class frmMainWindow : Form
    {
        private SensorDataReceiver sensorReceiver;
        private ParkingSpaceLogic parkingSpaceLogic;

        public frmMainWindow()
        {
            InitializeComponent();

            sensorReceiver = new SensorDataReceiver();
            parkingSpaceLogic = ParkingSpaceLogic.Instance;
            sensorReceiver.ParkingStatusUpdated += SensorReceiver_ParkingStatusUpdated;
        }

        private void SensorReceiver_ParkingStatusUpdated(object sender, ParkingStatusEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() => SensorReceiver_ParkingStatusUpdated(sender, e)));
                return;
            }

            int spaceId = e.SpaceId;
            bool occupied = e.Occupied;
            string licensePlate = occupied ? e.LicensePlate : null;

            parkingSpaceLogic.UpdateParkingSpace(spaceId, occupied, licensePlate);

            lblNumberOfTakenSpaces.Text = $"{parkingSpaceLogic.GetTotalAvailability()}/{parkingSpaceLogic.GetTotalSpaces()} slobodno";

            UpdateParkingSpaceUI(spaceId, occupied, licensePlate);

            var space = parkingSpaceLogic.GetParkingSpace(spaceId);
            if (occupied && space.ReservedForLicensePlate != null)
            {
                if (space.ReservedForLicensePlate == licensePlate)
                {
                    MessageBox.Show($"Automobil s registracijskom oznakom {licensePlate} se parkiralo na svoje parkirno mjesto {spaceId}.", "Vozilo parkirano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Automobil s registracijskom oznakom {licensePlate} se parkiralo na mjesto broj {spaceId} rezervirano za {space.ReservedForLicensePlate}.", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UpdateParkingSpaceUI(int spaceId, bool occupied, string licensePlate)
        {
            Color panelColor = occupied ? Color.Red : Color.Green;
            string statusText = occupied ? "Zauzeto" : "Slobodno";
            string plateText = $"Tablica: {licensePlate ?? "N/A"}";

            switch (spaceId)
            {
                case 1:
                    panelSpace1.BackColor = panelColor;
                    labelSpace1.Text = $"1: {statusText}";
                    labelPlate1.Text = plateText;
                    break;
                case 2:
                    panelSpace2.BackColor = panelColor;
                    labelSpace2.Text = $"2: {statusText}";
                    labelPlate2.Text = plateText;
                    break;
                case 3:
                    panelSpace3.BackColor = panelColor;
                    labelSpace3.Text = $"3: {statusText}";
                    labelPlate3.Text = plateText;
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sensorReceiver.Close();
            base.OnFormClosing(e);
        }

        private void premaRegistracijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchSpaces searchForm = new frmSearchSpaces();
            searchForm.ShowDialog();
        }
    }
}
