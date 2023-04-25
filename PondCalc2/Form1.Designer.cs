namespace PondCalc2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAddressBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastNameBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.tbFirstNameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Filter = new System.Windows.Forms.CheckBox();
            this.Freshwater_mussels = new System.Windows.Forms.CheckBox();
            this.Algae_eater = new System.Windows.Forms.CheckBox();
            this.Koi_carps = new System.Windows.Forms.CheckBox();
            this.Pump = new System.Windows.Forms.CheckBox();
            this.Flowering = new System.Windows.Forms.CheckBox();
            this.Lights = new System.Windows.Forms.CheckBox();
            this.Lilles = new System.Windows.Forms.CheckBox();
            this.Hornwort = new System.Windows.Forms.CheckBox();
            this.Mermaid_Plant = new System.Windows.Forms.CheckBox();
            this.SubmitButtonExtras = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Lengthconvert = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.converter_confirmbox = new System.Windows.Forms.TextBox();
            this.tbQuote = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTotalResult = new System.Windows.Forms.TextBox();
            this.VolumeResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PerimeterResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AreaResult = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Load_Quote = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.thumbsup = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbsup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 425);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.TabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tbAddressBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbLastNameBox);
            this.tabPage1.Controls.Add(this.FirstName);
            this.tabPage1.Controls.Add(this.tbFirstNameBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(210, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbAddressBox
            // 
            this.tbAddressBox.Location = new System.Drawing.Point(152, 135);
            this.tbAddressBox.Multiline = true;
            this.tbAddressBox.Name = "tbAddressBox";
            this.tbAddressBox.Size = new System.Drawing.Size(202, 129);
            this.tbAddressBox.TabIndex = 15;
            this.tbAddressBox.Text = "\r\n\r\n\r\nPlease enter full address";
            this.tbAddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddressBox.Click += new System.EventHandler(this.TbAddressBox_Click);
            this.tbAddressBox.TextChanged += new System.EventHandler(this.TbAddressBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(149, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last name";
            // 
            // tbLastNameBox
            // 
            this.tbLastNameBox.Location = new System.Drawing.Point(210, 98);
            this.tbLastNameBox.Name = "tbLastNameBox";
            this.tbLastNameBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbLastNameBox.Size = new System.Drawing.Size(144, 20);
            this.tbLastNameBox.TabIndex = 13;
            this.tbLastNameBox.Text = "Please enter Last name";
            this.tbLastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLastNameBox.Click += new System.EventHandler(this.TbLastNameBox_Click);
            this.tbLastNameBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.White;
            this.FirstName.Location = new System.Drawing.Point(149, 78);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(55, 13);
            this.FirstName.TabIndex = 12;
            this.FirstName.Text = "First name";
            // 
            // tbFirstNameBox
            // 
            this.tbFirstNameBox.Location = new System.Drawing.Point(210, 75);
            this.tbFirstNameBox.Name = "tbFirstNameBox";
            this.tbFirstNameBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFirstNameBox.Size = new System.Drawing.Size(144, 20);
            this.tbFirstNameBox.TabIndex = 11;
            this.tbFirstNameBox.Text = "Please enter First name";
            this.tbFirstNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFirstNameBox.Click += new System.EventHandler(this.TbFirstNameBox_Click);
            this.tbFirstNameBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-139, -45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.SubmitButtonExtras);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Filter);
            this.groupBox1.Controls.Add(this.Freshwater_mussels);
            this.groupBox1.Controls.Add(this.Algae_eater);
            this.groupBox1.Controls.Add(this.Koi_carps);
            this.groupBox1.Controls.Add(this.Pump);
            this.groupBox1.Controls.Add(this.Flowering);
            this.groupBox1.Controls.Add(this.Lights);
            this.groupBox1.Controls.Add(this.Lilles);
            this.groupBox1.Controls.Add(this.Hornwort);
            this.groupBox1.Controls.Add(this.Mermaid_Plant);
            this.groupBox1.Location = new System.Drawing.Point(114, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 138);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Location = new System.Drawing.Point(111, 113);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(48, 17);
            this.Filter.TabIndex = 28;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            // 
            // Freshwater_mussels
            // 
            this.Freshwater_mussels.AutoSize = true;
            this.Freshwater_mussels.Location = new System.Drawing.Point(111, 90);
            this.Freshwater_mussels.Name = "Freshwater_mussels";
            this.Freshwater_mussels.Size = new System.Drawing.Size(64, 17);
            this.Freshwater_mussels.TabIndex = 27;
            this.Freshwater_mussels.Text = "Mussels";
            this.Freshwater_mussels.UseVisualStyleBackColor = true;
            this.Freshwater_mussels.CheckedChanged += new System.EventHandler(this.CheckBox9_CheckedChanged);
            // 
            // Algae_eater
            // 
            this.Algae_eater.AutoSize = true;
            this.Algae_eater.Location = new System.Drawing.Point(111, 67);
            this.Algae_eater.Name = "Algae_eater";
            this.Algae_eater.Size = new System.Drawing.Size(80, 17);
            this.Algae_eater.TabIndex = 26;
            this.Algae_eater.Text = "Algae eater";
            this.Algae_eater.UseVisualStyleBackColor = true;
            this.Algae_eater.CheckedChanged += new System.EventHandler(this.CheckBox8_CheckedChanged);
            // 
            // Koi_carps
            // 
            this.Koi_carps.AutoSize = true;
            this.Koi_carps.Location = new System.Drawing.Point(111, 43);
            this.Koi_carps.Name = "Koi_carps";
            this.Koi_carps.Size = new System.Drawing.Size(70, 17);
            this.Koi_carps.TabIndex = 25;
            this.Koi_carps.Text = "Koi carps";
            this.Koi_carps.UseVisualStyleBackColor = true;
            this.Koi_carps.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // Pump
            // 
            this.Pump.AutoSize = true;
            this.Pump.Location = new System.Drawing.Point(6, 19);
            this.Pump.Name = "Pump";
            this.Pump.Size = new System.Drawing.Size(53, 17);
            this.Pump.TabIndex = 19;
            this.Pump.Text = "Pump";
            this.Pump.UseVisualStyleBackColor = true;
            this.Pump.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Flowering
            // 
            this.Flowering.AutoSize = true;
            this.Flowering.Location = new System.Drawing.Point(111, 19);
            this.Flowering.Name = "Flowering";
            this.Flowering.Size = new System.Drawing.Size(94, 17);
            this.Flowering.TabIndex = 24;
            this.Flowering.Text = "Flowering rush";
            this.Flowering.UseVisualStyleBackColor = true;
            this.Flowering.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // Lights
            // 
            this.Lights.AutoSize = true;
            this.Lights.Location = new System.Drawing.Point(6, 43);
            this.Lights.Name = "Lights";
            this.Lights.Size = new System.Drawing.Size(54, 17);
            this.Lights.TabIndex = 20;
            this.Lights.Text = "Lights";
            this.Lights.UseVisualStyleBackColor = true;
            this.Lights.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Lilles
            // 
            this.Lilles.AutoSize = true;
            this.Lilles.Location = new System.Drawing.Point(6, 113);
            this.Lilles.Name = "Lilles";
            this.Lilles.Size = new System.Drawing.Size(80, 17);
            this.Lilles.TabIndex = 23;
            this.Lilles.Text = "Water lilies ";
            this.Lilles.UseVisualStyleBackColor = true;
            this.Lilles.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // Hornwort
            // 
            this.Hornwort.AutoSize = true;
            this.Hornwort.Location = new System.Drawing.Point(6, 67);
            this.Hornwort.Name = "Hornwort";
            this.Hornwort.Size = new System.Drawing.Size(69, 17);
            this.Hornwort.TabIndex = 21;
            this.Hornwort.Text = "Hornwort";
            this.Hornwort.UseVisualStyleBackColor = true;
            this.Hornwort.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // Mermaid_Plant
            // 
            this.Mermaid_Plant.AutoSize = true;
            this.Mermaid_Plant.Location = new System.Drawing.Point(6, 90);
            this.Mermaid_Plant.Name = "Mermaid_Plant";
            this.Mermaid_Plant.Size = new System.Drawing.Size(93, 17);
            this.Mermaid_Plant.TabIndex = 22;
            this.Mermaid_Plant.Text = "Mermaid Plant";
            this.Mermaid_Plant.UseVisualStyleBackColor = true;
            this.Mermaid_Plant.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // SubmitButtonExtras
            // 
            this.SubmitButtonExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SubmitButtonExtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButtonExtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitButtonExtras.FlatAppearance.BorderSize = 0;
            this.SubmitButtonExtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SubmitButtonExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButtonExtras.Location = new System.Drawing.Point(174, 296);
            this.SubmitButtonExtras.Name = "SubmitButtonExtras";
            this.SubmitButtonExtras.Size = new System.Drawing.Size(87, 49);
            this.SubmitButtonExtras.TabIndex = 18;
            this.SubmitButtonExtras.Text = "Submit\r\n";
            this.SubmitButtonExtras.UseVisualStyleBackColor = false;
            this.SubmitButtonExtras.Click += new System.EventHandler(this.SubmitButtonExtras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(145, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "please choose the matrial";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Concrete Paving 0.5m x 0.5m (£0.75/ea)",
            "Stone Paving 0.5m x 0.5m (£2.20/ea)",
            "Stone Paving 0.5m x 0.75m (£3.50/ea)",
            "Plain Concrete 0.5m Wide (£4/pm)",
            "Brick Paving 0.5m Wide (£20/pm)",
            "Decking 0.5m Wide (£20/pm)",
            "Wall 0.5m High (£60/pm)",
            "Loam 0.5m Wide (£80/pm)",
            "Clay 0.5m Wide (£90/pm)"});
            this.comboBox1.Location = new System.Drawing.Point(137, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-47, -42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(611, 445);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.Lengthconvert);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbLength);
            this.tabPage3.Controls.Add(this.tbWidth);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tbDepth);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(471, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // Lengthconvert
            // 
            this.Lengthconvert.FormattingEnabled = true;
            this.Lengthconvert.Items.AddRange(new object[] {
            "centimetres",
            "metres",
            "feet",
            "inches"});
            this.Lengthconvert.Location = new System.Drawing.Point(173, 115);
            this.Lengthconvert.Name = "Lengthconvert";
            this.Lengthconvert.Size = new System.Drawing.Size(144, 21);
            this.Lengthconvert.TabIndex = 18;
            this.Lengthconvert.SelectedIndexChanged += new System.EventHandler(this.Lengthconvert_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(197, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(136, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Depth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(137, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Width";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(173, 152);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(144, 20);
            this.tbLength.TabIndex = 19;
            this.tbLength.Text = "Please enter length of hole";
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLength.Click += new System.EventHandler(this.TbLength_Click);
            this.tbLength.TextChanged += new System.EventHandler(this.TbLength_TextChanged);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(173, 185);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(144, 20);
            this.tbWidth.TabIndex = 22;
            this.tbWidth.Text = "Please enter width of hole";
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWidth.Click += new System.EventHandler(this.TbWidth_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(132, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Length";
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(173, 219);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(144, 20);
            this.tbDepth.TabIndex = 21;
            this.tbDepth.Text = "Please enter depth of hole";
            this.tbDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDepth.Click += new System.EventHandler(this.TbDepth_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-60, -22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(611, 445);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.converter_confirmbox);
            this.tabPage4.Controls.Add(this.tbQuote);
            this.tabPage4.Controls.Add(this.PrintButton);
            this.tabPage4.Controls.Add(this.BackButton);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.tbTotalResult);
            this.tabPage4.Controls.Add(this.VolumeResult);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.PerimeterResult);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.AreaResult);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(471, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // converter_confirmbox
            // 
            this.converter_confirmbox.Location = new System.Drawing.Point(23, 20);
            this.converter_confirmbox.Name = "converter_confirmbox";
            this.converter_confirmbox.ReadOnly = true;
            this.converter_confirmbox.Size = new System.Drawing.Size(100, 20);
            this.converter_confirmbox.TabIndex = 23;
            this.converter_confirmbox.Text = "test";
            this.converter_confirmbox.Visible = false;
            this.converter_confirmbox.TextChanged += new System.EventHandler(this.Converter_confirmbox_TextChanged);
            // 
            // tbQuote
            // 
            this.tbQuote.BackColor = System.Drawing.Color.White;
            this.tbQuote.Location = new System.Drawing.Point(211, 162);
            this.tbQuote.Multiline = true;
            this.tbQuote.Name = "tbQuote";
            this.tbQuote.ReadOnly = true;
            this.tbQuote.Size = new System.Drawing.Size(144, 125);
            this.tbQuote.TabIndex = 22;
            this.tbQuote.TextChanged += new System.EventHandler(this.TbQuote_TextChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Location = new System.Drawing.Point(369, 335);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(96, 49);
            this.PrintButton.TabIndex = 18;
            this.PrintButton.Text = "Save and Print ";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(6, 335);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 49);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Back to the start of program";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(152, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Total";
            // 
            // tbTotalResult
            // 
            this.tbTotalResult.BackColor = System.Drawing.Color.White;
            this.tbTotalResult.Location = new System.Drawing.Point(211, 306);
            this.tbTotalResult.Name = "tbTotalResult";
            this.tbTotalResult.ReadOnly = true;
            this.tbTotalResult.Size = new System.Drawing.Size(144, 20);
            this.tbTotalResult.TabIndex = 18;
            this.tbTotalResult.Text = "Result will be here";
            this.tbTotalResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTotalResult.TextChanged += new System.EventHandler(this.TotalResult_TextChanged);
            // 
            // VolumeResult
            // 
            this.VolumeResult.BackColor = System.Drawing.Color.White;
            this.VolumeResult.Location = new System.Drawing.Point(211, 136);
            this.VolumeResult.Name = "VolumeResult";
            this.VolumeResult.ReadOnly = true;
            this.VolumeResult.Size = new System.Drawing.Size(144, 20);
            this.VolumeResult.TabIndex = 19;
            this.VolumeResult.Text = "Result will be here";
            this.VolumeResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(115, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Volume of a pond";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(115, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Perimeter of pond";
            // 
            // PerimeterResult
            // 
            this.PerimeterResult.BackColor = System.Drawing.Color.White;
            this.PerimeterResult.Location = new System.Drawing.Point(211, 95);
            this.PerimeterResult.Name = "PerimeterResult";
            this.PerimeterResult.ReadOnly = true;
            this.PerimeterResult.Size = new System.Drawing.Size(144, 20);
            this.PerimeterResult.TabIndex = 19;
            this.PerimeterResult.Text = "Result will be here";
            this.PerimeterResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(115, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Area of pond";
            // 
            // AreaResult
            // 
            this.AreaResult.BackColor = System.Drawing.Color.White;
            this.AreaResult.Location = new System.Drawing.Point(211, 58);
            this.AreaResult.Name = "AreaResult";
            this.AreaResult.ReadOnly = true;
            this.AreaResult.Size = new System.Drawing.Size(144, 20);
            this.AreaResult.TabIndex = 18;
            this.AreaResult.Text = "Result will be here";
            this.AreaResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AreaResult.TextChanged += new System.EventHandler(this.AreaResult_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PondCalc2.Properties.Resources.Picture_of_a_pond_50__smaller;
            this.pictureBox4.Location = new System.Drawing.Point(-4, -7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(479, 425);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.Load_Quote);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.Exit);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.thumbsup);
            this.tabPage5.Controls.Add(this.pictureBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(471, 399);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // Load_Quote
            // 
            this.Load_Quote.Location = new System.Drawing.Point(324, 345);
            this.Load_Quote.Name = "Load_Quote";
            this.Load_Quote.Size = new System.Drawing.Size(127, 33);
            this.Load_Quote.TabIndex = 25;
            this.Load_Quote.Text = "Load Quote";
            this.Load_Quote.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "New Quote";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(89, 347);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 46);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Your Quote has been Printed. Thank you!";
            // 
            // thumbsup
            // 
            this.thumbsup.BackColor = System.Drawing.Color.Transparent;
            this.thumbsup.BackgroundImage = global::PondCalc2.Properties.Resources.Picture_of_a_pond_50__smaller;
            this.thumbsup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thumbsup.Image = global::PondCalc2.Properties.Resources.Thumbs_up_png;
            this.thumbsup.Location = new System.Drawing.Point(-4, -7);
            this.thumbsup.Name = "thumbsup";
            this.thumbsup.Size = new System.Drawing.Size(479, 403);
            this.thumbsup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbsup.TabIndex = 19;
            this.thumbsup.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PondCalc2.Properties.Resources.Picture_of_a_pond_50__smaller;
            this.pictureBox5.Location = new System.Drawing.Point(-4, -7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(479, 403);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // fadeIn
            // 
            this.fadeIn.Interval = 50;
            // 
            // fadeOut
            // 
            this.fadeOut.Enabled = true;
            this.fadeOut.Interval = 5;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(496, 443);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pond Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbsup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAddressBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastNameBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox tbFirstNameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SubmitButtonExtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox Lengthconvert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTotalResult;
        private System.Windows.Forms.TextBox VolumeResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PerimeterResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AreaResult;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbQuote;
        private System.Windows.Forms.TextBox converter_confirmbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox thumbsup;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox Flowering;
        private System.Windows.Forms.CheckBox Lilles;
        private System.Windows.Forms.CheckBox Mermaid_Plant;
        private System.Windows.Forms.CheckBox Hornwort;
        private System.Windows.Forms.CheckBox Lights;
        private System.Windows.Forms.CheckBox Pump;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Freshwater_mussels;
        private System.Windows.Forms.CheckBox Algae_eater;
        private System.Windows.Forms.CheckBox Koi_carps;
        private System.Windows.Forms.CheckBox Filter;
        private System.Windows.Forms.Button Load_Quote;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

