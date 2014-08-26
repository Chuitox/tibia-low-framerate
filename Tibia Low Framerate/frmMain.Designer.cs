namespace TLF
{
    partial class frmMain
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
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblFPS = new System.Windows.Forms.Label();
            this.nmrcFPS = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstbxClients = new System.Windows.Forms.ListBox();
            this.btnUpdateSelection = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.btnResetSelection = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFPS)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.Color.Transparent;
            this.grpBox.Controls.Add(this.picBox);
            this.grpBox.Controls.Add(this.lblFPS);
            this.grpBox.Controls.Add(this.nmrcFPS);
            this.grpBox.Controls.Add(this.btnRefresh);
            this.grpBox.Controls.Add(this.lstbxClients);
            this.grpBox.Location = new System.Drawing.Point(12, 5);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(355, 129);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = global::TLF.Properties.Resources.icon;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox.Location = new System.Drawing.Point(6, 19);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(118, 104);
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(253, 105);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(27, 13);
            this.lblFPS.TabIndex = 5;
            this.lblFPS.Text = "FPS";
            // 
            // nmrcFPS
            // 
            this.nmrcFPS.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrcFPS.Location = new System.Drawing.Point(286, 103);
            this.nmrcFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcFPS.Name = "nmrcFPS";
            this.nmrcFPS.Size = new System.Drawing.Size(54, 20);
            this.nmrcFPS.TabIndex = 4;
            this.nmrcFPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(130, 101);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lstbxClients
            // 
            this.lstbxClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstbxClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxClients.FormattingEnabled = true;
            this.lstbxClients.Location = new System.Drawing.Point(130, 19);
            this.lstbxClients.Name = "lstbxClients";
            this.lstbxClients.Size = new System.Drawing.Size(210, 80);
            this.lstbxClients.TabIndex = 2;
            this.lstbxClients.SelectedIndexChanged += new System.EventHandler(this.lstbxClients_SelectedIndexChanged);
            // 
            // btnUpdateSelection
            // 
            this.btnUpdateSelection.Enabled = false;
            this.btnUpdateSelection.Location = new System.Drawing.Point(12, 140);
            this.btnUpdateSelection.Name = "btnUpdateSelection";
            this.btnUpdateSelection.Size = new System.Drawing.Size(80, 23);
            this.btnUpdateSelection.TabIndex = 4;
            this.btnUpdateSelection.Text = "Update";
            this.btnUpdateSelection.UseVisualStyleBackColor = true;
            this.btnUpdateSelection.Click += new System.EventHandler(this.btnUpdateSelection_Click);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Enabled = false;
            this.btnUpdateAll.Location = new System.Drawing.Point(104, 140);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(80, 23);
            this.btnUpdateAll.TabIndex = 5;
            this.btnUpdateAll.Text = "Update All";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // btnResetSelection
            // 
            this.btnResetSelection.Enabled = false;
            this.btnResetSelection.Location = new System.Drawing.Point(196, 140);
            this.btnResetSelection.Name = "btnResetSelection";
            this.btnResetSelection.Size = new System.Drawing.Size(80, 23);
            this.btnResetSelection.TabIndex = 6;
            this.btnResetSelection.Text = "Reset";
            this.btnResetSelection.UseVisualStyleBackColor = true;
            this.btnResetSelection.Click += new System.EventHandler(this.btnResetSelection_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Enabled = false;
            this.btnResetAll.Location = new System.Drawing.Point(287, 140);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(80, 23);
            this.btnResetAll.TabIndex = 7;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 171);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnResetSelection);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.btnUpdateSelection);
            this.Controls.Add(this.grpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(395, 205);
            this.MinimumSize = new System.Drawing.Size(395, 205);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tibia Low Framerate - v1.1";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcFPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstbxClients;
        private System.Windows.Forms.Button btnUpdateSelection;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Button btnResetSelection;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.NumericUpDown nmrcFPS;
        private System.Windows.Forms.PictureBox picBox;
    }
}

