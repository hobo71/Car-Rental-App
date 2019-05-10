﻿using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalApp.View.UserControls
{
    partial class UsersPageUserControl
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


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPageUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.refreshDataGridViewButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.searchButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteUserButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addUserButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.usersCountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.administratorUserCountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.mangerUserCountLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Controls.Add(this.kryptonHeader1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.kryptonLabel3);
            this.panel4.Controls.Add(this.kryptonLabel2);
            this.panel4.Controls.Add(this.kryptonLabel1);
            this.panel4.Controls.Add(this.mangerUserCountLabel);
            this.panel4.Controls.Add(this.usersCountLabel);
            this.panel4.Controls.Add(this.administratorUserCountLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(614, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 581);
            this.panel4.TabIndex = 1;
            // 
            // refreshDataGridViewButton
            // 
            this.refreshDataGridViewButton.Location = new System.Drawing.Point(540, 26);
            this.refreshDataGridViewButton.Name = "refreshDataGridViewButton";
            this.refreshDataGridViewButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.refreshDataGridViewButton.Size = new System.Drawing.Size(57, 25);
            this.refreshDataGridViewButton.TabIndex = 0;
            this.refreshDataGridViewButton.Values.Text = "refresh";
            this.refreshDataGridViewButton.Click += new System.EventHandler(this.RefreshDataGrid_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 581);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.userDataGridView);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 581);
            this.panel3.TabIndex = 1;
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownWidth = 121;
            this.searchComboBox.Location = new System.Drawing.Point(262, 28);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 3;
            this.searchComboBox.Text = "All";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(166, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.searchButton.Size = new System.Drawing.Size(90, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Values.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.searchTextBox.Size = new System.Drawing.Size(148, 23);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Enter a Keyword";
            this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // userDataGridView
            // 
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.cinDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.userDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner;
            this.userDataGridView.Location = new System.Drawing.Point(12, 67);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(585, 427);
            this.userDataGridView.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchComboBox);
            this.panel5.Controls.Add(this.refreshDataGridViewButton);
            this.panel5.Controls.Add(this.searchButton);
            this.panel5.Controls.Add(this.deleteUserButton);
            this.panel5.Controls.Add(this.searchTextBox);
            this.panel5.Controls.Add(this.addUserButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(608, 61);
            this.panel5.TabIndex = 4;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(477, 26);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.deleteUserButton.Size = new System.Drawing.Size(57, 25);
            this.deleteUserButton.TabIndex = 0;
            this.deleteUserButton.Values.Text = "delete";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(414, 26);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addUserButton.Size = new System.Drawing.Size(57, 25);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Values.Text = "add";
            // 
            // usersCountLabel
            // 
            this.usersCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usersCountLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.usersCountLabel.Location = new System.Drawing.Point(231, 474);
            this.usersCountLabel.Name = "usersCountLabel";
            this.usersCountLabel.Size = new System.Drawing.Size(18, 20);
            this.usersCountLabel.TabIndex = 0;
            this.usersCountLabel.Values.Text = "9";
            // 
            // administratorUserCountLabel
            // 
            this.administratorUserCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.administratorUserCountLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.administratorUserCountLabel.Location = new System.Drawing.Point(231, 500);
            this.administratorUserCountLabel.Name = "administratorUserCountLabel";
            this.administratorUserCountLabel.Size = new System.Drawing.Size(18, 20);
            this.administratorUserCountLabel.TabIndex = 0;
            this.administratorUserCountLabel.Values.Text = "2";
            // 
            // mangerUserCountLabel
            // 
            this.mangerUserCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mangerUserCountLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.mangerUserCountLabel.Location = new System.Drawing.Point(231, 526);
            this.mangerUserCountLabel.Name = "mangerUserCountLabel";
            this.mangerUserCountLabel.Size = new System.Drawing.Size(18, 20);
            this.mangerUserCountLabel.TabIndex = 0;
            this.mangerUserCountLabel.Values.Text = "7";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel1.Location = new System.Drawing.Point(25, 474);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(130, 20);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Total number of users ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel2.Location = new System.Drawing.Point(25, 500);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(180, 20);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Total number of administrators";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel3.Location = new System.Drawing.Point(25, 526);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(155, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Total number of managers";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 80);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(1044, 10);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Location = new System.Drawing.Point(23, 10);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonHeader1.Size = new System.Drawing.Size(237, 56);
            this.kryptonHeader1.TabIndex = 2;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Manage your Users";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MaxInputLength = 32;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MaxInputLength = 32;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // cinDataGridViewTextBoxColumn
            // 
            this.cinDataGridViewTextBoxColumn.DataPropertyName = "Cin";
            this.cinDataGridViewTextBoxColumn.HeaderText = "Cin";
            this.cinDataGridViewTextBoxColumn.MaxInputLength = 32;
            this.cinDataGridViewTextBoxColumn.Name = "cinDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MaxInputLength = 64;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MaxInputLength = 32;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CarRentalApp.Core.domain.User);
            // 
            // UsersPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsersPageUserControl";
            this.Size = new System.Drawing.Size(1044, 681);
            this.Load += new System.EventHandler(this.UsersPageUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView userDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox searchComboBox;
        private Panel panel5;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addUserButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton refreshDataGridViewButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteUserButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel usersCountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel mangerUserCountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel administratorUserCountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
    }
}
