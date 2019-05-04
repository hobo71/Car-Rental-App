﻿using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.UserControls
{
    partial class CarsPageUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsPageUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.refreshDataGrid = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.addNewCarsButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.deleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.seachFilterDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carsDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exportToExelButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.carImagePictureBox = new System.Windows.Forms.PictureBox();
            this.carNameLabel = new System.Windows.Forms.Label();
            this.carDescriptionLabel = new System.Windows.Forms.Label();
            this.carStatus = new System.Windows.Forms.Label();
            this.carClassificationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewCarsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carImagePictureBox)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1044, 24);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 104);
            this.panel1.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(180, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Manage your Cars";
            // 
            // refreshDataGrid
            // 
            this.refreshDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshDataGrid.Image = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.Image")));
            this.refreshDataGrid.ImageActive = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.ImageActive")));
            this.refreshDataGrid.Location = new System.Drawing.Point(571, 57);
            this.refreshDataGrid.Name = "refreshDataGrid";
            this.refreshDataGrid.Size = new System.Drawing.Size(32, 32);
            this.refreshDataGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshDataGrid.TabIndex = 4;
            this.refreshDataGrid.TabStop = false;
            this.refreshDataGrid.Zoom = 10;
            this.refreshDataGrid.Click += new System.EventHandler(this.RefreshDataGrid_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("searchButton.ImageActive")));
            this.searchButton.Location = new System.Drawing.Point(179, 60);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 4;
            this.searchButton.TabStop = false;
            this.searchButton.Zoom = 10;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // addNewCarsButton
            // 
            this.addNewCarsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewCarsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewCarsButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewCarsButton.Image")));
            this.addNewCarsButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("addNewCarsButton.ImageActive")));
            this.addNewCarsButton.Location = new System.Drawing.Point(485, 57);
            this.addNewCarsButton.Name = "addNewCarsButton";
            this.addNewCarsButton.Size = new System.Drawing.Size(32, 32);
            this.addNewCarsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addNewCarsButton.TabIndex = 4;
            this.addNewCarsButton.TabStop = false;
            this.addNewCarsButton.Zoom = 10;
            this.addNewCarsButton.Click += new System.EventHandler(this.AddNewCarsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageActive")));
            this.deleteButton.Location = new System.Drawing.Point(533, 57);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(32, 32);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteButton.TabIndex = 4;
            this.deleteButton.TabStop = false;
            this.deleteButton.Zoom = 10;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderColorFocused = System.Drawing.Color.Crimson;
            this.searchTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.BorderColorMouseHover = System.Drawing.Color.IndianRed;
            this.searchTextBox.BorderThickness = 3;
            this.searchTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.isPassword = false;
            this.searchTextBox.Location = new System.Drawing.Point(4, 57);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.MaxLength = 32;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 35);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Enter a keyword";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // seachFilterDropdown
            // 
            this.seachFilterDropdown.BackColor = System.Drawing.Color.Transparent;
            this.seachFilterDropdown.BorderRadius = 3;
            this.seachFilterDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.seachFilterDropdown.ForeColor = System.Drawing.Color.White;
            this.seachFilterDropdown.items = new string[] {
        "Name",
        "License Plate",
        "Price Per Day",
        "Description",
        "All"};
            this.seachFilterDropdown.Location = new System.Drawing.Point(217, 57);
            this.seachFilterDropdown.Name = "seachFilterDropdown";
            this.seachFilterDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.seachFilterDropdown.onHoverColor = System.Drawing.Color.Maroon;
            this.seachFilterDropdown.selectedIndex = 4;
            this.seachFilterDropdown.Size = new System.Drawing.Size(165, 35);
            this.seachFilterDropdown.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.carsDataGridView);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.addNewCarsButton);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.seachFilterDropdown);
            this.panel2.Controls.Add(this.refreshDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(423, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 577);
            this.panel2.TabIndex = 8;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.carsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.carsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.carsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.classificationDataGridViewTextBoxColumn});
            this.carsDataGridView.DataSource = this.carsBindingSource;
            this.carsDataGridView.DoubleBuffered = true;
            this.carsDataGridView.EnableHeadersVisualStyles = false;
            this.carsDataGridView.HeaderBgColor = System.Drawing.SystemColors.GrayText;
            this.carsDataGridView.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carsDataGridView.Location = new System.Drawing.Point(3, 104);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.carsDataGridView.RowHeadersWidth = 60;
            this.carsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsDataGridView.Size = new System.Drawing.Size(615, 367);
            this.carsDataGridView.TabIndex = 16;
            this.carsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CarsDataGridView_CellFormatting);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuCircleProgressbar1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.printButton);
            this.panel3.Controls.Add(this.exportToExelButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 100);
            this.panel3.TabIndex = 5;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(310, 9);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Crimson;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(82, 82);
            this.bunifuCircleProgressbar1.TabIndex = 18;
            this.bunifuCircleProgressbar1.Value = 43;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(237, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "29";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total Availables : ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(237, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "38";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Rented";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(237, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "67";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total numers of Cars : ";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("printButton.ImageActive")));
            this.printButton.Location = new System.Drawing.Point(570, 9);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(32, 32);
            this.printButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printButton.TabIndex = 10;
            this.printButton.TabStop = false;
            this.printButton.Zoom = 10;
            // 
            // exportToExelButton
            // 
            this.exportToExelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportToExelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportToExelButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.Image")));
            this.exportToExelButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.ImageActive")));
            this.exportToExelButton.Location = new System.Drawing.Point(502, 9);
            this.exportToExelButton.Name = "exportToExelButton";
            this.exportToExelButton.Size = new System.Drawing.Size(32, 32);
            this.exportToExelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exportToExelButton.TabIndex = 11;
            this.exportToExelButton.TabStop = false;
            this.exportToExelButton.Zoom = 10;
            // 
            // carImagePictureBox
            // 
            this.carImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carImagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carImagePictureBox.BackgroundImage")));
            this.carImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.carImagePictureBox.Location = new System.Drawing.Point(54, 3);
            this.carImagePictureBox.Name = "carImagePictureBox";
            this.carImagePictureBox.Size = new System.Drawing.Size(291, 200);
            this.carImagePictureBox.TabIndex = 1;
            this.carImagePictureBox.TabStop = false;
            // 
            // carNameLabel
            // 
            this.carNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carNameLabel.AutoSize = true;
            this.carNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameLabel.Location = new System.Drawing.Point(97, 230);
            this.carNameLabel.Name = "carNameLabel";
            this.carNameLabel.Size = new System.Drawing.Size(205, 25);
            this.carNameLabel.TabIndex = 2;
            this.carNameLabel.Text = "JEEP WRANGLER";
            // 
            // carDescriptionLabel
            // 
            this.carDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carDescriptionLabel.AutoSize = true;
            this.carDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carDescriptionLabel.Location = new System.Drawing.Point(25, 268);
            this.carDescriptionLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.carDescriptionLabel.Name = "carDescriptionLabel";
            this.carDescriptionLabel.Size = new System.Drawing.Size(373, 15);
            this.carDescriptionLabel.TabIndex = 2;
            this.carDescriptionLabel.Text = "This jeep holds 4 passengers, as well as 2 medium-sized suitcases";
            this.carDescriptionLabel.UseMnemonic = false;
            // 
            // carStatus
            // 
            this.carStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carStatus.AutoSize = true;
            this.carStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carStatus.ForeColor = System.Drawing.Color.Green;
            this.carStatus.Location = new System.Drawing.Point(253, 206);
            this.carStatus.Name = "carStatus";
            this.carStatus.Size = new System.Drawing.Size(90, 24);
            this.carStatus.TabIndex = 2;
            this.carStatus.Text = "Availabe";
            // 
            // carClassificationLabel
            // 
            this.carClassificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carClassificationLabel.AutoSize = true;
            this.carClassificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carClassificationLabel.Location = new System.Drawing.Point(147, 314);
            this.carClassificationLabel.Name = "carClassificationLabel";
            this.carClassificationLabel.Size = new System.Drawing.Size(79, 20);
            this.carClassificationLabel.TabIndex = 3;
            this.carClassificationLabel.Text = "Model  S";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total of Rents";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Magenta;
            this.label7.Location = new System.Drawing.Point(230, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "43";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.SystemColors.Control;
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.carClassificationLabel);
            this.bunifuCards1.Controls.Add(this.carStatus);
            this.bunifuCards1.Controls.Add(this.carDescriptionLabel);
            this.bunifuCards1.Controls.Add(this.carNameLabel);
            this.bunifuCards1.Controls.Add(this.carImagePictureBox);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 110);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(417, 568);
            this.bunifuCards1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "$600/week, $100/day";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Car);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "License Plate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            // 
            // pricePerDayDataGridViewTextBoxColumn
            // 
            this.pricePerDayDataGridViewTextBoxColumn.DataPropertyName = "PricePerDay";
            dataGridViewCellStyle3.Format = "0,0.00 MAD";
            dataGridViewCellStyle3.NullValue = null;
            this.pricePerDayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Price Per Day";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            // 
            // CarsPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarsPageUserControl";
            this.Size = new System.Drawing.Size(1044, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewCarsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carImagePictureBox)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuSeparator bunifuSeparator1;
        private Panel panel1;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuImageButton refreshDataGrid;
        private BunifuImageButton searchButton;
        private BunifuImageButton addNewCarsButton;
        private BunifuImageButton deleteButton;
        private BunifuMetroTextbox searchTextBox;
        private BunifuDropdown seachFilterDropdown;
        private Panel panel2;
        private PictureBox carImagePictureBox;
        private Label carNameLabel;
        private Label carDescriptionLabel;
        private Label carStatus;
        private Label carClassificationLabel;
        private Label label6;
        private Label label7;
        private BunifuCards bunifuCards1;
        private Panel panel3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private BunifuImageButton printButton;
        private BunifuImageButton exportToExelButton;
        private BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Label label1;
        private BindingSource carsBindingSource;
        private BunifuCustomDataGrid carsDataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
    }
}
