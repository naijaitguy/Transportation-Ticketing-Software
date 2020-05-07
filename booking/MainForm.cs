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
    public partial class MainForm : Form


    
    {
       
        
        public MainForm( )
        {
            InitializeComponent();

        }

        public MainForm( string User_Name, string LastLogin)
        {
            InitializeComponent();

            label16.Text = " Welcome Back User:  " + "  " + User_Name + " Today is : " + DateTime.Now;
            
           label17.Text =  " Your Last Visit Was On " + LastLogin;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form objlogin = new Login_Form();
     
            objlogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {





            string Name = Text_Name.Text;
            string Email = Text_Email.Text;
            string Phone = Text_Phone.Text;
            string Address = Text_Add.Text;
            string Amount = Text_Amount.Text;
            string Kin_Name = Text_Kin_Name.Text;
            string Kin_Phone = Text_Kin_Phone.Text;
            string  date = Date_p.Text;
            string Seat_No = Comb_Seat_No.Text;
            string Vehicle_Number = Combo_Vehicle.Text;
            string Destination = Combo_Destination.Text;
            string MyGender;

            int code = new Random().Next(1000, 9999);



            booking obj_Booking = new booking();
            

            if (Radio_Male.Checked) { MyGender = "Male"; }

            else
            {

                if (Radio_Female.Checked) { MyGender = "Female"; } else { MyGender = ""; }



            }


        

            if (obj_Booking.Check_If_Empty(MyGender) == false) { MessageBox.Show(" Pls Select Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (obj_Booking.Check_If_Empty(Name) == false)
            {
                MessageBox.Show(" Pls Enter Your Full Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Name.Focus(); return;
 }
            if (obj_Booking.Check_If_Empty(Email) == false) { MessageBox.Show(" Pls Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Email.Focus(); return; }
            if (obj_Booking.Check_If_Empty(Phone) == false) { MessageBox.Show(" Pls Enter Your Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Phone.Focus(); return; }
            if (obj_Booking.Check_If_Empty(Address) == false) { MessageBox.Show(" Pls Enter Your Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Add.Focus(); return; }
            if (obj_Booking.Check_If_Empty(Amount) == false) { MessageBox.Show(" Pls Enter Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Amount.Focus(); return; }
            if (obj_Booking.Check_If_Empty(Kin_Name) == false) { MessageBox.Show(" Pls Enter Next Of Kin Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Kin_Name.Focus(); return; }
            if (obj_Booking.Check_If_Empty(Kin_Phone) == false) { MessageBox.Show(" Pls Enter Next Of Kin Phone Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Kin_Phone.Focus(); return; }

            if (obj_Booking.Check_If_Empty(Vehicle_Number) == false) { MessageBox.Show(" Pls Select Vehicle Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Combo_Vehicle.Focus(); return; }
            if (obj_Booking.Check_If_Empty(Seat_No) == false) { MessageBox.Show(" Pls Select Seat Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Comb_Seat_No.Focus(); return; }
            if (obj_Booking.Check_If_Empty(Destination) == false) { MessageBox.Show(" Pls Select Destination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Combo_Destination.Focus(); return; }
            if (obj_Booking.Validat_Letter(Name) == false) { MessageBox.Show(" Pls Name Can only be Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Name.Focus(); return; }
            if (obj_Booking.Validat_Letter(Kin_Name) == false) { MessageBox.Show(" Pls Name Can only be Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Name.Focus(); return; }
            if (obj_Booking.Validate_Number(Phone) == false) { MessageBox.Show(" Pls Enter Valid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Phone.Focus(); return; }
            if (obj_Booking.Validate_Number(Kin_Phone) == false) { MessageBox.Show(" Pls Enter Valid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Kin_Phone.Focus(); return; }
            if (obj_Booking.Validate_Number(Amount) == false) { MessageBox.Show(" Pls Enter Valid Amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Amount.Focus(); return; }

            if (obj_Booking.Validate_Email(Email) == false) { MessageBox.Show(" Pls Enter Valid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Text_Email.Focus(); return; }

            if (obj_Booking.Check_Avialanle_Seat(Convert.ToInt32(Seat_No), date, Vehicle_Number) == true)
            {


                MessageBox.Show(" Seat Number " + Seat_No + " is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Comb_Seat_No.Focus(); return;
            }

            obj_Booking._Name = Name;
            obj_Booking._Email = Email;
            obj_Booking._Destination = Destination;
            obj_Booking._Date = date;
            obj_Booking._Amount = "NGN"+ Amount + ".00";
            obj_Booking._gender = MyGender;
            obj_Booking._Kin_Name = Kin_Name;
            obj_Booking._Kin_Phone = Kin_Phone;
            obj_Booking._Phone_No = Phone;
            obj_Booking._Seat_No = Convert.ToInt32( Seat_No);
            obj_Booking._Address = Address;
            obj_Booking._Vehicle_No = Vehicle_Number;
            obj_Booking.Code = code;

          
            

            preview_booking obj_preview = new preview_booking(Name,Phone,MyGender,Address,Amount,Destination,Email,Kin_Name,Kin_Phone,Seat_No,Vehicle_Number,date, code);

            obj_preview.ShowDialog();
            
            





        }

        private void Text_Name_KeyPress(object sender, KeyPressEventArgs e)
     {
            
        }

        private void Comb_Seat_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            
            string  date = Date_p.Text;
            int Seat_No = Convert.ToInt32( Comb_Seat_No.Text);
            string Vehicle_Number = Combo_Vehicle.Text;

            if (date == "") { MessageBox.Show(" Select Date  First"); return; }
            if (Vehicle_Number == "") 

            {
             Comb_Seat_No.Text = ""; 
             MessageBox.Show(" Select Vehicle Number First", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             Combo_Vehicle.Focus();
             
             return;
            }
            
            booking obj_Booking = new booking();


            if (obj_Booking.Check_Avialanle_Seat(Seat_No, date, Vehicle_Number) == true) {

               
                MessageBox.Show(" Seat Number "+ Seat_No  +" is Not Available",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Comb_Seat_No.Focus(); return;
            }

          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


           string  Manifes_Vehicle = comboBox1.Text;
           string Manifest_date = dateTimePicker1.Text;

           if (Manifes_Vehicle == "")  { MessageBox.Show(" Pls Enter Vehicle Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); comboBox1.Focus(); return; }

           if (Manifest_date == "") { MessageBox.Show(" Pls Select Manifest Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); dateTimePicker1.Focus(); return; }
           
          booking obj_Booking =new  booking();

          bool Result = obj_Booking.Search_Manifest(Manifes_Vehicle, Manifest_date);

          if (Result == true)
          {

              Manifest_Form Obj_Manifest = new Manifest_Form(Manifest_date, Manifes_Vehicle);
              //  manifest Obj_Manifest = new manifest(Manifest_date, Manifes_Vehicle);
              { } Obj_Manifest.ShowDialog();
          }
          else {

              MessageBox.Show(" Manifest Not Found In Records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Comb_Seat_No.Focus(); return;
          }


             
          }

            
        }
    }

