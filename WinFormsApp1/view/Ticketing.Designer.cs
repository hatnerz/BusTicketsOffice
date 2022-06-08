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
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.routeNumber = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.passanger = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.passanger);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 405);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уважно перевіряйте введені дані перед оформленням квитку";
            // 
            // routeNumber
            // 
            this.routeNumber.AutoSize = true;
            this.routeNumber.Location = new System.Drawing.Point(96, 37);
            this.routeNumber.Name = "routeNumber";
            this.routeNumber.Size = new System.Drawing.Size(56, 17);
            this.routeNumber.TabIndex = 0;
            this.routeNumber.Text = "Рейс №";
            // 
            // departure
            // 
            this.departure.AutoSize = true;
            this.departure.Location = new System.Drawing.Point(96, 66);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(94, 17);
            this.departure.TabIndex = 1;
            this.departure.Text = "Відправлення";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(96, 93);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(68, 17);
            this.destination.TabIndex = 2;
            this.destination.Text = "Прибуття";
            // 
            // passanger
            // 
            this.passanger.AutoSize = true;
            this.passanger.Location = new System.Drawing.Point(167, 231);
            this.passanger.Name = "passanger";
            this.passanger.Size = new System.Drawing.Size(43, 17);
            this.passanger.TabIndex = 3;
            this.passanger.Text = "label4";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(167, 272);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(43, 17);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.Text = "label5";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(96, 120);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(41, 17);
            this.price.TabIndex = 5;
            this.price.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.price);
            this.groupBox2.Controls.Add(this.destination);
            this.groupBox2.Controls.Add(this.routeNumber);
            this.groupBox2.Controls.Add(this.departure);
            this.groupBox2.Location = new System.Drawing.Point(34, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 189);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Ticketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Name = "Ticketing";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PageCaption;
        private GroupBox groupBox1;
        private Label destination;
        private Label price;
        private GroupBox groupBox2;
        private Label routeNumber;
        private Label departure;
        private Label phoneNumber;
        private Label passanger;
    }
}