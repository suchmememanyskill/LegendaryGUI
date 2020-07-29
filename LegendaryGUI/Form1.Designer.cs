﻿namespace LegendaryGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_home = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Installed = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_notInstalled = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_allgames = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_forceLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.pnl_installed = new System.Windows.Forms.Panel();
            this.btn_installed_launch = new System.Windows.Forms.Button();
            this.installed_lv = new System.Windows.Forms.ListView();
            this.Col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_home = new System.Windows.Forms.Panel();
            this.btn_home_verInfo = new System.Windows.Forms.Button();
            this.pnl_forceLaunch = new System.Windows.Forms.Panel();
            this.btn_forceLaunch_launch = new System.Windows.Forms.Button();
            this.btn_forceLaunch_remove = new System.Windows.Forms.Button();
            this.lbl_forceLaunch_status = new System.Windows.Forms.Label();
            this.btn_forceLaunch_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.tb_appname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lv_forceLaunch = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_notInstalled = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_allgames = new System.Windows.Forms.Panel();
            this.lv_allGames = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.pnl_installed.SuspendLayout();
            this.pnl_home.SuspendLayout();
            this.pnl_forceLaunch.SuspendLayout();
            this.pnl_notInstalled.SuspendLayout();
            this.pnl_allgames.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_home,
            this.mi_Installed,
            this.mi_notInstalled,
            this.mi_allgames,
            this.mi_forceLaunch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(114, 670);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "ms_main";
            // 
            // mi_home
            // 
            this.mi_home.BackColor = System.Drawing.SystemColors.Highlight;
            this.mi_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mi_home.ForeColor = System.Drawing.Color.White;
            this.mi_home.Name = "mi_home";
            this.mi_home.Size = new System.Drawing.Size(107, 25);
            this.mi_home.Text = "Home";
            this.mi_home.Click += new System.EventHandler(this.mi_home_Click);
            // 
            // mi_Installed
            // 
            this.mi_Installed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mi_Installed.ForeColor = System.Drawing.Color.White;
            this.mi_Installed.Name = "mi_Installed";
            this.mi_Installed.Size = new System.Drawing.Size(107, 25);
            this.mi_Installed.Text = "Installed";
            this.mi_Installed.Click += new System.EventHandler(this.mi_Installed_Click);
            // 
            // mi_notInstalled
            // 
            this.mi_notInstalled.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mi_notInstalled.ForeColor = System.Drawing.Color.White;
            this.mi_notInstalled.Name = "mi_notInstalled";
            this.mi_notInstalled.Size = new System.Drawing.Size(107, 25);
            this.mi_notInstalled.Text = "Not installed";
            this.mi_notInstalled.Click += new System.EventHandler(this.mi_notInstalled_Click);
            // 
            // mi_allgames
            // 
            this.mi_allgames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mi_allgames.ForeColor = System.Drawing.Color.White;
            this.mi_allgames.Name = "mi_allgames";
            this.mi_allgames.Size = new System.Drawing.Size(107, 25);
            this.mi_allgames.Text = "All games";
            this.mi_allgames.Click += new System.EventHandler(this.mi_allgames_Click);
            // 
            // mi_forceLaunch
            // 
            this.mi_forceLaunch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mi_forceLaunch.ForeColor = System.Drawing.Color.White;
            this.mi_forceLaunch.Name = "mi_forceLaunch";
            this.mi_forceLaunch.Size = new System.Drawing.Size(107, 25);
            this.mi_forceLaunch.Text = "Force Launch";
            this.mi_forceLaunch.Visible = false;
            this.mi_forceLaunch.Click += new System.EventHandler(this.mi_forceLaunch_Click);
            // 
            // rtb_console
            // 
            this.rtb_console.BackColor = System.Drawing.Color.Black;
            this.rtb_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_console.ForeColor = System.Drawing.Color.White;
            this.rtb_console.Location = new System.Drawing.Point(0, 518);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(970, 152);
            this.rtb_console.TabIndex = 1;
            this.rtb_console.Text = "";
            this.rtb_console.TextChanged += new System.EventHandler(this.rtb_console_TextChanged);
            // 
            // pnl_installed
            // 
            this.pnl_installed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_installed.Controls.Add(this.btn_installed_launch);
            this.pnl_installed.Controls.Add(this.installed_lv);
            this.pnl_installed.Location = new System.Drawing.Point(113, 0);
            this.pnl_installed.Name = "pnl_installed";
            this.pnl_installed.Size = new System.Drawing.Size(858, 520);
            this.pnl_installed.TabIndex = 2;
            // 
            // btn_installed_launch
            // 
            this.btn_installed_launch.BackColor = System.Drawing.Color.White;
            this.btn_installed_launch.Enabled = false;
            this.btn_installed_launch.FlatAppearance.BorderSize = 2;
            this.btn_installed_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_installed_launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_installed_launch.ForeColor = System.Drawing.Color.Blue;
            this.btn_installed_launch.Location = new System.Drawing.Point(753, 12);
            this.btn_installed_launch.Name = "btn_installed_launch";
            this.btn_installed_launch.Size = new System.Drawing.Size(92, 33);
            this.btn_installed_launch.TabIndex = 1;
            this.btn_installed_launch.Text = " Launch";
            this.btn_installed_launch.UseVisualStyleBackColor = false;
            this.btn_installed_launch.Click += new System.EventHandler(this.btn_installed_launch_Click);
            // 
            // installed_lv
            // 
            this.installed_lv.BackColor = System.Drawing.Color.DimGray;
            this.installed_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4});
            this.installed_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installed_lv.ForeColor = System.Drawing.Color.White;
            this.installed_lv.FullRowSelect = true;
            this.installed_lv.HideSelection = false;
            this.installed_lv.Location = new System.Drawing.Point(0, 54);
            this.installed_lv.MultiSelect = false;
            this.installed_lv.Name = "installed_lv";
            this.installed_lv.Size = new System.Drawing.Size(855, 463);
            this.installed_lv.TabIndex = 0;
            this.installed_lv.UseCompatibleStateImageBehavior = false;
            this.installed_lv.View = System.Windows.Forms.View.Details;
            this.installed_lv.SelectedIndexChanged += new System.EventHandler(this.installed_lv_SelectedIndexChanged);
            // 
            // Col1
            // 
            this.Col1.Text = "Name";
            this.Col1.Width = 270;
            // 
            // Col2
            // 
            this.Col2.Text = "AppName";
            this.Col2.Width = 150;
            // 
            // Col3
            // 
            this.Col3.Text = "Version";
            this.Col3.Width = 270;
            // 
            // Col4
            // 
            this.Col4.Text = "Size";
            this.Col4.Width = 140;
            // 
            // pnl_home
            // 
            this.pnl_home.BackColor = System.Drawing.Color.DimGray;
            this.pnl_home.Controls.Add(this.btn_home_verInfo);
            this.pnl_home.Location = new System.Drawing.Point(113, 0);
            this.pnl_home.Name = "pnl_home";
            this.pnl_home.Size = new System.Drawing.Size(858, 520);
            this.pnl_home.TabIndex = 3;
            // 
            // btn_home_verInfo
            // 
            this.btn_home_verInfo.BackColor = System.Drawing.Color.White;
            this.btn_home_verInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home_verInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home_verInfo.Location = new System.Drawing.Point(4, 3);
            this.btn_home_verInfo.Name = "btn_home_verInfo";
            this.btn_home_verInfo.Size = new System.Drawing.Size(121, 31);
            this.btn_home_verInfo.TabIndex = 0;
            this.btn_home_verInfo.Text = "Version info";
            this.btn_home_verInfo.UseVisualStyleBackColor = false;
            this.btn_home_verInfo.Click += new System.EventHandler(this.btn_home_verInfo_Click);
            // 
            // pnl_forceLaunch
            // 
            this.pnl_forceLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_forceLaunch.Controls.Add(this.btn_forceLaunch_launch);
            this.pnl_forceLaunch.Controls.Add(this.btn_forceLaunch_remove);
            this.pnl_forceLaunch.Controls.Add(this.lbl_forceLaunch_status);
            this.pnl_forceLaunch.Controls.Add(this.btn_forceLaunch_Add);
            this.pnl_forceLaunch.Controls.Add(this.label5);
            this.pnl_forceLaunch.Controls.Add(this.label4);
            this.pnl_forceLaunch.Controls.Add(this.label3);
            this.pnl_forceLaunch.Controls.Add(this.label2);
            this.pnl_forceLaunch.Controls.Add(this.tb_path);
            this.pnl_forceLaunch.Controls.Add(this.tb_size);
            this.pnl_forceLaunch.Controls.Add(this.tb_version);
            this.pnl_forceLaunch.Controls.Add(this.tb_appname);
            this.pnl_forceLaunch.Controls.Add(this.label1);
            this.pnl_forceLaunch.Controls.Add(this.tb_name);
            this.pnl_forceLaunch.Controls.Add(this.lv_forceLaunch);
            this.pnl_forceLaunch.Location = new System.Drawing.Point(113, 0);
            this.pnl_forceLaunch.Name = "pnl_forceLaunch";
            this.pnl_forceLaunch.Size = new System.Drawing.Size(858, 520);
            this.pnl_forceLaunch.TabIndex = 4;
            // 
            // btn_forceLaunch_launch
            // 
            this.btn_forceLaunch_launch.BackColor = System.Drawing.Color.White;
            this.btn_forceLaunch_launch.FlatAppearance.BorderSize = 2;
            this.btn_forceLaunch_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forceLaunch_launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forceLaunch_launch.ForeColor = System.Drawing.Color.Blue;
            this.btn_forceLaunch_launch.Location = new System.Drawing.Point(741, 9);
            this.btn_forceLaunch_launch.Name = "btn_forceLaunch_launch";
            this.btn_forceLaunch_launch.Size = new System.Drawing.Size(104, 50);
            this.btn_forceLaunch_launch.TabIndex = 15;
            this.btn_forceLaunch_launch.Text = "Launch";
            this.btn_forceLaunch_launch.UseVisualStyleBackColor = false;
            this.btn_forceLaunch_launch.Click += new System.EventHandler(this.btn_forceLaunch_launch_Click);
            // 
            // btn_forceLaunch_remove
            // 
            this.btn_forceLaunch_remove.BackColor = System.Drawing.Color.White;
            this.btn_forceLaunch_remove.FlatAppearance.BorderSize = 2;
            this.btn_forceLaunch_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forceLaunch_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forceLaunch_remove.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_forceLaunch_remove.Location = new System.Drawing.Point(741, 96);
            this.btn_forceLaunch_remove.Name = "btn_forceLaunch_remove";
            this.btn_forceLaunch_remove.Size = new System.Drawing.Size(104, 50);
            this.btn_forceLaunch_remove.TabIndex = 14;
            this.btn_forceLaunch_remove.Text = "Remove";
            this.btn_forceLaunch_remove.UseVisualStyleBackColor = false;
            this.btn_forceLaunch_remove.Click += new System.EventHandler(this.btn_forceLaunch_remove_Click);
            // 
            // lbl_forceLaunch_status
            // 
            this.lbl_forceLaunch_status.AutoSize = true;
            this.lbl_forceLaunch_status.ForeColor = System.Drawing.Color.White;
            this.lbl_forceLaunch_status.Location = new System.Drawing.Point(324, 77);
            this.lbl_forceLaunch_status.Name = "lbl_forceLaunch_status";
            this.lbl_forceLaunch_status.Size = new System.Drawing.Size(49, 13);
            this.lbl_forceLaunch_status.TabIndex = 13;
            this.lbl_forceLaunch_status.Text = "Status: ?";
            // 
            // btn_forceLaunch_Add
            // 
            this.btn_forceLaunch_Add.BackColor = System.Drawing.Color.White;
            this.btn_forceLaunch_Add.FlatAppearance.BorderSize = 2;
            this.btn_forceLaunch_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forceLaunch_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forceLaunch_Add.ForeColor = System.Drawing.Color.Green;
            this.btn_forceLaunch_Add.Location = new System.Drawing.Point(324, 93);
            this.btn_forceLaunch_Add.Name = "btn_forceLaunch_Add";
            this.btn_forceLaunch_Add.Size = new System.Drawing.Size(104, 50);
            this.btn_forceLaunch_Add.TabIndex = 12;
            this.btn_forceLaunch_Add.Text = "Add Game";
            this.btn_forceLaunch_Add.UseVisualStyleBackColor = false;
            this.btn_forceLaunch_Add.Click += new System.EventHandler(this.btn_forceLaunch_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "AppName:";
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.Location = new System.Drawing.Point(119, 121);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(199, 22);
            this.tb_path.TabIndex = 7;
            // 
            // tb_size
            // 
            this.tb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_size.Location = new System.Drawing.Point(119, 93);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(199, 22);
            this.tb_size.TabIndex = 6;
            // 
            // tb_version
            // 
            this.tb_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_version.Location = new System.Drawing.Point(119, 65);
            this.tb_version.Name = "tb_version";
            this.tb_version.Size = new System.Drawing.Size(199, 22);
            this.tb_version.TabIndex = 5;
            // 
            // tb_appname
            // 
            this.tb_appname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_appname.Location = new System.Drawing.Point(119, 37);
            this.tb_appname.Name = "tb_appname";
            this.tb_appname.Size = new System.Drawing.Size(199, 22);
            this.tb_appname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(119, 8);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(199, 22);
            this.tb_name.TabIndex = 2;
            // 
            // lv_forceLaunch
            // 
            this.lv_forceLaunch.BackColor = System.Drawing.Color.DimGray;
            this.lv_forceLaunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lv_forceLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_forceLaunch.ForeColor = System.Drawing.Color.White;
            this.lv_forceLaunch.FullRowSelect = true;
            this.lv_forceLaunch.HideSelection = false;
            this.lv_forceLaunch.Location = new System.Drawing.Point(0, 148);
            this.lv_forceLaunch.MultiSelect = false;
            this.lv_forceLaunch.Name = "lv_forceLaunch";
            this.lv_forceLaunch.Size = new System.Drawing.Size(855, 372);
            this.lv_forceLaunch.TabIndex = 1;
            this.lv_forceLaunch.UseCompatibleStateImageBehavior = false;
            this.lv_forceLaunch.View = System.Windows.Forms.View.Details;
            this.lv_forceLaunch.SelectedIndexChanged += new System.EventHandler(this.lv_forceLaunch_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 213;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "AppName";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Version";
            this.columnHeader11.Width = 156;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Size";
            this.columnHeader12.Width = 140;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Path";
            this.columnHeader13.Width = 187;
            // 
            // pnl_notInstalled
            // 
            this.pnl_notInstalled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_notInstalled.Controls.Add(this.listView1);
            this.pnl_notInstalled.Location = new System.Drawing.Point(113, 0);
            this.pnl_notInstalled.Name = "pnl_notInstalled";
            this.pnl_notInstalled.Size = new System.Drawing.Size(858, 520);
            this.pnl_notInstalled.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 54);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(855, 463);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AppName";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            this.columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 140;
            // 
            // pnl_allgames
            // 
            this.pnl_allgames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_allgames.Controls.Add(this.lv_allGames);
            this.pnl_allgames.Location = new System.Drawing.Point(113, 0);
            this.pnl_allgames.Name = "pnl_allgames";
            this.pnl_allgames.Size = new System.Drawing.Size(858, 520);
            this.pnl_allgames.TabIndex = 4;
            // 
            // lv_allGames
            // 
            this.lv_allGames.BackColor = System.Drawing.Color.DimGray;
            this.lv_allGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_allGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_allGames.ForeColor = System.Drawing.Color.White;
            this.lv_allGames.FullRowSelect = true;
            this.lv_allGames.HideSelection = false;
            this.lv_allGames.Location = new System.Drawing.Point(0, 0);
            this.lv_allGames.MultiSelect = false;
            this.lv_allGames.Name = "lv_allGames";
            this.lv_allGames.Size = new System.Drawing.Size(855, 520);
            this.lv_allGames.TabIndex = 0;
            this.lv_allGames.UseCompatibleStateImageBehavior = false;
            this.lv_allGames.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 270;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "AppName";
            this.columnHeader6.Width = 285;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Version";
            this.columnHeader7.Width = 270;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(964, 670);
            this.Controls.Add(this.pnl_forceLaunch);
            this.Controls.Add(this.pnl_allgames);
            this.Controls.Add(this.pnl_notInstalled);
            this.Controls.Add(this.rtb_console);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_home);
            this.Controls.Add(this.pnl_installed);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LegendaryGUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_installed.ResumeLayout(false);
            this.pnl_home.ResumeLayout(false);
            this.pnl_forceLaunch.ResumeLayout(false);
            this.pnl_forceLaunch.PerformLayout();
            this.pnl_notInstalled.ResumeLayout(false);
            this.pnl_allgames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_home;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.ToolStripMenuItem mi_Installed;
        private System.Windows.Forms.Panel pnl_installed;
        private System.Windows.Forms.ListView installed_lv;
        private System.Windows.Forms.ColumnHeader Col1;
        private System.Windows.Forms.ColumnHeader Col2;
        private System.Windows.Forms.ColumnHeader Col3;
        private System.Windows.Forms.ColumnHeader Col4;
        private System.Windows.Forms.Button btn_installed_launch;
        private System.Windows.Forms.ToolStripMenuItem mi_forceLaunch;
        private System.Windows.Forms.Panel pnl_home;
        private System.Windows.Forms.Button btn_home_verInfo;
        private System.Windows.Forms.Panel pnl_forceLaunch;
        private System.Windows.Forms.Panel pnl_notInstalled;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pnl_allgames;
        private System.Windows.Forms.ListView lv_allGames;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem mi_notInstalled;
        private System.Windows.Forms.ToolStripMenuItem mi_allgames;
        private System.Windows.Forms.ListView lv_forceLaunch;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btn_forceLaunch_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.TextBox tb_appname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_forceLaunch_status;
        private System.Windows.Forms.Button btn_forceLaunch_launch;
        private System.Windows.Forms.Button btn_forceLaunch_remove;
    }
}
