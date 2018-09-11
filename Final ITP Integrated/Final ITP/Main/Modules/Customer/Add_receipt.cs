using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Main.Modules.Customer
{
    public partial class Add_receipt : Form
    {
        public Add_receipt()
        {
            InitializeComponent();
        }

        
        string imgloc = "";

        //browse image
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Filter = "png files(*.png)|*.png | jpg files(*.jpg) |*.jpg|All files(*.*)|*.*";

            if (dia.ShowDialog() == DialogResult.OK)
            {
                imgloc = dia.FileName.ToString();
                pictureBox1.ImageLocation = imgloc;
            }
        }

        //save image
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtConNo.Text == "")
            {
                MessageBox.Show("Enter Contact Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult dia = MessageBox.Show("Do you really want to save details?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dia == DialogResult.Yes)
                {
                   
                    byte[] images = null;
                    FileStream strm = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(strm);
                    images = brs.ReadBytes((int)strm.Length);


                    DBConnect b1 = new DBConnect();
                    b1.ConnectToDatabase();
                    string sql =" Insert into Receipt (contact_number, bill_no ,img) VALUES(" + txtConNo.Text + ",'"+txtBillNo.Text+"',@images)";

                    SqlConnection conn = b1.getconnection();

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@images", images));

                    int x = cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Saved");
                    conn.Close();
                }
            }
        }

        private void Add_receipt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
