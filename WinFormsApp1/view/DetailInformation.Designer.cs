namespace WinFormsApp1
{
    partial class DetailInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailInformation));
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.routeInfo = new System.Windows.Forms.TextBox();
            this.stops = new System.Windows.Forms.TextBox();
            this.freeSeats = new System.Windows.Forms.TextBox();
            this.seatNumber = new System.Windows.Forms.TextBox();
            this.ticketPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(137, 19);
            this.PageCaption.Name = "PageCaption";
            this.PageCaption.Size = new System.Drawing.Size(365, 45);
            this.PageCaption.TabIndex = 2;
            this.PageCaption.Text = "Детальна інформація";
            this.PageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.routeInfo);
            this.groupBox1.Controls.Add(this.stops);
            this.groupBox1.Controls.Add(this.freeSeats);
            this.groupBox1.Controls.Add(this.seatNumber);
            this.groupBox1.Controls.Add(this.ticketPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 283);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація про обраний рейс";
            // 
            // routeInfo
            // 
            this.routeInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.routeInfo.Location = new System.Drawing.Point(21, 74);
            this.routeInfo.Name = "routeInfo";
            this.routeInfo.ReadOnly = true;
            this.routeInfo.Size = new System.Drawing.Size(168, 23);
            this.routeInfo.TabIndex = 10;
            // 
            // stops
            // 
            this.stops.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stops.Location = new System.Drawing.Point(369, 74);
            this.stops.Multiline = true;
            this.stops.Name = "stops";
            this.stops.ReadOnly = true;
            this.stops.Size = new System.Drawing.Size(224, 168);
            this.stops.TabIndex = 9;
            // 
            // freeSeats
            // 
            this.freeSeats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.freeSeats.Location = new System.Drawing.Point(195, 170);
            this.freeSeats.Name = "freeSeats";
            this.freeSeats.ReadOnly = true;
            this.freeSeats.Size = new System.Drawing.Size(168, 23);
            this.freeSeats.TabIndex = 8;
            // 
            // seatNumber
            // 
            this.seatNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seatNumber.Location = new System.Drawing.Point(19, 170);
            this.seatNumber.Name = "seatNumber";
            this.seatNumber.ReadOnly = true;
            this.seatNumber.Size = new System.Drawing.Size(168, 23);
            this.seatNumber.TabIndex = 7;
            // 
            // ticketPrice
            // 
            this.ticketPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ticketPrice.Location = new System.Drawing.Point(195, 74);
            this.ticketPrice.Name = "ticketPrice";
            this.ticketPrice.ReadOnly = true;
            this.ticketPrice.Size = new System.Drawing.Size(168, 23);
            this.ticketPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вільних місць";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Загальна кількість \r\nмісць для сидіння";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вартість квитку";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зупинки";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер рейсу та сполучення";
            // 
            // DetailInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailInformation";
            this.Text = "BusTicketsOffice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox routeInfo;
        private TextBox stops;
        private TextBox freeSeats;
        private TextBox seatNumber;
        private TextBox ticketPrice;
        private Label label5;
        private Label label4;
    }
}