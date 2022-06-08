namespace WinFormsApp1
{
    partial class RouteChose
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateDepartureBox = new System.Windows.Forms.DateTimePicker();
            this.findRoutesButton = new System.Windows.Forms.Button();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departureBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfCitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listOfCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelRoutes = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource)).BeginInit();
            this.panelRoutes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(448, 33);
            this.PageCaption.Name = "PageCaption";
            this.PageCaption.Size = new System.Drawing.Size(281, 45);
            this.PageCaption.TabIndex = 0;
            this.PageCaption.Text = "Вибір маршруту";
            this.PageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateDepartureBox);
            this.groupBox1.Controls.Add(this.findRoutesButton);
            this.groupBox1.Controls.Add(this.destinationBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.departureBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(62, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть зі списку дату та пункт відправлення, пункт призначення для отримання ін" +
    "формації";
            // 
            // dateDepartureBox
            // 
            this.dateDepartureBox.Location = new System.Drawing.Point(518, 59);
            this.dateDepartureBox.Name = "dateDepartureBox";
            this.dateDepartureBox.Size = new System.Drawing.Size(144, 25);
            this.dateDepartureBox.TabIndex = 6;
            // 
            // findRoutesButton
            // 
            this.findRoutesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findRoutesButton.Location = new System.Drawing.Point(420, 110);
            this.findRoutesButton.Name = "findRoutesButton";
            this.findRoutesButton.Size = new System.Drawing.Size(201, 23);
            this.findRoutesButton.TabIndex = 5;
            this.findRoutesButton.Text = "Показати доступні рейси";
            this.findRoutesButton.UseVisualStyleBackColor = true;
            this.findRoutesButton.Click += new System.EventHandler(this.findRoutesButton_Click);
            // 
            // destinationBox
            // 
            this.destinationBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.destinationBox.CausesValidation = false;
            this.destinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(814, 59);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(155, 25);
            this.destinationBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата відправлення";
            // 
            // departureBox
            // 
            this.departureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureBox.FormattingEnabled = true;
            this.departureBox.Location = new System.Drawing.Point(218, 59);
            this.departureBox.Name = "departureBox";
            this.departureBox.Size = new System.Drawing.Size(167, 25);
            this.departureBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пункт призначення";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пункт відправлення";
            // 
            // listOfCitiesBindingSource1
            // 
            this.listOfCitiesBindingSource1.DataSource = typeof(WinFormsApp1.ListOfCities);
            // 
            // listOfCitiesBindingSource
            // 
            this.listOfCitiesBindingSource.DataSource = typeof(WinFormsApp1.ListOfCities);
            // 
            // panelRoutes
            // 
            this.panelRoutes.AutoScroll = true;
            this.panelRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRoutes.Controls.Add(this.panel3);
            this.panelRoutes.Controls.Add(this.panel2);
            this.panelRoutes.Location = new System.Drawing.Point(62, 253);
            this.panelRoutes.Name = "panelRoutes";
            this.panelRoutes.Size = new System.Drawing.Size(1058, 400);
            this.panelRoutes.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(12, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 78);
            this.panel3.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(783, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Детальна інформція про рейс";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Перейти до оформлення квитку";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 45);
            this.label8.TabIndex = 3;
            this.label8.Text = "Прибуття:\r\nКиїв\r\n16.05.2022 23:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Кількість вільних місць";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 45);
            this.label10.TabIndex = 1;
            this.label10.Text = "Відправлення:\r\nХарків\r\n23.02.2022 10:50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Рейс № 101";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 78);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Детальна інформція про рейс";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Перейти до оформлення квитку";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 45);
            this.label7.TabIndex = 3;
            this.label7.Text = "Прибуття:\r\nКиїв\r\n16.05.2022 23:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Кількість вільних місць";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Відправлення:\r\nХарків\r\n23.02.2022 10:50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Рейс № 101";
            // 
            // RouteChose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1176, 747);
            this.Controls.Add(this.panelRoutes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RouteChose";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource)).EndInit();
            this.panelRoutes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private ComboBox destinationBox;
        private ComboBox departureBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button findRoutesButton;
        private BindingSource listOfCitiesBindingSource1;
        private BindingSource listOfCitiesBindingSource;
        private DateTimePicker dateDepartureBox;
        private Panel panelRoutes;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private Button button3;
        private Button button4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}