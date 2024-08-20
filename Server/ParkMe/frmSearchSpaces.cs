using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkMe
{
    public partial class frmSearchSpaces : Form
    {
        private ParkingSpaceLogic parkingSpaceLogic;

        public frmSearchSpaces()
        {
            InitializeComponent();
            parkingSpaceLogic = ParkingSpaceLogic.Instance;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string licensePlate = txtSearchRegistration.Text.Trim();

            if (string.IsNullOrEmpty(licensePlate))
            {
                MessageBox.Show("Molimo unesite registracijsku oznaku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var matchingSpace = parkingSpaceLogic.FindParkingSpaceByLicensePlate(licensePlate);

            if (matchingSpace == null)
            {
                lblCarLocation.Text = "N/A";
            }
            else
            {
                lblCarLocation.Text = matchingSpace.SpaceId.ToString();
            }
        }
    }
}
