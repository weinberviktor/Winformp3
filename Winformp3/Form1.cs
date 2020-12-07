using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Winformp3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
             InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbartist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Server=(localdb)\Resources;Database=music;");


            SqlCommand cmd = new SqlCommand("SELECT * FROM [music]", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbartist.Items.Add(dr["music"].ToString());
                }
            }
            dr.Close();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbalbum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
