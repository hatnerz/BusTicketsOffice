namespace WinFormsApp1
{
    partial class Ticketing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticketing));
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seatCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneMaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patronymicNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.routeNumberLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(256, 21);
            this.PageCaption.Name = "PageCaption";
            this.PageCaption.Size = new System.Drawing.Size(347, 45);
            this.PageCaption.TabIndex = 1;
            this.PageCaption.Text = "Оформлення квитку";
            this.PageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 405);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уважно перевіряйте введені дані перед оформленням квитку";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seatCombo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.phoneMaskTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.patronymicNameTextBox);
            this.groupBox3.Controls.Add(this.lastNameTextBox);
            this.groupBox3.Controls.Add(this.firstNameTextBox);
            this.groupBox3.Controls.Add(this.addTicketButton);
            this.groupBox3.Controls.Add(this.phoneNumber);
            this.groupBox3.Location = new System.Drawing.Point(33, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 189);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Інформація про пасажира";
            // 
            // seatCombo
            // 
            this.seatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seatCombo.FormattingEnabled = true;
            this.seatCombo.Location = new System.Drawing.Point(198, 118);
            this.seatCombo.Name = "seatCombo";
            this.seatCombo.Size = new System.Drawing.Size(121, 25);
            this.seatCombo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер місця";
            // 
            // phoneMaskTextBox
            // 
            this.phoneMaskTextBox.Location = new System.Drawing.Point(198, 33);
            this.phoneMaskTextBox.Mask = "(38\\0)00-000-00-00";
            this.phoneMaskTextBox.Name = "phoneMaskTextBox";
            this.phoneMaskTextBox.Size = new System.Drawing.Size(362, 24);
            this.phoneMaskTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ПІБ";
            // 
            // patronymicNameTextBox
            // 
            this.patronymicNameTextBox.Location = new System.Drawing.Point(566, 75);
            this.patronymicNameTextBox.Name = "patronymicNameTextBox";
            this.patronymicNameTextBox.PlaceholderText = "По-батькові";
            this.patronymicNameTextBox.Size = new System.Drawing.Size(178, 24);
            this.patronymicNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(382, 75);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "Ім\'я";
            this.lastNameTextBox.Size = new System.Drawing.Size(178, 24);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(198, 75);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "Прізвище";
            this.firstNameTextBox.Size = new System.Drawing.Size(178, 24);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(575, 136);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(192, 30);
            this.addTicketButton.TabIndex = 5;
            this.addTicketButton.Text = "Оформити квиток";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(29, 36);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(133, 17);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.Text = "Мобільний телефон";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceLabel);
            this.groupBox2.Controls.Add(this.destinationLabel);
            this.groupBox2.Controls.Add(this.routeNumberLabel);
            this.groupBox2.Controls.Add(this.departureLabel);
            this.groupBox2.Location = new System.Drawing.Point(33, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 164);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Інформація про рейс";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(29, 132);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(105, 17);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Вартість квитку";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(29, 95);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(68, 17);
            this.destinationLabel.TabIndex = 2;
            this.destinationLabel.Text = "Прибуття";
            // 
            // routeNumberLabel
            // 
            this.routeNumberLabel.AutoSize = true;
            this.routeNumberLabel.Location = new System.Drawing.Point(29, 32);
            this.routeNumberLabel.Name = "routeNumberLabel";
            this.routeNumberLabel.Size = new System.Drawing.Size(56, 17);
            this.routeNumberLabel.TabIndex = 0;
            this.routeNumberLabel.Text = "Рейс №";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Location = new System.Drawing.Point(29, 61);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(94, 17);
            this.departureLabel.TabIndex = 1;
            this.departureLabel.Text = "Відправлення";
            // 
            // Ticketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ticketing";
            this.Text = "BusTicketsOffice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private Label destinationLabel;
        private Label priceLabel;
        private GroupBox groupBox2;
        private Label routeNumberLabel;
        private Label departureLabel;
        private Label phoneNumber;
        private GroupBox groupBox3;
        private Button addTicketButton;
        private Label label1;
        private TextBox patronymicNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private MaskedTextBox phoneMaskTextBox;
        private ComboBox seatCombo;
        private Label label2;
    }
}