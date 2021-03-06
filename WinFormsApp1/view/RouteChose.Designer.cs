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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteChose));
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
            this.label12 = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.routeChoseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnTicketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource)).BeginInit();
            this.panelRoutes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(424, 33);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(30, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть зі списку дату та пункт відправлення, пункт призначення для отримання ін" +
    "формації і оформлення квитків";
            // 
            // dateDepartureBox
            // 
            this.dateDepartureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateDepartureBox.Location = new System.Drawing.Point(510, 62);
            this.dateDepartureBox.Name = "dateDepartureBox";
            this.dateDepartureBox.Size = new System.Drawing.Size(179, 23);
            this.dateDepartureBox.TabIndex = 6;
            // 
            // findRoutesButton
            // 
            this.findRoutesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findRoutesButton.Location = new System.Drawing.Point(429, 108);
            this.findRoutesButton.Name = "findRoutesButton";
            this.findRoutesButton.Size = new System.Drawing.Size(201, 29);
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
            this.destinationBox.Location = new System.Drawing.Point(875, 62);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(141, 23);
            this.destinationBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата відправлення";
            // 
            // departureBox
            // 
            this.departureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureBox.FormattingEnabled = true;
            this.departureBox.Location = new System.Drawing.Point(185, 62);
            this.departureBox.Name = "departureBox";
            this.departureBox.Size = new System.Drawing.Size(151, 23);
            this.departureBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пункт призначення";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
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
            this.panelRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelRoutes.AutoScroll = true;
            this.panelRoutes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRoutes.Controls.Add(this.label12);
            this.panelRoutes.Controls.Add(this.panel3);
            this.panelRoutes.Controls.Add(this.panel2);
            this.panelRoutes.Location = new System.Drawing.Point(30, 253);
            this.panelRoutes.Name = "panelRoutes";
            this.panelRoutes.Size = new System.Drawing.Size(1058, 400);
            this.panelRoutes.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Найближчий";
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeChoseMenuItem,
            this.returnTicketMenuItem,
            this.routeEditMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // routeChoseMenuItem
            // 
            this.routeChoseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.routeChoseMenuItem.Name = "routeChoseMenuItem";
            this.routeChoseMenuItem.Size = new System.Drawing.Size(50, 20);
            this.routeChoseMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // returnTicketMenuItem
            // 
            this.returnTicketMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.returnTicketMenuItem.Name = "returnTicketMenuItem";
            this.returnTicketMenuItem.Size = new System.Drawing.Size(62, 20);
            this.returnTicketMenuItem.Text = "Квитки";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnToolStripMenuItem.Text = "Повернення";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // routeEditMenuItem
            // 
            this.routeEditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editingToolStripMenuItem,
            this.landingListToolStripMenuItem});
            this.routeEditMenuItem.Name = "routeEditMenuItem";
            this.routeEditMenuItem.Size = new System.Drawing.Size(55, 20);
            this.routeEditMenuItem.Text = "Рейси";
            // 
            // editingToolStripMenuItem
            // 
            this.editingToolStripMenuItem.Name = "editingToolStripMenuItem";
            this.editingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editingToolStripMenuItem.Text = "Редагування";
            this.editingToolStripMenuItem.Click += new System.EventHandler(this.editingToolStripMenuItem_Click);
            // 
            // landingListToolStripMenuItem
            // 
            this.landingListToolStripMenuItem.Name = "landingListToolStripMenuItem";
            this.landingListToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.landingListToolStripMenuItem.Text = "Посадкові відомості";
            this.landingListToolStripMenuItem.Click += new System.EventHandler(this.landingListToolStripMenuItem_Click);
            // 
            // RouteChose
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1122, 676);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelRoutes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1138, 715);
            this.Name = "RouteChose";
            this.Text = "BusTicketsOffice";
            this.Activated += new System.EventHandler(this.RouteChose_Activated);
            this.Load += new System.EventHandler(this.RouteChose_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource)).EndInit();
            this.panelRoutes.ResumeLayout(false);
            this.panelRoutes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem routeChoseMenuItem;
        private ToolStripMenuItem returnTicketMenuItem;
        private ToolStripMenuItem routeEditMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem editingToolStripMenuItem;
        private ToolStripMenuItem landingListToolStripMenuItem;
        private Label label12;
    }
}