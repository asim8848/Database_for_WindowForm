using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void submit_Click(object sender, EventArgs e)
        {
           
            String company_name = companyname.Text;
            String contact_name = contactname.Text;
            String phone = phoneS.Text;

            String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\softtech.mdf;Integrated Security=True";

           SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO customer ( CompanyName,ContactName,Phone) VALUES ('" + company_name + "','" + contact_name + "','" + phone + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            int i = cmd.ExecuteNonQuery();
            if(i> 0)
            {
                MessageBox.Show("Data Inserted");

            }else if( i== 0)
            {
                MessageBox.Show("Data Not Inserted");
            }
            companyname.Text = "";
            contactname.Text = "";
            phoneS.Text = "";
        }

   

        private void Show_Click(object sender, EventArgs e)
        {
            String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\softtech.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("select * from customer",con);
            con.Open(); 
           
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        
        }
    }
}
