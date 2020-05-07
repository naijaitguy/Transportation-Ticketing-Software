using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booking
{
    public partial class preview_booking : Form
    {
        public preview_booking( string Name , string Phone, string Gender, string Address, string Amount, string Destination, string Email ,string Kin_Name, string Kin_Phone, string Seat_No, string Vehicle ,string Date , int Code )
        {

            
          
            InitializeComponent();
            label_Name.Text = Name;
            label_Phone.Text = Phone;
            label_Gender.Text = Gender;
            label_Address.Text = Address;
            label_Amount.Text = " NGN "+Amount + ".00";
            label_Destination.Text = Destination;
            label_Email.Text = Email;
            label_Kin_Name.Text = Kin_Name;
            label_Seat_No.Text = Seat_No;
            label_Kin_Phone.Text = Kin_Phone;
            label_vehicle.Text = Vehicle;
            label_Date.Text = Date;
            label_Code.Text = Code.ToString();
           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void preview_booking_Load(object sender, EventArgs e)
        {

            


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Kin_Phone_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm obj_MainForm = new MainForm();
            obj_MainForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            booking obj_My_booking = new booking();

        obj_My_booking._Name =  label_Name.Text;
        obj_My_booking._Phone_No = label_Phone.Text;
        obj_My_booking._gender = label_Gender.Text;
        obj_My_booking._Address = label_Address.Text ;
        obj_My_booking._Amount = label_Amount.Text ;
        obj_My_booking._Destination = label_Destination.Text;
        obj_My_booking._Email = label_Email.Text;
        obj_My_booking._Kin_Name = label_Kin_Name.Text;
        obj_My_booking._Seat_No = Convert.ToInt32( label_Seat_No.Text);
        obj_My_booking._Kin_Phone = label_Kin_Phone.Text;
        obj_My_booking._Vehicle_No = label_vehicle.Text;
        obj_My_booking._Date = label_Date.Text;
        obj_My_booking.Code = Convert.ToInt32( label_Code.Text);


        if (obj_My_booking.Insert_Data() == true)
        
        {

            Form_Reciept obj_Form_reciept = new Form_Reciept(label_Name.Text,label_Amount.Text,label_Destination.Text,label_Seat_No.Text,label_vehicle.Text,label_Date.Text, Convert.ToInt32( label_Code.Text));
            this.Hide();
            obj_Form_reciept.ShowDialog();
        
        
        } 
        
        
        else

        { MessageBox.Show("Not Inserted Into DateBase", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
    }
}
