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
    public partial class CalculateSalary : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Buddhi chathuranga\Documents\ITPGroup.mdf;Integrated Security = True");

        public CalculateSalary()
        {
            InitializeComponent();
            year.Format = DateTimePickerFormat.Custom;
            year.CustomFormat = "yyyy";
            year.ShowUpDown = true;

            month.Format = DateTimePickerFormat.Custom;
            month.CustomFormat = "MM";
            month.ShowUpDown = true;
        }


        private void cal_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand MyCommand1 = new SqlCommand("select count(*) from ATTENDANCE where DATEPART(year,DATE)='" + year.Text + "'  and DATEPART(month,DATE)=  '" + month.Text + "' and EID='" + eid.Text + "'", con);
            double att = Convert.ToDouble(MyCommand1.ExecuteScalar());

            SqlCommand MyCommand2 = new SqlCommand("select POSITION from EMPLOYEE where EID = '" + eid.Text + "'", con);
            string pot = Convert.ToString(MyCommand2.ExecuteScalar());

            SqlCommand MyCommand3 = new SqlCommand("select SALARY from POSITION where POSITION=  '" + pot + "'", con);
            double sal = Convert.ToDouble(MyCommand3.ExecuteScalar());

            double msal = att * sal;

            amount.Text = "Rs " + msal + ".00";

            con.Close();
        }
    }
}

