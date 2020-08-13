namespace Assignment3_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnStopAxfood = new System.Windows.Forms.Button();
            this.btnStartAxfood = new System.Windows.Forms.Button();
            this.lblStatusAxfood = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnStopArla = new System.Windows.Forms.Button();
            this.btnStartArla = new System.Windows.Forms.Button();
            this.lblStatusArla = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.lblStatusScan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.btnStopCity = new System.Windows.Forms.Button();
            this.btnStartCity = new System.Windows.Forms.Button();
            this.chkCityCont = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblCityVolume = new System.Windows.Forms.Label();
            this.lblCityWeight = new System.Windows.Forms.Label();
            this.lblCityItem = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblCityStatus = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lstCoop = new System.Windows.Forms.ListBox();
            this.btnStopCoop = new System.Windows.Forms.Button();
            this.btnStartCoop = new System.Windows.Forms.Button();
            this.chkCoopCont = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblCoopVolume = new System.Windows.Forms.Label();
            this.lblCoopWeight = new System.Windows.Forms.Label();
            this.lblCoopItem = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCoopStatus = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lstIca = new System.Windows.Forms.ListBox();
            this.btnStopIca = new System.Windows.Forms.Button();
            this.btnStartIca = new System.Windows.Forms.Button();
            this.chkIcaCont = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblIcaVolume = new System.Windows.Forms.Label();
            this.lblIcaWeight = new System.Windows.Forms.Label();
            this.lblIcaItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIcaStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressItems = new System.Windows.Forms.ProgressBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producers";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnStopAxfood);
            this.groupBox6.Controls.Add(this.btnStartAxfood);
            this.groupBox6.Controls.Add(this.lblStatusAxfood);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(6, 262);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(217, 100);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Producer: AxFood";
            // 
            // btnStopAxfood
            // 
            this.btnStopAxfood.Enabled = false;
            this.btnStopAxfood.Location = new System.Drawing.Point(149, 58);
            this.btnStopAxfood.Name = "btnStopAxfood";
            this.btnStopAxfood.Size = new System.Drawing.Size(48, 23);
            this.btnStopAxfood.TabIndex = 3;
            this.btnStopAxfood.Text = "Stop";
            this.btnStopAxfood.UseVisualStyleBackColor = true;
            this.btnStopAxfood.Click += new System.EventHandler(this.btnStopAxfood_Click);
            // 
            // btnStartAxfood
            // 
            this.btnStartAxfood.Location = new System.Drawing.Point(29, 59);
            this.btnStartAxfood.Name = "btnStartAxfood";
            this.btnStartAxfood.Size = new System.Drawing.Size(99, 23);
            this.btnStartAxfood.TabIndex = 2;
            this.btnStartAxfood.Text = "Start Producing";
            this.btnStartAxfood.UseVisualStyleBackColor = true;
            this.btnStartAxfood.Click += new System.EventHandler(this.btnStartAxfood_Click);
            // 
            // lblStatusAxfood
            // 
            this.lblStatusAxfood.AutoSize = true;
            this.lblStatusAxfood.Location = new System.Drawing.Point(80, 31);
            this.lblStatusAxfood.Name = "lblStatusAxfood";
            this.lblStatusAxfood.Size = new System.Drawing.Size(35, 13);
            this.lblStatusAxfood.TabIndex = 1;
            this.lblStatusAxfood.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnStopArla);
            this.groupBox5.Controls.Add(this.btnStartArla);
            this.groupBox5.Controls.Add(this.lblStatusArla);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(6, 139);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Producer: Arla";
            // 
            // btnStopArla
            // 
            this.btnStopArla.Enabled = false;
            this.btnStopArla.Location = new System.Drawing.Point(149, 58);
            this.btnStopArla.Name = "btnStopArla";
            this.btnStopArla.Size = new System.Drawing.Size(48, 23);
            this.btnStopArla.TabIndex = 3;
            this.btnStopArla.Text = "Stop";
            this.btnStopArla.UseVisualStyleBackColor = true;
            this.btnStopArla.Click += new System.EventHandler(this.btnStopArla_Click);
            // 
            // btnStartArla
            // 
            this.btnStartArla.Location = new System.Drawing.Point(29, 59);
            this.btnStartArla.Name = "btnStartArla";
            this.btnStartArla.Size = new System.Drawing.Size(99, 23);
            this.btnStartArla.TabIndex = 2;
            this.btnStartArla.Text = "Start Producing";
            this.btnStartArla.UseVisualStyleBackColor = true;
            this.btnStartArla.Click += new System.EventHandler(this.btnStartArla_Click);
            // 
            // lblStatusArla
            // 
            this.lblStatusArla.AutoSize = true;
            this.lblStatusArla.Location = new System.Drawing.Point(80, 31);
            this.lblStatusArla.Name = "lblStatusArla";
            this.lblStatusArla.Size = new System.Drawing.Size(35, 13);
            this.lblStatusArla.TabIndex = 1;
            this.lblStatusArla.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStopScan);
            this.groupBox4.Controls.Add(this.btnStartScan);
            this.groupBox4.Controls.Add(this.lblStatusScan);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producer: Scan";
            // 
            // btnStopScan
            // 
            this.btnStopScan.Enabled = false;
            this.btnStopScan.Location = new System.Drawing.Point(149, 58);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(48, 23);
            this.btnStopScan.TabIndex = 3;
            this.btnStopScan.Text = "Stop";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(29, 59);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(99, 23);
            this.btnStartScan.TabIndex = 2;
            this.btnStartScan.Text = "Start Producing";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // lblStatusScan
            // 
            this.lblStatusScan.AutoSize = true;
            this.lblStatusScan.Location = new System.Drawing.Point(80, 31);
            this.lblStatusScan.Name = "lblStatusScan";
            this.lblStatusScan.Size = new System.Drawing.Size(35, 13);
            this.lblStatusScan.TabIndex = 1;
            this.lblStatusScan.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Location = new System.Drawing.Point(266, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consumers";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lstCity);
            this.groupBox11.Controls.Add(this.btnStopCity);
            this.groupBox11.Controls.Add(this.btnStartCity);
            this.groupBox11.Controls.Add(this.chkCityCont);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.lblCityStatus);
            this.groupBox11.Location = new System.Drawing.Point(19, 262);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(385, 100);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Consumer: CITY GROSS";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Location = new System.Drawing.Point(277, 16);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(102, 69);
            this.lstCity.TabIndex = 8;
            // 
            // btnStopCity
            // 
            this.btnStopCity.Enabled = false;
            this.btnStopCity.Location = new System.Drawing.Point(215, 64);
            this.btnStopCity.Name = "btnStopCity";
            this.btnStopCity.Size = new System.Drawing.Size(40, 23);
            this.btnStopCity.TabIndex = 7;
            this.btnStopCity.Text = "Stop";
            this.btnStopCity.UseVisualStyleBackColor = true;
            this.btnStopCity.Click += new System.EventHandler(this.btnStopCity_Click);
            // 
            // btnStartCity
            // 
            this.btnStartCity.Location = new System.Drawing.Point(128, 64);
            this.btnStartCity.Name = "btnStartCity";
            this.btnStartCity.Size = new System.Drawing.Size(81, 23);
            this.btnStartCity.TabIndex = 6;
            this.btnStartCity.Text = "Start Loading";
            this.btnStartCity.UseVisualStyleBackColor = true;
            this.btnStartCity.Click += new System.EventHandler(this.btnStartCity_Click);
            // 
            // chkCityCont
            // 
            this.chkCityCont.AutoSize = true;
            this.chkCityCont.Location = new System.Drawing.Point(128, 39);
            this.chkCityCont.Name = "chkCityCont";
            this.chkCityCont.Size = new System.Drawing.Size(91, 17);
            this.chkCityCont.TabIndex = 5;
            this.chkCityCont.Text = "Continue load";
            this.chkCityCont.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(120, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Status:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblCityVolume);
            this.groupBox12.Controls.Add(this.lblCityWeight);
            this.groupBox12.Controls.Add(this.lblCityItem);
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Location = new System.Drawing.Point(6, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(107, 75);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Package Limits";
            // 
            // lblCityVolume
            // 
            this.lblCityVolume.AutoSize = true;
            this.lblCityVolume.Location = new System.Drawing.Point(58, 50);
            this.lblCityVolume.Name = "lblCityVolume";
            this.lblCityVolume.Size = new System.Drawing.Size(35, 13);
            this.lblCityVolume.TabIndex = 5;
            this.lblCityVolume.Text = "label8";
            // 
            // lblCityWeight
            // 
            this.lblCityWeight.AutoSize = true;
            this.lblCityWeight.Location = new System.Drawing.Point(58, 35);
            this.lblCityWeight.Name = "lblCityWeight";
            this.lblCityWeight.Size = new System.Drawing.Size(35, 13);
            this.lblCityWeight.TabIndex = 4;
            this.lblCityWeight.Text = "label8";
            // 
            // lblCityItem
            // 
            this.lblCityItem.AutoSize = true;
            this.lblCityItem.Location = new System.Drawing.Point(58, 20);
            this.lblCityItem.Name = "lblCityItem";
            this.lblCityItem.Size = new System.Drawing.Size(35, 13);
            this.lblCityItem.TabIndex = 3;
            this.lblCityItem.Text = "label8";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Volume:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Weight:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Items:";
            // 
            // lblCityStatus
            // 
            this.lblCityStatus.AutoSize = true;
            this.lblCityStatus.Location = new System.Drawing.Point(157, 16);
            this.lblCityStatus.Name = "lblCityStatus";
            this.lblCityStatus.Size = new System.Drawing.Size(113, 13);
            this.lblCityStatus.TabIndex = 3;
            this.lblCityStatus.Text = "Weight Limit REached";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lstCoop);
            this.groupBox9.Controls.Add(this.btnStopCoop);
            this.groupBox9.Controls.Add(this.btnStartCoop);
            this.groupBox9.Controls.Add(this.chkCoopCont);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.lblCoopStatus);
            this.groupBox9.Location = new System.Drawing.Point(19, 139);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(385, 100);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Consumer: COOP";
            // 
            // lstCoop
            // 
            this.lstCoop.FormattingEnabled = true;
            this.lstCoop.Location = new System.Drawing.Point(277, 16);
            this.lstCoop.Name = "lstCoop";
            this.lstCoop.Size = new System.Drawing.Size(102, 69);
            this.lstCoop.TabIndex = 8;
            // 
            // btnStopCoop
            // 
            this.btnStopCoop.Enabled = false;
            this.btnStopCoop.Location = new System.Drawing.Point(215, 64);
            this.btnStopCoop.Name = "btnStopCoop";
            this.btnStopCoop.Size = new System.Drawing.Size(40, 23);
            this.btnStopCoop.TabIndex = 7;
            this.btnStopCoop.Text = "Stop";
            this.btnStopCoop.UseVisualStyleBackColor = true;
            this.btnStopCoop.Click += new System.EventHandler(this.btnStopCoop_Click);
            // 
            // btnStartCoop
            // 
            this.btnStartCoop.Location = new System.Drawing.Point(128, 64);
            this.btnStartCoop.Name = "btnStartCoop";
            this.btnStartCoop.Size = new System.Drawing.Size(81, 23);
            this.btnStartCoop.TabIndex = 6;
            this.btnStartCoop.Text = "Start Loading";
            this.btnStartCoop.UseVisualStyleBackColor = true;
            this.btnStartCoop.Click += new System.EventHandler(this.btnStartCoop_Click);
            // 
            // chkCoopCont
            // 
            this.chkCoopCont.AutoSize = true;
            this.chkCoopCont.Location = new System.Drawing.Point(128, 39);
            this.chkCoopCont.Name = "chkCoopCont";
            this.chkCoopCont.Size = new System.Drawing.Size(91, 17);
            this.chkCoopCont.TabIndex = 5;
            this.chkCoopCont.Text = "Continue load";
            this.chkCoopCont.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblCoopVolume);
            this.groupBox10.Controls.Add(this.lblCoopWeight);
            this.groupBox10.Controls.Add(this.lblCoopItem);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Location = new System.Drawing.Point(6, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(107, 75);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Package Limits";
            // 
            // lblCoopVolume
            // 
            this.lblCoopVolume.AutoSize = true;
            this.lblCoopVolume.Location = new System.Drawing.Point(58, 50);
            this.lblCoopVolume.Name = "lblCoopVolume";
            this.lblCoopVolume.Size = new System.Drawing.Size(35, 13);
            this.lblCoopVolume.TabIndex = 5;
            this.lblCoopVolume.Text = "label8";
            // 
            // lblCoopWeight
            // 
            this.lblCoopWeight.AutoSize = true;
            this.lblCoopWeight.Location = new System.Drawing.Point(58, 35);
            this.lblCoopWeight.Name = "lblCoopWeight";
            this.lblCoopWeight.Size = new System.Drawing.Size(35, 13);
            this.lblCoopWeight.TabIndex = 4;
            this.lblCoopWeight.Text = "label8";
            // 
            // lblCoopItem
            // 
            this.lblCoopItem.AutoSize = true;
            this.lblCoopItem.Location = new System.Drawing.Point(58, 20);
            this.lblCoopItem.Name = "lblCoopItem";
            this.lblCoopItem.Size = new System.Drawing.Size(35, 13);
            this.lblCoopItem.TabIndex = 3;
            this.lblCoopItem.Text = "label8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Volume:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Weight:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Items:";
            // 
            // lblCoopStatus
            // 
            this.lblCoopStatus.AutoSize = true;
            this.lblCoopStatus.Location = new System.Drawing.Point(157, 16);
            this.lblCoopStatus.Name = "lblCoopStatus";
            this.lblCoopStatus.Size = new System.Drawing.Size(113, 13);
            this.lblCoopStatus.TabIndex = 3;
            this.lblCoopStatus.Text = "Weight Limit REached";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lstIca);
            this.groupBox7.Controls.Add(this.btnStopIca);
            this.groupBox7.Controls.Add(this.btnStartIca);
            this.groupBox7.Controls.Add(this.chkIcaCont);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.lblIcaStatus);
            this.groupBox7.Location = new System.Drawing.Point(19, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(385, 100);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Consumer: ICA";
            // 
            // lstIca
            // 
            this.lstIca.FormattingEnabled = true;
            this.lstIca.Location = new System.Drawing.Point(277, 16);
            this.lstIca.Name = "lstIca";
            this.lstIca.Size = new System.Drawing.Size(102, 69);
            this.lstIca.TabIndex = 8;
            // 
            // btnStopIca
            // 
            this.btnStopIca.Enabled = false;
            this.btnStopIca.Location = new System.Drawing.Point(215, 64);
            this.btnStopIca.Name = "btnStopIca";
            this.btnStopIca.Size = new System.Drawing.Size(40, 23);
            this.btnStopIca.TabIndex = 7;
            this.btnStopIca.Text = "Stop";
            this.btnStopIca.UseVisualStyleBackColor = true;
            this.btnStopIca.Click += new System.EventHandler(this.btnStopIca_Click);
            // 
            // btnStartIca
            // 
            this.btnStartIca.Location = new System.Drawing.Point(128, 64);
            this.btnStartIca.Name = "btnStartIca";
            this.btnStartIca.Size = new System.Drawing.Size(81, 23);
            this.btnStartIca.TabIndex = 6;
            this.btnStartIca.Text = "Start Loading";
            this.btnStartIca.UseVisualStyleBackColor = true;
            this.btnStartIca.Click += new System.EventHandler(this.btnStartIca_Click);
            // 
            // chkIcaCont
            // 
            this.chkIcaCont.AutoSize = true;
            this.chkIcaCont.Location = new System.Drawing.Point(128, 39);
            this.chkIcaCont.Name = "chkIcaCont";
            this.chkIcaCont.Size = new System.Drawing.Size(91, 17);
            this.chkIcaCont.TabIndex = 5;
            this.chkIcaCont.Text = "Continue load";
            this.chkIcaCont.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblIcaVolume);
            this.groupBox8.Controls.Add(this.lblIcaWeight);
            this.groupBox8.Controls.Add(this.lblIcaItem);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(107, 75);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Package Limits";
            // 
            // lblIcaVolume
            // 
            this.lblIcaVolume.AutoSize = true;
            this.lblIcaVolume.Location = new System.Drawing.Point(58, 50);
            this.lblIcaVolume.Name = "lblIcaVolume";
            this.lblIcaVolume.Size = new System.Drawing.Size(35, 13);
            this.lblIcaVolume.TabIndex = 5;
            this.lblIcaVolume.Text = "label8";
            // 
            // lblIcaWeight
            // 
            this.lblIcaWeight.AutoSize = true;
            this.lblIcaWeight.Location = new System.Drawing.Point(58, 35);
            this.lblIcaWeight.Name = "lblIcaWeight";
            this.lblIcaWeight.Size = new System.Drawing.Size(35, 13);
            this.lblIcaWeight.TabIndex = 4;
            this.lblIcaWeight.Text = "label8";
            // 
            // lblIcaItem
            // 
            this.lblIcaItem.AutoSize = true;
            this.lblIcaItem.Location = new System.Drawing.Point(58, 20);
            this.lblIcaItem.Name = "lblIcaItem";
            this.lblIcaItem.Size = new System.Drawing.Size(35, 13);
            this.lblIcaItem.TabIndex = 3;
            this.lblIcaItem.Text = "label8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items:";
            // 
            // lblIcaStatus
            // 
            this.lblIcaStatus.AutoSize = true;
            this.lblIcaStatus.Location = new System.Drawing.Point(157, 16);
            this.lblIcaStatus.Name = "lblIcaStatus";
            this.lblIcaStatus.Size = new System.Drawing.Size(113, 13);
            this.lblIcaStatus.TabIndex = 3;
            this.lblIcaStatus.Text = "Weight Limit REached";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressItems);
            this.groupBox3.Controls.Add(this.lblMax);
            this.groupBox3.Location = new System.Drawing.Point(13, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Storage";
            // 
            // progressItems
            // 
            this.progressItems.ForeColor = System.Drawing.Color.Blue;
            this.progressItems.Location = new System.Drawing.Point(155, 37);
            this.progressItems.Maximum = 50;
            this.progressItems.Name = "progressItems";
            this.progressItems.Size = new System.Drawing.Size(490, 23);
            this.progressItems.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressItems.TabIndex = 2;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(6, 42);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(118, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Max kapacity (items):50";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Yu Gothic UI", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(712, 486);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 487);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "/";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

 
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressItems;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnStopAxfood;
        private System.Windows.Forms.Button btnStartAxfood;
        private System.Windows.Forms.Label lblStatusAxfood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnStopArla;
        private System.Windows.Forms.Button btnStartArla;
        private System.Windows.Forms.Label lblStatusArla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Label lblStatusScan;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.Button btnStopCity;
        private System.Windows.Forms.Button btnStartCity;
        private System.Windows.Forms.CheckBox chkCityCont;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lblCityVolume;
        private System.Windows.Forms.Label lblCityWeight;
        private System.Windows.Forms.Label lblCityItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCityStatus;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox lstCoop;
        private System.Windows.Forms.Button btnStopCoop;
        private System.Windows.Forms.Button btnStartCoop;
        private System.Windows.Forms.CheckBox chkCoopCont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblCoopVolume;
        private System.Windows.Forms.Label lblCoopWeight;
        private System.Windows.Forms.Label lblCoopItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCoopStatus;
        private System.Windows.Forms.ListBox lstIca;
        private System.Windows.Forms.Button btnStopIca;
        private System.Windows.Forms.Button btnStartIca;
        private System.Windows.Forms.CheckBox chkIcaCont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblIcaVolume;
        private System.Windows.Forms.Label lblIcaWeight;
        private System.Windows.Forms.Label lblIcaItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIcaStatus;
        private System.Windows.Forms.Button btnStart;
    }
}

