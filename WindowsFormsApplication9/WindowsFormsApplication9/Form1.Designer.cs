namespace WindowsFormsApplication9
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.indate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.Reserve = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Suite = new System.Windows.Forms.RadioButton();
            this.regular = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outdate = new System.Windows.Forms.DateTimePicker();
            this.room = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.half = new System.Windows.Forms.RadioButton();
            this.full = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.can = new System.Windows.Forms.GroupBox();
            this.c1 = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.empty = new System.Windows.Forms.Button();
            this.checkB = new System.Windows.Forms.Button();
            this.Reserve.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.can.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(12, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Replay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // indate
            // 
            this.indate.Location = new System.Drawing.Point(178, 208);
            this.indate.Name = "indate";
            this.indate.Size = new System.Drawing.Size(200, 22);
            this.indate.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(12, 100);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reserve";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reserve
            // 
            this.Reserve.BackColor = System.Drawing.Color.Transparent;
            this.Reserve.Controls.Add(this.label5);
            this.Reserve.Controls.Add(this.groupBox1);
            this.Reserve.Controls.Add(this.button4);
            this.Reserve.Controls.Add(this.label3);
            this.Reserve.Controls.Add(this.label2);
            this.Reserve.Controls.Add(this.outdate);
            this.Reserve.Controls.Add(this.room);
            this.Reserve.Controls.Add(this.textBox2);
            this.Reserve.Controls.Add(this.label1);
            this.Reserve.Controls.Add(this.indate);
            this.Reserve.Controls.Add(this.name);
            this.Reserve.Controls.Add(this.half);
            this.Reserve.Controls.Add(this.full);
            this.Reserve.ForeColor = System.Drawing.Color.Red;
            this.Reserve.Location = new System.Drawing.Point(257, 12);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(436, 317);
            this.Reserve.TabIndex = 4;
            this.Reserve.TabStop = false;
            this.Reserve.Text = "Reserve";
            this.Reserve.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(176, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "****Regular 001-500 ||Suite 501-600****";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Suite);
            this.groupBox1.Controls.Add(this.regular);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(6, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room";
            // 
            // Suite
            // 
            this.Suite.AutoSize = true;
            this.Suite.ForeColor = System.Drawing.Color.Red;
            this.Suite.Location = new System.Drawing.Point(0, 21);
            this.Suite.Name = "Suite";
            this.Suite.Size = new System.Drawing.Size(61, 21);
            this.Suite.TabIndex = 0;
            this.Suite.TabStop = true;
            this.Suite.Text = "Suite";
            this.Suite.UseVisualStyleBackColor = true;
            this.Suite.CheckedChanged += new System.EventHandler(this.Suite_CheckedChanged);
            // 
            // regular
            // 
            this.regular.AutoSize = true;
            this.regular.Location = new System.Drawing.Point(0, 110);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(79, 21);
            this.regular.TabIndex = 1;
            this.regular.TabStop = true;
            this.regular.Text = "Regular";
            this.regular.UseVisualStyleBackColor = true;
            this.regular.CheckedChanged += new System.EventHandler(this.regular_CheckedChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(143, 287);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Confirm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Room No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "From";
            // 
            // outdate
            // 
            this.outdate.Location = new System.Drawing.Point(178, 250);
            this.outdate.Name = "outdate";
            this.outdate.Size = new System.Drawing.Size(200, 22);
            this.outdate.TabIndex = 5;
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.ForeColor = System.Drawing.Color.White;
            this.room.Location = new System.Drawing.Point(94, 255);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(25, 17);
            this.room.TabIndex = 8;
            this.room.Text = "To";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(259, 132);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 22);
            this.name.TabIndex = 5;
            // 
            // half
            // 
            this.half.AutoSize = true;
            this.half.Location = new System.Drawing.Point(259, 21);
            this.half.Name = "half";
            this.half.Size = new System.Drawing.Size(96, 21);
            this.half.TabIndex = 3;
            this.half.TabStop = true;
            this.half.Text = "Half Board";
            this.half.UseVisualStyleBackColor = true;
            // 
            // full
            // 
            this.full.AutoSize = true;
            this.full.Location = new System.Drawing.Point(127, 21);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(93, 21);
            this.full.TabIndex = 2;
            this.full.TabStop = true;
            this.full.Text = "Full Board";
            this.full.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(563, 432);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.ForeColor = System.Drawing.Color.Red;
            this.cancel.Location = new System.Drawing.Point(12, 150);
            this.cancel.Margin = new System.Windows.Forms.Padding(1);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(132, 51);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel Reservation";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // can
            // 
            this.can.BackColor = System.Drawing.Color.Transparent;
            this.can.Controls.Add(this.c1);
            this.can.Controls.Add(this.c);
            this.can.Controls.Add(this.label4);
            this.can.Controls.Add(this.name1);
            this.can.ForeColor = System.Drawing.Color.White;
            this.can.Location = new System.Drawing.Point(107, 371);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(452, 100);
            this.can.TabIndex = 7;
            this.can.TabStop = false;
            this.can.Text = "Cancel";
            this.can.Visible = false;
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.c1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c1.ForeColor = System.Drawing.Color.Red;
            this.c1.Location = new System.Drawing.Point(181, 67);
            this.c1.Margin = new System.Windows.Forms.Padding(1);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(103, 26);
            this.c1.TabIndex = 14;
            this.c1.Text = "Check";
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Visible = false;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c.ForeColor = System.Drawing.Color.Red;
            this.c.Location = new System.Drawing.Point(345, 36);
            this.c.Margin = new System.Windows.Forms.Padding(1);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(103, 26);
            this.c.TabIndex = 12;
            this.c.Text = "Confirm";
            this.c.UseVisualStyleBackColor = false;
            this.c.Visible = false;
            this.c.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reservation number";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(150, 38);
            this.name1.Multiline = true;
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(171, 22);
            this.name1.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(12, 208);
            this.button7.Margin = new System.Windows.Forms.Padding(1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 51);
            this.button7.TabIndex = 8;
            this.button7.Text = "All Reservations";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(720, 33);
            this.all.Multiline = true;
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(516, 226);
            this.all.TabIndex = 9;
            this.all.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Luxury01-3000x1500.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication9.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(720, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 228);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication9.Properties.Resources.Untitled2;
            this.pictureBox2.Location = new System.Drawing.Point(720, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(463, 228);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // empty
            // 
            this.empty.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.empty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empty.ForeColor = System.Drawing.Color.Red;
            this.empty.Location = new System.Drawing.Point(12, 316);
            this.empty.Margin = new System.Windows.Forms.Padding(1);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(132, 51);
            this.empty.TabIndex = 12;
            this.empty.Text = "Empty The Hotel";
            this.empty.UseVisualStyleBackColor = false;
            this.empty.Visible = false;
            this.empty.Click += new System.EventHandler(this.button8_Click);
            // 
            // checkB
            // 
            this.checkB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkB.ForeColor = System.Drawing.Color.Red;
            this.checkB.Location = new System.Drawing.Point(10, 261);
            this.checkB.Margin = new System.Windows.Forms.Padding(1);
            this.checkB.Name = "checkB";
            this.checkB.Size = new System.Drawing.Size(132, 51);
            this.checkB.TabIndex = 13;
            this.checkB.Text = "Check Reservation";
            this.checkB.UseVisualStyleBackColor = false;
            this.checkB.Visible = false;
            this.checkB.Click += new System.EventHandler(this.checkB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication9.Properties.Resources.hotel;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.ControlBox = false;
            this.Controls.Add(this.checkB);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.all);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.can);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Islam Atef Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Reserve.ResumeLayout(false);
            this.Reserve.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.can.ResumeLayout(false);
            this.can.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker indate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox Reserve;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton half;
        private System.Windows.Forms.RadioButton full;
        private System.Windows.Forms.RadioButton regular;
        private System.Windows.Forms.RadioButton Suite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker outdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox can;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox all;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button empty;
        private System.Windows.Forms.Button checkB;
        private System.Windows.Forms.Button c1;
    }
}

