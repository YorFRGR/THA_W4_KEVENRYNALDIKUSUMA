namespace TH_W4_KEVENRYNALDIKUSUMA_0706022210029
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
            this.soccer_tmlst = new System.Windows.Forms.Label();
            this.chs_cntry1 = new System.Windows.Forms.Label();
            this.chs_tm1 = new System.Windows.Forms.Label();
            this.listBox_plyrlist = new System.Windows.Forms.ListBox();
            this.cmbox_Cntry1 = new System.Windows.Forms.ComboBox();
            this.cmbox_tm1 = new System.Windows.Forms.ComboBox();
            this.tm_city = new System.Windows.Forms.Label();
            this.tm_cntry = new System.Windows.Forms.Label();
            this.tm_name = new System.Windows.Forms.Label();
            this.add_tm1 = new System.Windows.Forms.Label();
            this.plyr_name = new System.Windows.Forms.Label();
            this.plyr_pstn = new System.Windows.Forms.Label();
            this.plyr_nmber = new System.Windows.Forms.Label();
            this.adng_plyrs = new System.Windows.Forms.Label();
            this.cmbox_plyr_pstn = new System.Windows.Forms.ComboBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_city = new System.Windows.Forms.TextBox();
            this.txtbox_cntry = new System.Windows.Forms.TextBox();
            this.txtbox_plyr_number = new System.Windows.Forms.TextBox();
            this.txtbox_plyr_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // soccer_tmlst
            // 
            this.soccer_tmlst.AutoSize = true;
            this.soccer_tmlst.Location = new System.Drawing.Point(44, 82);
            this.soccer_tmlst.Name = "soccer_tmlst";
            this.soccer_tmlst.Size = new System.Drawing.Size(90, 13);
            this.soccer_tmlst.TabIndex = 0;
            this.soccer_tmlst.Text = "Soccer Team List";
            // 
            // chs_cntry1
            // 
            this.chs_cntry1.AutoSize = true;
            this.chs_cntry1.Location = new System.Drawing.Point(44, 129);
            this.chs_cntry1.Name = "chs_cntry1";
            this.chs_cntry1.Size = new System.Drawing.Size(85, 13);
            this.chs_cntry1.TabIndex = 1;
            this.chs_cntry1.Text = "Choose Country:";
            // 
            // chs_tm1
            // 
            this.chs_tm1.AutoSize = true;
            this.chs_tm1.Location = new System.Drawing.Point(44, 167);
            this.chs_tm1.Name = "chs_tm1";
            this.chs_tm1.Size = new System.Drawing.Size(76, 13);
            this.chs_tm1.TabIndex = 2;
            this.chs_tm1.Text = "Choose Team:";
            // 
            // listBox_plyrlist
            // 
            this.listBox_plyrlist.FormattingEnabled = true;
            this.listBox_plyrlist.Location = new System.Drawing.Point(48, 246);
            this.listBox_plyrlist.Name = "listBox_plyrlist";
            this.listBox_plyrlist.Size = new System.Drawing.Size(210, 134);
            this.listBox_plyrlist.TabIndex = 3;
            // 
            // cmbox_Cntry1
            // 
            this.cmbox_Cntry1.FormattingEnabled = true;
            this.cmbox_Cntry1.Location = new System.Drawing.Point(166, 129);
            this.cmbox_Cntry1.Name = "cmbox_Cntry1";
            this.cmbox_Cntry1.Size = new System.Drawing.Size(121, 21);
            this.cmbox_Cntry1.TabIndex = 4;
           
            this.cmbox_Cntry1.SelectionChangeCommitted += new System.EventHandler(this.cmbox_Cntry1_SelectionChangeCommitted);
            // 
            // cmbox_tm1
            // 
            this.cmbox_tm1.FormattingEnabled = true;
            this.cmbox_tm1.Location = new System.Drawing.Point(166, 167);
            this.cmbox_tm1.Name = "cmbox_tm1";
            this.cmbox_tm1.Size = new System.Drawing.Size(121, 21);
            this.cmbox_tm1.TabIndex = 5;
            this.cmbox_tm1.SelectionChangeCommitted += new System.EventHandler(this.cmbox_tm1_SelectionChangeCommitted);
            // 
            // tm_city
            // 
            this.tm_city.AutoSize = true;
            this.tm_city.Location = new System.Drawing.Point(335, 220);
            this.tm_city.Name = "tm_city";
            this.tm_city.Size = new System.Drawing.Size(57, 13);
            this.tm_city.TabIndex = 6;
            this.tm_city.Text = "Team City:";
            // 
            // tm_cntry
            // 
            this.tm_cntry.AutoSize = true;
            this.tm_cntry.Location = new System.Drawing.Point(335, 175);
            this.tm_cntry.Name = "tm_cntry";
            this.tm_cntry.Size = new System.Drawing.Size(76, 13);
            this.tm_cntry.TabIndex = 7;
            this.tm_cntry.Text = "Team Country:";
            // 
            // tm_name
            // 
            this.tm_name.AutoSize = true;
            this.tm_name.Location = new System.Drawing.Point(335, 129);
            this.tm_name.Name = "tm_name";
            this.tm_name.Size = new System.Drawing.Size(68, 13);
            this.tm_name.TabIndex = 8;
            this.tm_name.Text = "Team Name:";
            // 
            // add_tm1
            // 
            this.add_tm1.AutoSize = true;
            this.add_tm1.Location = new System.Drawing.Point(436, 82);
            this.add_tm1.Name = "add_tm1";
            this.add_tm1.Size = new System.Drawing.Size(70, 13);
            this.add_tm1.TabIndex = 9;
            this.add_tm1.Text = "Adding Team";
            // 
            // plyr_name
            // 
            this.plyr_name.AutoSize = true;
            this.plyr_name.Location = new System.Drawing.Point(561, 129);
            this.plyr_name.Name = "plyr_name";
            this.plyr_name.Size = new System.Drawing.Size(70, 13);
            this.plyr_name.TabIndex = 10;
            this.plyr_name.Text = "Player Name:";
            // 
            // plyr_pstn
            // 
            this.plyr_pstn.AutoSize = true;
            this.plyr_pstn.Location = new System.Drawing.Point(561, 220);
            this.plyr_pstn.Name = "plyr_pstn";
            this.plyr_pstn.Size = new System.Drawing.Size(79, 13);
            this.plyr_pstn.TabIndex = 11;
            this.plyr_pstn.Text = "Player Position:";
            // 
            // plyr_nmber
            // 
            this.plyr_nmber.AutoSize = true;
            this.plyr_nmber.Location = new System.Drawing.Point(561, 175);
            this.plyr_nmber.Name = "plyr_nmber";
            this.plyr_nmber.Size = new System.Drawing.Size(79, 13);
            this.plyr_nmber.TabIndex = 12;
            this.plyr_nmber.Text = "Player Number:";
            // 
            // adng_plyrs
            // 
            this.adng_plyrs.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.adng_plyrs.AutoSize = true;
            this.adng_plyrs.Location = new System.Drawing.Point(650, 82);
            this.adng_plyrs.Name = "adng_plyrs";
            this.adng_plyrs.Size = new System.Drawing.Size(77, 13);
            this.adng_plyrs.TabIndex = 13;
            this.adng_plyrs.Text = "Adding Players";
            // 
            // cmbox_plyr_pstn
            // 
            this.cmbox_plyr_pstn.FormattingEnabled = true;
            this.cmbox_plyr_pstn.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cmbox_plyr_pstn.Location = new System.Drawing.Point(652, 217);
            this.cmbox_plyr_pstn.Name = "cmbox_plyr_pstn";
            this.cmbox_plyr_pstn.Size = new System.Drawing.Size(121, 21);
            this.cmbox_plyr_pstn.TabIndex = 14;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(47, 395);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(439, 262);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.Location = new System.Drawing.Point(652, 262);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(75, 23);
            this.btn_add2.TabIndex = 17;
            this.btn_add2.Text = "Add";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(439, 129);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Name.TabIndex = 18;
            // 
            // txtbox_city
            // 
            this.txtbox_city.Location = new System.Drawing.Point(439, 218);
            this.txtbox_city.Name = "txtbox_city";
            this.txtbox_city.Size = new System.Drawing.Size(100, 20);
            this.txtbox_city.TabIndex = 19;
            // 
            // txtbox_cntry
            // 
            this.txtbox_cntry.Location = new System.Drawing.Point(439, 175);
            this.txtbox_cntry.Name = "txtbox_cntry";
            this.txtbox_cntry.Size = new System.Drawing.Size(100, 20);
            this.txtbox_cntry.TabIndex = 20;
            // 
            // txtbox_plyr_number
            // 
            this.txtbox_plyr_number.Location = new System.Drawing.Point(652, 172);
            this.txtbox_plyr_number.Name = "txtbox_plyr_number";
            this.txtbox_plyr_number.Size = new System.Drawing.Size(121, 20);
            this.txtbox_plyr_number.TabIndex = 21;
            // 
            // txtbox_plyr_name
            // 
            this.txtbox_plyr_name.Location = new System.Drawing.Point(652, 130);
            this.txtbox_plyr_name.Name = "txtbox_plyr_name";
            this.txtbox_plyr_name.Size = new System.Drawing.Size(121, 20);
            this.txtbox_plyr_name.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_plyr_name);
            this.Controls.Add(this.txtbox_plyr_number);
            this.Controls.Add(this.txtbox_cntry);
            this.Controls.Add(this.txtbox_city);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.cmbox_plyr_pstn);
            this.Controls.Add(this.adng_plyrs);
            this.Controls.Add(this.plyr_nmber);
            this.Controls.Add(this.plyr_pstn);
            this.Controls.Add(this.plyr_name);
            this.Controls.Add(this.add_tm1);
            this.Controls.Add(this.tm_name);
            this.Controls.Add(this.tm_cntry);
            this.Controls.Add(this.tm_city);
            this.Controls.Add(this.cmbox_tm1);
            this.Controls.Add(this.cmbox_Cntry1);
            this.Controls.Add(this.listBox_plyrlist);
            this.Controls.Add(this.chs_tm1);
            this.Controls.Add(this.chs_cntry1);
            this.Controls.Add(this.soccer_tmlst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soccer_tmlst;
        private System.Windows.Forms.Label chs_cntry1;
        private System.Windows.Forms.Label chs_tm1;
        private System.Windows.Forms.ListBox listBox_plyrlist;
        private System.Windows.Forms.ComboBox cmbox_Cntry1;
        private System.Windows.Forms.ComboBox cmbox_tm1;
        private System.Windows.Forms.Label tm_city;
        private System.Windows.Forms.Label tm_cntry;
        private System.Windows.Forms.Label tm_name;
        private System.Windows.Forms.Label add_tm1;
        private System.Windows.Forms.Label plyr_name;
        private System.Windows.Forms.Label plyr_pstn;
        private System.Windows.Forms.Label plyr_nmber;
        private System.Windows.Forms.Label adng_plyrs;
        private System.Windows.Forms.ComboBox cmbox_plyr_pstn;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_city;
        private System.Windows.Forms.TextBox txtbox_cntry;
        private System.Windows.Forms.TextBox txtbox_plyr_number;
        private System.Windows.Forms.TextBox txtbox_plyr_name;
    }
}

