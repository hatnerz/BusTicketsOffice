namespace WinFormsApp1.controller
{
    partial class ticketsReturn
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
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneMaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.routeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passangerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(321, 9);
            this.PageCaption.Name = "PageCaption";
            this.PageCaption.Size = new System.Drawing.Size(341, 45);
            this.PageCaption.TabIndex = 3;
            this.PageCaption.Text = "Повернення квитків";
            this.PageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.phoneMaskTextBox);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть номер телефону для отримання інформації про квитки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Показати квитки";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // phoneMaskTextBox
            // 
            this.phoneMaskTextBox.Location = new System.Drawing.Point(394, 48);
            this.phoneMaskTextBox.Mask = "(38\\0)00-000-00-00";
            this.phoneMaskTextBox.Name = "phoneMaskTextBox";
            this.phoneMaskTextBox.Size = new System.Drawing.Size(128, 23);
            this.phoneMaskTextBox.TabIndex = 12;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(202, 51);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(124, 15);
            this.phoneNumber.TabIndex = 11;
            this.phoneNumber.Text = "Мобільний телефон";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeNumber,
            this.departureStop,
            this.departureTime,
            this.destination,
            this.destinationTime,
            this.passangerName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(958, 266);
            this.dataGridView1.TabIndex = 5;
            // 
            // routeNumber
            // 
            this.routeNumber.HeaderText = "Номер рейсу";
            this.routeNumber.Name = "routeNumber";
            // 
            // departureStop
            // 
            this.departureStop.HeaderText = "Відправлення";
            this.departureStop.Name = "departureStop";
            // 
            // departureTime
            // 
            this.departureTime.HeaderText = "Час відправлення";
            this.departureTime.Name = "departureTime";
            // 
            // destination
            // 
            this.destination.HeaderText = "Прибуття";
            this.destination.Name = "destination";
            // 
            // destinationTime
            // 
            this.destinationTime.HeaderText = "Час прибуття";
            this.destinationTime.Name = "destinationTime";
            // 
            // passangerName
            // 
            this.passangerName.HeaderText = "Пасажир";
            this.passangerName.Name = "passangerName";
            // 
            // ticketsReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Name = "ticketsReturn";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private Button button1;
        private MaskedTextBox phoneMaskTextBox;
        private Label phoneNumber;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn routeNumber;
        private DataGridViewTextBoxColumn departureStop;
        private DataGridViewTextBoxColumn departureTime;
        private DataGridViewTextBoxColumn destination;
        private DataGridViewTextBoxColumn destinationTime;
        private DataGridViewTextBoxColumn passangerName;
    }
}