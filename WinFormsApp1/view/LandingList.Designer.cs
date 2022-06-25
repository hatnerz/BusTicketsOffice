namespace WinFormsApp1
{
    partial class LandingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingList));
            this.formListButton = new System.Windows.Forms.Button();
            this.dateRoutePicker = new System.Windows.Forms.DateTimePicker();
            this.routeChose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.landingListTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formListButton
            // 
            this.formListButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formListButton.Location = new System.Drawing.Point(249, 90);
            this.formListButton.Name = "formListButton";
            this.formListButton.Size = new System.Drawing.Size(144, 23);
            this.formListButton.TabIndex = 9;
            this.formListButton.Text = "Сформувати";
            this.formListButton.UseVisualStyleBackColor = true;
            this.formListButton.Click += new System.EventHandler(this.formListButton_Click);
            // 
            // dateRoutePicker
            // 
            this.dateRoutePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateRoutePicker.Location = new System.Drawing.Point(110, 48);
            this.dateRoutePicker.MinDate = new System.DateTime(1753, 1, 20, 0, 0, 0, 0);
            this.dateRoutePicker.Name = "dateRoutePicker";
            this.dateRoutePicker.Size = new System.Drawing.Size(191, 23);
            this.dateRoutePicker.TabIndex = 8;
            this.dateRoutePicker.ValueChanged += new System.EventHandler(this.dateRoutePicker_ValueChanged);
            // 
            // routeChose
            // 
            this.routeChose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.routeChose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.routeChose.FormattingEnabled = true;
            this.routeChose.Location = new System.Drawing.Point(428, 48);
            this.routeChose.Name = "routeChose";
            this.routeChose.Size = new System.Drawing.Size(201, 23);
            this.routeChose.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Виберіть рейс";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(18, 51);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(86, 15);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Виберіть дату";
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(47, 22);
            this.PageCaption.Name = "PageCaption";
            this.PageCaption.Size = new System.Drawing.Size(573, 45);
            this.PageCaption.TabIndex = 10;
            this.PageCaption.Text = "Формування посадкової відомості";
            this.PageCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.landingListTextBox);
            this.groupBox1.Controls.Add(this.dateRoutePicker);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.formListButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.routeChose);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 472);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виберіть дату та рейс для формування посадкової відомості";
            // 
            // landingListTextBox
            // 
            this.landingListTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.landingListTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.landingListTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.landingListTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.landingListTextBox.Location = new System.Drawing.Point(20, 136);
            this.landingListTextBox.Multiline = true;
            this.landingListTextBox.Name = "landingListTextBox";
            this.landingListTextBox.ReadOnly = true;
            this.landingListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.landingListTextBox.Size = new System.Drawing.Size(609, 318);
            this.landingListTextBox.TabIndex = 10;
            // 
            // LandingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "LandingList";
            this.Text = "BusTicketsOffice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button formListButton;
        private DateTimePicker dateRoutePicker;
        private ComboBox routeChose;
        private Label label1;
        private Label dateLabel;
        private Label PageCaption;
        private GroupBox groupBox1;
        private TextBox landingListTextBox;
    }
}