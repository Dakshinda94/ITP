using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP
{
    public partial class Attendance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Buddhi chathuranga\Documents\ITPGroup.mdf;Integrated Security = True");

        public Attendance()
        {
            InitializeComponent();
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "yy-MM-dd"; // this line gives you only the month and year.
            date.ShowUpDown = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ATTENDANCE(EID, DATE) values('" + eid.Text + "','"+ date.Value + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Added Succesfully!");

            display_data();
        }


        private void display_data()
        {
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ATTENDANCE";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewA.DataSource = dt;
                con.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ATTENDANCE set EID = '" + eid.Text + "',DATE = '" + date.Value + "' where AID='" + aid.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();

            display_data();

            MessageBox.Show("Record Updated Succesfully!");

        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ATTENDANCE where AID='" + aid.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Succesfully!");

            display_data();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            display_data();
        }
    }
}
