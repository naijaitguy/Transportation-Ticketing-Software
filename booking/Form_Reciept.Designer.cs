namespace booking
{
    partial class Form_Reciept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reciept));
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Destination = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_Vehicle = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Seat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Name.Location = new System.Drawing.Point(44, 70);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(44, 17);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "babtu";
            // 
            // label_Destination
            // 
            this.label_Destination.AutoSize = true;
            this.label_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Destination.Location = new System.Drawing.Point(44, 101);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(44, 17);
            this.label_Destination.TabIndex = 1;
            this.label_Destination.Text = "babtu";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Amount.Location = new System.Drawing.Point(44, 136);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(44, 17);
            this.label_Amount.TabIndex = 2;
            this.label_Amount.Text = "babtu";
            // 
            // label_Vehicle
            // 
            this.label_Vehicle.AutoSize = true;
            this.label_Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Vehicle.Location = new System.Drawing.Point(44, 169);
            this.label_Vehicle.Name = "label_Vehicle";
            this.label_Vehicle.Size = new System.Drawing.Size(44, 17);
            this.label_Vehicle.TabIndex = 3;
            this.label_Vehicle.Text = "babtu";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Date.Location = new System.Drawing.Point(44, 231);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(44, 17);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "babtu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(-3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(-3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEST:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-3, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "AMT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(-3, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "VEH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(-3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "B_ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "PRINT RECIEPT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Document";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_printpage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(-2, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "NAIJAITGUYS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(-3, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Seat:";
            // 
            // label_Seat
            // 
            this.label_Seat.AutoSize = true;
            this.label_Seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Seat.Location = new System.Drawing.Point(44, 201);
            this.label_Seat.Name = "label_Seat";
            this.label_Seat.Size = new System.Drawing.Size(46, 17);
            this.label_Seat.TabIndex = 13;
            this.label_Seat.Text = "label8";
            // 
            // Form_Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.label_Seat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Vehicle);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label_Destination);
            this.Controls.Add(this.label_Name);
            this.MaximizeBox = false;
            this.Name = "Form_Reciept";
            this.ShowIcon = false;
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.Form_Reciept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.Label label_Name;
        public System.Windows.Forms.Label label_Destination;
        public System.Windows.Forms.Label label_Amount;
        public System.Windows.Forms.Label label_Vehicle;
        public System.Windows.Forms.Label label_Date;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Seat;
    }
}