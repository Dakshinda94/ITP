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
    public partial class Employee : Form
    {
        String gender;


        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Buddhi chathuranga\Documents\ITPGroup.mdf;Integrated Security = True");
        
          //  Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = ITP; Integrated Security = True


        public Employee()
        {
            InitializeComponent();
            fillCombo();
        }

        
        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into EMPLOYEE values('" + eid.Text + "','" + name.Text + "','" + gender + "','" + address.Text + "','" + email.Text + "','" + nic.Text + "','" + phone.Text + "','" + dob.Value + "','" + position.Text + "')";
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
                cmd.CommandText = "select * from EMPLOYEE";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                con.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EMPLOYEE where EID='" + eid.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Succesfully!");

            display_data();

        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update EMPLOYEE set EID = '" + eid.Text + "',NAME = '" + name.Text + "',GENDER = '" + gender + "',ADDRESS = '" + address.Text + "',EMAIL = '" + email.Text + "',NIC = '" + nic.Text + "',PHONE = '" + phone.Text + "',DATEOFBIRTH = '" + dob.Value + "',POSITION= '" + position.Text + "' where EID='" + eid.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Succesfully!");

            display_data();

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            display_data();
        }

        void fillCombo()
        {
            position.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from POSITION";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                position.Items.Add(dr["position"].ToString());
            }
            con.Close();
        }

    }
}
