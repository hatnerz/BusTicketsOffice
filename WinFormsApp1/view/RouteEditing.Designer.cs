namespace WinFormsApp1
{
    partial class RouteEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteEditing));
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteRouteButton = new System.Windows.Forms.Button();
            this.dateRoutePicker = new System.Windows.Forms.DateTimePicker();
            this.routeChose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seatNumberAdd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.stopsInfoAdd = new System.Windows.Forms.TextBox();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.routeNumberAdd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addCity = new System.Windows.Forms.Button();
            this.cityName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteUnused = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeNumberAdd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(323, 21);
            this.PageCaption.Name = "PageCaption";
            this.PageCaption.Size = new System.Drawing.Size(333, 45);
            this.PageCaption.TabIndex = 1;
            this.PageCaption.Text = "Редагування рейсів";
            this.PageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteRouteButton);
            this.groupBox1.Controls.Add(this.dateRoutePicker);
            this.groupBox1.Controls.Add(this.routeChose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Location = new System.Drawing.Point(30, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Видалення рейсів";
            // 
            // deleteRouteButton
            // 
            this.deleteRouteButton.Location = new System.Drawing.Point(120, 134);
            this.deleteRouteButton.Name = "deleteRouteButton";
            this.deleteRouteButton.Size = new System.Drawing.Size(144, 23);
            this.deleteRouteButton.TabIndex = 4;
            this.deleteRouteButton.Text = "Видалити рейс";
            this.deleteRouteButton.UseVisualStyleBackColor = true;
            this.deleteRouteButton.Click += new System.EventHandler(this.deleteRouteButton_Click);
            // 
            // dateRoutePicker
            // 
            this.dateRoutePicker.Location = new System.Drawing.Point(120, 50);
            this.dateRoutePicker.MinDate = new System.DateTime(1753, 1, 20, 0, 0, 0, 0);
            this.dateRoutePicker.Name = "dateRoutePicker";
            this.dateRoutePicker.Size = new System.Drawing.Size(200, 23);
            this.dateRoutePicker.TabIndex = 3;
            this.dateRoutePicker.ValueChanged += new System.EventHandler(this.dateRoutePicker_ValueChanged);
            // 
            // routeChose
            // 
            this.routeChose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.routeChose.FormattingEnabled = true;
            this.routeChose.Location = new System.Drawing.Point(120, 84);
            this.routeChose.Name = "routeChose";
            this.routeChose.Size = new System.Drawing.Size(199, 23);
            this.routeChose.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть рейс";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(25, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(86, 15);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Виберіть дату";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.seatNumberAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.stopsInfoAdd);
            this.groupBox2.Controls.Add(this.addRouteButton);
            this.groupBox2.Controls.Add(this.routeNumberAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(460, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 341);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додавання рейсів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "У форматі: \"НазваЗупинки ДатаВідправлення Вартість\"\r\n";
            // 
            // seatNumberAdd
            // 
            this.seatNumberAdd.Location = new System.Drawing.Point(364, 263);
            this.seatNumberAdd.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.seatNumberAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatNumberAdd.Name = "seatNumberAdd";
            this.seatNumberAdd.Size = new System.Drawing.Size(70, 23);
            this.seatNumberAdd.TabIndex = 13;
            this.seatNumberAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Кількість місць";
            // 
            // stopsInfoAdd
            // 
            this.stopsInfoAdd.Location = new System.Drawing.Point(57, 68);
            this.stopsInfoAdd.Multiline = true;
            this.stopsInfoAdd.Name = "stopsInfoAdd";
            this.stopsInfoAdd.Size = new System.Drawing.Size(377, 168);
            this.stopsInfoAdd.TabIndex = 11;
            // 
            // addRouteButton
            // 
            this.addRouteButton.Location = new System.Drawing.Point(176, 302);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.Size = new System.Drawing.Size(144, 23);
            this.addRouteButton.TabIndex = 5;
            this.addRouteButton.Text = "Додати рейс";
            this.addRouteButton.UseVisualStyleBackColor = true;
            this.addRouteButton.Click += new System.EventHandler(this.addRouteButton_Click);
            // 
            // routeNumberAdd
            // 
            this.routeNumberAdd.Location = new System.Drawing.Point(146, 263);
            this.routeNumberAdd.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.routeNumberAdd.Name = "routeNumberAdd";
            this.routeNumberAdd.Size = new System.Drawing.Size(76, 23);
            this.routeNumberAdd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Інформація про зупинки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер рейсу";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addCity);
            this.groupBox3.Controls.Add(this.cityName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.deleteUnused);
            this.groupBox3.Location = new System.Drawing.Point(30, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 141);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редагування списку зупинок";
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(243, 90);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(144, 23);
            this.addCity.TabIndex = 3;
            this.addCity.Text = "Додати до списку";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(24, 91);
            this.cityName.Name = "cityName";
            this.cityName.PlaceholderText = "Назва зупинки для додавання";
            this.cityName.Size = new System.Drawing.Size(191, 23);
            this.cityName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Видалити назви зупинок, \r\nякі не використовуються";
            // 
            // deleteUnused
            // 
            this.deleteUnused.Location = new System.Drawing.Point(243, 37);
            this.deleteUnused.Name = "deleteUnused";
            this.deleteUnused.Size = new System.Drawing.Size(144, 23);
            this.deleteUnused.TabIndex = 0;
            this.deleteUnused.Text = "Видалити зі списку";
            this.deleteUnused.UseVisualStyleBackColor = true;
            this.deleteUnused.Click += new System.EventHandler(this.deleteUnused_Click);
            // 
            // RouteEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouteEditing";
            this.Text = "BusTicketsOffice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeNumberAdd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private Button deleteRouteButton;
        private DateTimePicker dateRoutePicker;
        private ComboBox routeChose;
        private Label label1;
        private Label dateLabel;
        private GroupBox groupBox2;
        private Label label5;
        private Label label2;
        private NumericUpDown routeNumberAdd;
        private Button addRouteButton;
        private TextBox stopsInfoAdd;
        private NumericUpDown seatNumberAdd;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox cityName;
        private Label label6;
        private Button deleteUnused;
        private Button addCity;
    }
}