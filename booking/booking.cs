using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;


namespace booking
{
    class booking
    {
        public string Error { set; get; }
        public string _Name { get; set; }
        public string _Email { get; set; }
        public string _Phone_No { get; set; }
        public string _Address { get; set; }
        public string _Kin_Name { get; set; }
        public string _Kin_Phone { get; set; }
        public string _Amount { get; set; }
        public string _Destination { get; set; }
        public string _Date { get; set; }
        public string _gender { get; set; }
        public int _Seat_No { get; set; }
        public string _Vehicle_No { get; set; }

        public string _User_Name { get; set; }

        public int Code { get; set; }

        public string _Password { get; set; }
        // string Connection_string = null;

        string Connection_string = "Data Source=desktop-ahq5jm5\\sqlexpress;Initial Catalog=Db_Login;Integrated Security=True";


        public  SqlDataReader Check_Login(string User_Name, string Password)
        {



            try
            {

                ///creat sql connection 
                SqlConnection Myconnection = default(SqlConnection);
                Myconnection = new SqlConnection(Connection_string);

                // create command 
                string query = " SELECT UserName,Password , LastLogin FROM Users WHERE UserName = @UserName AND Password = @Password";
                SqlCommand Mycommand = default(SqlCommand);
                Mycommand = new SqlCommand(query, Myconnection);

                SqlParameter Db_username = new SqlParameter("@UserName", SqlDbType.VarChar);
                SqlParameter Db_password = new SqlParameter("@Password", SqlDbType.VarChar);

                Db_username.Value = User_Name;
                Db_password.Value = Password;

                Mycommand.Parameters.Add(Db_username);
                Mycommand.Parameters.Add(Db_password);
                Mycommand.Connection.Open();

                SqlDataReader Read_Data = Mycommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (Read_Data.Read() == true)
                {



                    return Read_Data;
                    
                    

                }
                else { return null; }
              


                if (Myconnection.State == ConnectionState.Open) { Myconnection.Dispose(); }
            }
            catch (Exception ex)
            {

                this.Error = ex.Message;
                return null;
            }


        }

        public bool Check_Avialanle_Seat(int Seat_Number, string Date, string Vehicle_no)
        {

            try
            {

                ///creat sql connection 
                SqlConnection Myconnection = default(SqlConnection);
                Myconnection = new SqlConnection(Connection_string);

                // create command 
                string query = " SELECT Seat_NO ,Vehicle_No,Date FROM Booking WHERE Vehicle_No = @Vehicle_No AND Date = @Date AND Seat_No = @Seat_No";
                SqlCommand Mycommand = default(SqlCommand);
                Mycommand = new SqlCommand(query, Myconnection);

                SqlParameter Db_Vehicle_No = new SqlParameter("@Vehicle_No", SqlDbType.VarChar);
                SqlParameter Db_Date = new SqlParameter("@Date", SqlDbType.VarChar);
                SqlParameter Db_Seat_No = new SqlParameter("@Seat_No", SqlDbType.Int);

                Db_Date.Value = Date;
                Db_Vehicle_No.Value = Vehicle_no;
                Db_Seat_No.Value = Seat_Number;


                Mycommand.Parameters.Add(Db_Date);
                Mycommand.Parameters.Add(Db_Vehicle_No);
                Mycommand.Parameters.Add(Db_Seat_No);
                Mycommand.Connection.Open();

                SqlDataReader Read_Data = Mycommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (Read_Data.Read() == true)
                {

                    return true;

                }
                else
                {
                    return false;


                }


                if (Myconnection.State == ConnectionState.Open) { Myconnection.Dispose(); }
            }
            catch (Exception ex)
            {

                this.Error = ex.Message;
                return false;
            }



        }

        public bool Insert_Data()
        {


            string Sql = null;
            using (SqlConnection My_Connection = new SqlConnection(Connection_string))
            {
                Sql = " INSERT INTO Booking (Name,Email,Phone,Address,Kin_Name,Kin_Phone,Amount,Vehicle_No,Date,Seat_No,Destination,Gender,Code) VALUES(@Name,@Email,@Phone,@address,@Kin_Name,@Kin_Phone,@Amount,@Vehicle_No,@Date,@Seat_No,@Destination,@Gender,@Code)";
                My_Connection.Open();
                using (SqlCommand My_Command = new SqlCommand(Sql, My_Connection))
                {

                    My_Command.Parameters.AddWithValue("@Name", _Name);
                    My_Command.Parameters.AddWithValue("@Email", _Email);
                    My_Command.Parameters.AddWithValue("@Phone", _Phone_No);
                    My_Command.Parameters.AddWithValue("@Address", _Address);
                    My_Command.Parameters.AddWithValue("@Kin_Name", _Kin_Name);
                    My_Command.Parameters.AddWithValue("@Kin_Phone", _Kin_Phone);
                    My_Command.Parameters.AddWithValue("@Amount", _Amount);
                    My_Command.Parameters.AddWithValue("@Vehicle_No", _Vehicle_No);
                    My_Command.Parameters.AddWithValue("@Seat_No", _Seat_No);
                    My_Command.Parameters.AddWithValue("@Destination", _Destination);
                    My_Command.Parameters.AddWithValue("@Gender", _gender);
                    My_Command.Parameters.AddWithValue("@Date", _Date);
                    My_Command.Parameters.AddWithValue("@Code", Code);

                    int Number_of_Rows = My_Command.ExecuteNonQuery();
                    My_Connection.Close();

                    if (Number_of_Rows > 0) { return true; } else { return false; }



                }



            }





        }

        public bool Validate_Email(string Email)
        {


            string myp = null;
            myp = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            if (Regex.IsMatch(Email, myp, RegexOptions.IgnoreCase)) { return true; } else { return false; }

        }
        public bool Validate_Interger(string Number)
        {

            int i;

            if (int.TryParse(Number, out i)) { return true; } else { return false; }


        }

        public bool Validate_Number(string num)
        {


            if (Regex.IsMatch(num, @"^[0-9 ]+$")) { return true; } else { return false; }

        }

        public bool Validat_Letter(string Letter)
        {


            if (Regex.IsMatch(Letter, @"^[a-zA-Z ]+$")) { return true; } else { return false; }

        }

        public bool Check_If_Empty(string Value)
        {

            if (Value == "")
            {

                return false;
            }
            else { return true; }


        }

        public bool Search_Manifest( string Veh, string Date) {

            using (SqlConnection My_Connection = new SqlConnection(Connection_string))

            {

                My_Connection.Open();
              
                string Query = " SELECT [Name],[Address],[Phone] ,[Gender],[Kin_Name] ,[Kin_Phone],[Destination] FROM [Db_Login].[dbo].[Booking] WHERE Vehicle_No = @Vehicle_No AND Date=@Date";


                using (SqlCommand My_Comm = new SqlCommand(Query, My_Connection))

                {

                    My_Comm.Parameters.AddWithValue("@Date",Date);
                    My_Comm.Parameters.AddWithValue("@Vehicle_No", Veh);

                    SqlDataReader My_Data = My_Comm.ExecuteReader();

                    if (My_Data.Read() == true) { return true; }
                    else{return false;}


                
                
                
                }
            
            }
        
        
        
       
        }

        public bool Update(string User_Name, string Password)
        {

            using( SqlConnection My_Con = new SqlConnection(Connection_string)){

                My_Con.Open();
                string Query = "UPDATE Users SET LastLogin = @LastLogin WHERE UserName = @UserName AND Password = @Password";
                using (SqlCommand My_comm = new SqlCommand(Query,My_Con)) {

                    My_comm.Parameters.AddWithValue("lastLogin", DateTime.Now);
                    My_comm.Parameters.AddWithValue("@UserName", User_Name);
                    My_comm.Parameters.AddWithValue("@Password", Password);

                int Result =     My_comm.ExecuteNonQuery();

                if (Result > 0) { return true; } else { return false; }
                
                
                }
            
            
            }




        }
    }
     
}
