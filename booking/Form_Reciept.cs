﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace booking
{
    public partial class Form_Reciept : Form
    {
        public Form_Reciept(string Name,  string Amount, string Destination,   string Seat_No, string Vehicle, string Date, int Code)
        {
            InitializeComponent();
           

            label_Amount.Text = Amount;
            label_Date.Text = Code.ToString();
            label_Destination.Text = Destination;
            label_Name.Text =  Name;
            label_Vehicle.Text = Vehicle;
            label_Seat.Text = Seat_No;


            button1.Text = " PRINTED ON " + Date.ToString();
        } 

        private void Form_Reciept_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_printpage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(memoryImage, 0, 0);  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintScreen();
            printPreviewDialog1.ShowDialog();
            this.Hide();
           
            

        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
