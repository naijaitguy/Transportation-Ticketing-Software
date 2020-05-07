using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace booking
{
    public partial class Manifest_Form : Form
    {
        public Manifest_Form( string Manifest_Date, string Manifest_Vehicle)
        {
          

            InitializeComponent();

            #region
       //  int    Srno = 0;

            string Connection_string = "Data Source=desktop-ahq5jm5\\sqlexpress;Initial Catalog=Db_Login;Integrated Security=True";

            using (SqlConnection Db_Connect = new SqlConnection(Connection_string))
            {

                Db_Connect.Open();
                string Query = " SELECT [Name],[Address],[Phone] ,[Gender],[Seat_No],[Kin_Name] ,[Kin_Phone],[Destination] FROM [Db_Login].[dbo].[Booking] WHERE Vehicle_No = @Vehicle_No AND Date=@Date";

                using (SqlCommand MY_Command = new SqlCommand(Query, Db_Connect))
                {

                    MY_Command.Parameters.AddWithValue("@Date", Manifest_Date);
                    MY_Command.Parameters.AddWithValue("@Vehicle_No", Manifest_Vehicle);

                  using(  SqlDataAdapter My_Adapter = new SqlDataAdapter(MY_Command))
               { 

                    DataTable My_table = new DataTable();
                  
                    My_Adapter.Fill(My_table);

                    
                          dataGridView1.DataSource = My_table;


                          
                          dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                          dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                          dataGridView1.Columns[0].Width = 200;

                          dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                          dataGridView1.Columns[3].Width = 70;
                          dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                          dataGridView1.Columns[4].Width = 70;



                          dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                          dataGridView2.Columns.Add("sn", "mysn");
                          dataGridView1.ColumnHeadersVisible = false;
                          dataGridView2.Rows.Add(15);
                          for (int i = 0; i < dataGridView1.Rows.Count  ; ++i)
                          {

                              dataGridView2.Rows[i].Cells[0].Value = (i + 1).ToString();
                              dataGridView2.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                          }
              


                }
                 
            }


         }

            #endregion

            label13.Text = label13.Text +"  " + Manifest_Date;
            label17.Text = label17.Text + "  "+  Manifest_Vehicle;
  
        }


       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();


            PrinterSettings ps = new PrinterSettings();
            ps.Copies = 2;

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("210 x 297 mm", 1200, 650);
            printPreviewDialog1.ShowDialog();

            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = panel1.CreateGraphics();
            Size s = panel1.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, panel1.ClientRectangle.Width, panel1.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            {
            


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manifest_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
