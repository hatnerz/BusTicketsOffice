﻿namespace WinFormsApp1
{
    partial class TicketsReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showTickets = new System.Windows.Forms.Button();
            this.phoneMaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.passangerTicketsGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.routeChoseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnTicketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.routeInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passangerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passangerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passangerPatronymicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passangerTicketsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(321, 34);
            this.PageCaption.Name = "PageCaption";
            this.PageCaption.Size = new System.Drawing.Size(341, 45);
            this.PageCaption.TabIndex = 3;
            this.PageCaption.Text = "Повернення квитків";
            this.PageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.showTickets);
            this.groupBox1.Controls.Add(this.phoneMaskTextBox);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть номер телефону для отримання інформації про квитки";
            // 
            // showTickets
            // 
            this.showTickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showTickets.Location = new System.Drawing.Point(588, 48);
            this.showTickets.Name = "showTickets";
            this.showTickets.Size = new System.Drawing.Size(127, 23);
            this.showTickets.TabIndex = 13;
            this.showTickets.Text = "Показати квитки";
            this.showTickets.UseVisualStyleBackColor = true;
            this.showTickets.Click += new System.EventHandler(this.showTickets_Click);
            // 
            // phoneMaskTextBox
            // 
            this.phoneMaskTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneMaskTextBox.Location = new System.Drawing.Point(394, 48);
            this.phoneMaskTextBox.Mask = "(38\\0)00-000-00-00";
            this.phoneMaskTextBox.Name = "phoneMaskTextBox";
            this.phoneMaskTextBox.Size = new System.Drawing.Size(128, 23);
            this.phoneMaskTextBox.TabIndex = 12;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(202, 51);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(124, 15);
            this.phoneNumber.TabIndex = 11;
            this.phoneNumber.Text = "Мобільний телефон";
            // 
            // passangerTicketsGrid
            // 
            this.passangerTicketsGrid.AllowUserToAddRows = false;
            this.passangerTicketsGrid.AllowUserToDeleteRows = false;
            this.passangerTicketsGrid.AllowUserToResizeColumns = false;
            this.passangerTicketsGrid.AllowUserToResizeRows = false;
            this.passangerTicketsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passangerTicketsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passangerTicketsGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.passangerTicketsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passangerTicketsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeInfo,
            this.seatNumber,
            this.departureStop,
            this.destination,
            this.price,
            this.passangerName,
            this.passangerLastName,
            this.passangerPatronymicName,
            this.dataGridViewTextBoxColumn1});
            this.passangerTicketsGrid.Location = new System.Drawing.Point(12, 197);
            this.passangerTicketsGrid.Name = "passangerTicketsGrid";
            this.passangerTicketsGrid.RowTemplate.Height = 25;
            this.passangerTicketsGrid.Size = new System.Drawing.Size(958, 373);
            this.passangerTicketsGrid.TabIndex = 5;
            this.passangerTicketsGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.passangerTicketsGrid_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeChoseMenuItem,
            this.returnTicketMenuItem,
            this.routeEditMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // routeChoseMenuItem
            // 
            this.routeChoseMenuItem.Name = "routeChoseMenuItem";
            this.routeChoseMenuItem.Size = new System.Drawing.Size(142, 20);
            this.routeChoseMenuItem.Text = "Оформлення квитків";
            this.routeChoseMenuItem.Click += new System.EventHandler(this.routeChoseMenuItem_Click);
            // 
            // returnTicketMenuItem
            // 
            this.returnTicketMenuItem.Name = "returnTicketMenuItem";
            this.returnTicketMenuItem.Size = new System.Drawing.Size(138, 20);
            this.returnTicketMenuItem.Text = "Повернення квитків";
            // 
            // routeEditMenuItem
            // 
            this.routeEditMenuItem.Name = "routeEditMenuItem";
            this.routeEditMenuItem.Size = new System.Drawing.Size(132, 20);
            this.routeEditMenuItem.Text = "Редагування рейсів";
            this.routeEditMenuItem.Click += new System.EventHandler(this.routeEditMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // routeInfo
            // 
            this.routeInfo.DataPropertyName = "routeInfo";
            this.routeInfo.HeaderText = "Номер рейсу";
            this.routeInfo.Name = "routeInfo";
            // 
            // seatNumber
            // 
            this.seatNumber.DataPropertyName = "seatNumber";
            this.seatNumber.HeaderText = "Місце";
            this.seatNumber.Name = "seatNumber";
            // 
            // departureStop
            // 
            this.departureStop.DataPropertyName = "departure";
            this.departureStop.HeaderText = "Відправлення";
            this.departureStop.Name = "departureStop";
            // 
            // destination
            // 
            this.destination.DataPropertyName = "destination";
            this.destination.HeaderText = "Прибуття";
            this.destination.Name = "destination";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle1;
            this.price.HeaderText = "Вартість квитку";
            this.price.Name = "price";
            // 
            // passangerName
            // 
            this.passangerName.DataPropertyName = "firstName";
            this.passangerName.HeaderText = "Ім\'я";
            this.passangerName.Name = "passangerName";
            // 
            // passangerLastName
            // 
            this.passangerLastName.DataPropertyName = "lastName";
            this.passangerLastName.HeaderText = "Прізвище";
            this.passangerLastName.Name = "passangerLastName";
            // 
            // passangerPatronymicName
            // 
            this.passangerPatronymicName.DataPropertyName = "patronymicName";
            this.passangerPatronymicName.HeaderText = "По-батькові";
            this.passangerPatronymicName.Name = "passangerPatronymicName";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "passangerPhoneNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "phoneNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // TicketsReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 582);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.passangerTicketsGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "TicketsReturn";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passangerTicketsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private Button showTickets;
        private MaskedTextBox phoneMaskTextBox;
        private Label phoneNumber;
        private DataGridView passangerTicketsGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem routeChoseMenuItem;
        private ToolStripMenuItem returnTicketMenuItem;
        private ToolStripMenuItem routeEditMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private DataGridViewTextBoxColumn routeInfo;
        private DataGridViewTextBoxColumn seatNumber;
        private DataGridViewTextBoxColumn departureStop;
        private DataGridViewTextBoxColumn destination;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn passangerName;
        private DataGridViewTextBoxColumn passangerLastName;
        private DataGridViewTextBoxColumn passangerPatronymicName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}