using BusinessLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ParkMe
{
    public partial class frmSpaceReservation : Form
    {
        private ParkingSpaceLogic parkingSpaceLogic;

        public frmSpaceReservation()
        {
            InitializeComponent();
            parkingSpaceLogic = ParkingSpaceLogic.Instance;
        }

        private void frmSpaceReservation_Load(object sender, EventArgs e)
        {
            cbParkingSpaces.DataSource = parkingSpaceLogic.GetAllParkingSpaces().ToList();
            cbParkingSpaces.DisplayMember = "SpaceId";
            cbParkingSpaces.ValueMember = "SpaceId";
        }

        private void cbParkingSpaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParkingSpaces.SelectedValue is int spaceId)
            {
                var space = parkingSpaceLogic.GetParkingSpace(spaceId);

                if (space != null && !string.IsNullOrEmpty(space.ReservedForLicensePlate))
                {
                    txtLicensePlate.Text = space.ReservedForLicensePlate;
                    btnRemove.Enabled = true;
                }
                else
                {
                    txtLicensePlate.Text = string.Empty;
                    btnRemove.Enabled = false;
                }
            }
        }


        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            int spaceId = (int)cbParkingSpaces.SelectedValue;
            string licensePlate = txtLicensePlate.Text.Trim();

            if (string.IsNullOrEmpty(licensePlate))
            {
                MessageBox.Show("Provjerite unesenu registrtacijsku oznaku.", "Unos nije valjan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var space = parkingSpaceLogic.GetParkingSpace(spaceId);
            if (space != null)
            {
                space.ReservedForLicensePlate = licensePlate;
                MessageBox.Show($"Parkirno mjesto {spaceId} je rezervirano za vozilo s oznakom {licensePlate}.", "Rezervacija ažurirana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int spaceId = (int)cbParkingSpaces.SelectedValue;
            var space = parkingSpaceLogic.GetParkingSpace(spaceId);

            if (space != null)
            {
                space.ReservedForLicensePlate = null;
                txtLicensePlate.Text = string.Empty;
                btnRemove.Enabled = false;
                MessageBox.Show($"Rezervacija je obrisana s mjesta {spaceId}.", "Rezervacija obrisana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
