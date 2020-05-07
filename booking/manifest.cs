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
    public partial class manifest : Form
    {
        public manifest(string Manifest_Date, string Manifest_Vehicle)
        {
            InitializeComponent();


            #region

            string Connection_string = "Data Source=desktop-ahq5jm5\\sqlexpress;Initial Catalog=Db_Login;Integrated Security=True";

            using (SqlConnection Db_Connect = new SqlConnection(Connection_string))
            {

                Db_Connect.Open();
                string Query = " SELECT [Name],[Address],[Phone] ,[Gender],[Kin_Name] ,[Kin_Phone],[Destination],[Vehicle_No] FROM [Db_Login].[dbo].[Booking] WHERE Vehicle_No = @Vehicle_No AND Date=@Date";

                using (SqlCommand MY_Command = new SqlCommand(Query, Db_Connect))
                {

                    MY_Command.Parameters.AddWithValue("@Date", Manifest_Date);
                    MY_Command.Parameters.AddWithValue("@Vehicle_No", Manifest_Vehicle);

                    SqlDataAdapter My_Adapter = new SqlDataAdapter(MY_Command);

                    DataTable My_table = new DataTable();

                    My_Adapter.Fill(My_table);
                    dataGridView1.DataSource = My_table;
                   

                }


            }

            #endregion

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
