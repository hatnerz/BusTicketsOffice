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
            this.PageCaption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteRouteButton = new System.Windows.Forms.Button();
            this.dateRoutePicker = new System.Windows.Forms.DateTimePicker();
            this.routeChose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.routeNumberAdd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopsInfoAdd = new System.Windows.Forms.TextBox();
            this.seatNumberAdd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.routeChoseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnTicketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeNumberAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberAdd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageCaption
            // 
            this.PageCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PageCaption.AutoSize = true;
            this.PageCaption.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageCaption.Location = new System.Drawing.Point(323, 38);
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
            this.groupBox1.Size = new System.Drawing.Size(406, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Видалення рейсів";
            // 
            // deleteRouteButton
            // 
            this.deleteRouteButton.Location = new System.Drawing.Point(93, 134);
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
            this.label5.Location = new System.Drawing.Point(57, 34);
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
            // stopsInfoAdd
            // 
            this.stopsInfoAdd.Location = new System.Drawing.Point(57, 68);
            this.stopsInfoAdd.Multiline = true;
            this.stopsInfoAdd.Name = "stopsInfoAdd";
            this.stopsInfoAdd.Size = new System.Drawing.Size(377, 168);
            this.stopsInfoAdd.TabIndex = 11;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeChoseMenuItem,
            this.returnTicketMenuItem,
            this.routeEditMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 5;
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
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // RouteEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PageCaption);
            this.Name = "RouteEditing";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeNumberAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatNumberAdd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem routeChoseMenuItem;
        private ToolStripMenuItem returnTicketMenuItem;
        private ToolStripMenuItem routeEditMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
    }
}