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
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.findRoutesButton = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfCitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listOfCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource)).BeginInit();
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
            this.groupBox1.Controls.Add(this.dateDeparture);
            this.groupBox1.Controls.Add(this.findRoutesButton);
            this.groupBox1.Controls.Add(this.destination);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.departure);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(62, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть зі списку дату та пункт відправлення, пункт призначення для отримання ін" +
    "формації";
            // 
            // dateDeparture
            // 
            this.dateDeparture.Location = new System.Drawing.Point(518, 59);
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Size = new System.Drawing.Size(134, 25);
            this.dateDeparture.TabIndex = 6;
            // 
            // findRoutesButton
            // 
            this.findRoutesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findRoutesButton.Location = new System.Drawing.Point(413, 110);
            this.findRoutesButton.Name = "findRoutesButton";
            this.findRoutesButton.Size = new System.Drawing.Size(201, 23);
            this.findRoutesButton.TabIndex = 5;
            this.findRoutesButton.Text = "Показати доступні рейси";
            this.findRoutesButton.UseVisualStyleBackColor = true;
            this.findRoutesButton.Click += new System.EventHandler(this.findRoutesButton_Click);
            // 
            // destination
            // 
            this.destination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(807, 59);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(155, 25);
            this.destination.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата відправлення";
            // 
            // departure
            // 
            this.departure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departure.FormattingEnabled = true;
            this.departure.Location = new System.Drawing.Point(211, 59);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(167, 25);
            this.departure.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пункт призначення";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 62);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(62, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 400);
            this.panel1.TabIndex = 3;
            // 
            // RouteChose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1176, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RouteChose";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private ComboBox destination;
        private ComboBox departure;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button findRoutesButton;
        private BindingSource listOfCitiesBindingSource1;
        private BindingSource listOfCitiesBindingSource;
        private DateTimePicker dateDeparture;
        private Panel panel1;
    }
}