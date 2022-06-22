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



namespace WindowsFormsApp1
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get un,pw
            string un = txtun.Text;
            string pw = txtpw.Text;
            //check it with DB login table

            try
            {
                SqlConnection con = new SqlConnection("Data Source = PIUMI; database = HOSPITAL_MANAGEMENT_INVENTRY_1; Integrated Security = True; Connect Timeout = 30");

                string query = "select PASSWORD from U_TABLE where USERNAME='" + un + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd Connection  = con;
                con.Open();
                cmd.ExecuteNonQuery();
                //string pwFromTable = cmd.ToString();
                string pwFromTable = cmd.ExecuteScalar().ToString();
                con.Close();

                if (pwFromTable == pw)
                {
                    //Login is success
                    form4 newform = new form4();
                    this.Hide();
                    newform.ShowDialog();
                    this.Show();
                }

                else 
                {
                    MessageBox.Show("Incorrect user name or password..!!!");
                }

            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Invalid Format");
            }
                //if correct load the home form
                //else give a error message
         }

        private void button2_Click(object sender, EventArgs e)
        {
            //get un,pw
            //check pw==re-pw
            //if yes insert un,pw to login table
            //if no give an error message
            //redirect to login form

            
            Form3 newform = new Form3();
            this.Hide();
            newform.ShowDialog();
            this.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 newform = new Form3();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
