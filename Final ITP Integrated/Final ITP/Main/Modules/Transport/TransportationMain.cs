using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class TransportationMain : Form
    {
        External_Travel travel = null;
        Vehicle_Info info = null;
        Vehicle_Request request = null;
        Fuel fuel = null;
        Insurance insurance = null;

        public TransportationMain()
        {
            InitializeComponent();
        }

        private void Insurancedetails_Click(object sender, EventArgs e)
        {

        }

        private void TransportationMain_Load(object sender, EventArgs e)
        {
            pnlDashBoard.BackColor = Color.FromArgb(128, 255, 255, 255);
            pnlBody.BackColor = Color.FromArgb(128, 255, 255, 255);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (insurance == null)
            {
                insurance = new Insurance();
                insurance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                insurance.Dock = DockStyle.Fill;
                insurance.TopLevel = false;
                pnlBody.Controls.Add(insurance);
                insurance.Show();
            }
            else
            {
                insurance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                insurance.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(insurance);
                insurance.Activate();
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (info == null)
            {
                info = new Vehicle_Info();
                info.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                info.Dock = DockStyle.Fill;
                info.TopLevel = false;
                pnlBody.Controls.Add(info);
                info.Show();
            }
            else
            {
                info.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                info.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(info);
                info.Activate();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (request == null)
            {
                request = new Vehicle_Request();
                request.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                request.Dock = DockStyle.Fill;
                request.TopLevel = false;
                pnlBody.Controls.Add(request);
                request.Show();
            }
            else
            {
                request.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                request.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(request);
                request.Activate();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (travel == null)
            {
                travel = new External_Travel();
                travel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                travel.Dock = DockStyle.Fill;
                travel.TopLevel = false;
                pnlBody.Controls.Add(travel);
                travel.Show();
            }
            else
            {
                travel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                travel.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(travel);
                travel.Activate();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (fuel == null)
            {
                fuel = new Fuel();
                fuel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fuel.Dock = DockStyle.Fill;
                fuel.TopLevel = false;
                pnlBody.Controls.Add(fuel);
                fuel.Show();
            }
            else
            {
                fuel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fuel.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(fuel);
                fuel.Activate();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (fuel == null)
            {
                fuel = new Fuel();
                fuel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fuel.Dock = DockStyle.Fill;
                fuel.TopLevel = false;
                pnlBody.Controls.Add(fuel);
                fuel.Show();
            }
            else
            {
                fuel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fuel.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(fuel);
                fuel.Activate();
            }
        }
    }
}
