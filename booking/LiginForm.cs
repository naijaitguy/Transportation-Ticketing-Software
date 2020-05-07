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

namespace booking
{
    public partial class Login_Form : Form
    {

       


        public Login_Form()

        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {

            //check if the username field is empty 

            if (text_Username.Text == "")
            {

                MessageBox.Show("Pls Enter User Name"," User Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_Username.Focus();
                return;

            }

            //check if the password field is empty
            if (text_Password.Text == "") {
                MessageBox.Show(" Pls Enter Password", "Password Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                text_Password.Focus();

            
            }


            booking obj_Booking = new booking();

           SqlDataReader result = obj_Booking.Check_Login(text_Username.Text,text_Password.Text);

            if (result != null )

            {
                string LastLogin = result[2].ToString();

                if (obj_Booking.Update(text_Username.Text, text_Password.Text) == true)
                {

                    this.Hide();
                    MainForm Main_form = new MainForm(text_Username.Text , LastLogin);

                    Main_form.ShowDialog();
                }
            
            }
            else {
                MessageBox.Show(" Invalid User Name or Password ", " User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_Username.Clear();
                text_Password.Clear();
                text_Username.Focus();
            
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
