using System.Drawing;
using System.Windows.Forms;

namespace AlbumInventoryClient
{
    partial class MainForm
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
            dgvAlbums = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btn_Delete = new Button();
            btn_Refresh = new Button();
            lblId = new Label();
            lblTitle = new Label();
            lblArtist = new Label();
            lblGenre = new Label();
            lblYear = new Label();
            txtId = new TextBox();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtGenre = new TextBox();
            txtYear = new TextBox();
            chkAvailable = new CheckBox();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbums
            // 
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.Location = new Point(387, 24);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.RowHeadersWidth = 62;
            dgvAlbums.Size = new Size(1017, 463);
            dgvAlbums.TabIndex = 0;
            dgvAlbums.SelectionChanged += dgvAlbums_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(489, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(147, 66);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(738, 538);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 66);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(979, 538);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(147, 66);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(1234, 538);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(147, 66);
            btn_Refresh.TabIndex = 1;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(33, 52);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 30);
            lblId.TabIndex = 2;
            lblId.Text = "Id:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F);
            lblTitle.Location = new Point(33, 118);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title:";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Font = new Font("Segoe UI", 11F);
            lblArtist.Location = new Point(33, 181);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(68, 30);
            lblArtist.TabIndex = 2;
            lblArtist.Text = "Artist:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 11F);
            lblGenre.Location = new Point(33, 255);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(77, 30);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Genre:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 11F);
            lblYear.Location = new Point(33, 335);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(59, 30);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year:";
            // 
            // txtId
            // 
            txtId.Location = new Point(199, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(199, 117);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 3;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(199, 180);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(150, 31);
            txtArtist.TabIndex = 3;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(199, 254);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(150, 31);
            txtGenre.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(199, 334);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 3;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Font = new Font("Segoe UI", 10F);
            chkAvailable.Location = new Point(132, 418);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(118, 32);
            chkAvailable.TabIndex = 4;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F);
            lblStatus.Location = new Point(56, 515);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 30);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 677);
            Controls.Add(lblStatus);
            Controls.Add(chkAvailable);
            Controls.Add(txtYear);
            Controls.Add(txtGenre);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(lblYear);
            Controls.Add(lblGenre);
            Controls.Add(lblArtist);
            Controls.Add(lblTitle);
            Controls.Add(lblId);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_Delete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvAlbums);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlbums;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btn_Delete;
        private Button btn_Refresh;
        private Label lblId;
        private Label lblTitle;
        private Label lblArtist;
        private Label lblGenre;
        private Label lblYear;
        private TextBox txtId;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtGenre;
        private TextBox txtYear;
        private CheckBox chkAvailable;
        private Label lblStatus;
    }
}