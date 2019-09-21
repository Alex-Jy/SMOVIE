﻿namespace VideoDownload
{
    partial class MuShow
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
            this.PlayMovieButt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.VideoStartF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.VideoNameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.MovieID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DownloadM = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // PlayMovieButt
            // 
            this.PlayMovieButt.Depth = 0;
            this.PlayMovieButt.Font = new System.Drawing.Font("宋体", 12F);
            this.PlayMovieButt.Location = new System.Drawing.Point(634, 111);
            this.PlayMovieButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayMovieButt.Name = "PlayMovieButt";
            this.PlayMovieButt.Primary = true;
            this.PlayMovieButt.Size = new System.Drawing.Size(113, 34);
            this.PlayMovieButt.TabIndex = 24;
            this.PlayMovieButt.Text = "点击播放";
            this.PlayMovieButt.UseVisualStyleBackColor = true;
            this.PlayMovieButt.Click += new System.EventHandler(this.PlayMovieButt_Click);
            // 
            // VideoStartF
            // 
            this.VideoStartF.Depth = 0;
            this.VideoStartF.Font = new System.Drawing.Font("宋体", 12F);
            this.VideoStartF.Location = new System.Drawing.Point(10, 111);
            this.VideoStartF.MouseState = MaterialSkin.MouseState.HOVER;
            this.VideoStartF.Name = "VideoStartF";
            this.VideoStartF.Primary = true;
            this.VideoStartF.Size = new System.Drawing.Size(113, 34);
            this.VideoStartF.TabIndex = 23;
            this.VideoStartF.Text = "立即查找";
            this.VideoStartF.UseVisualStyleBackColor = true;
            this.VideoStartF.Click += new System.EventHandler(this.VideoStartF_Click);
            // 
            // VideoNameText
            // 
            this.VideoNameText.Depth = 0;
            this.VideoNameText.Hint = "";
            this.VideoNameText.Location = new System.Drawing.Point(106, 72);
            this.VideoNameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.VideoNameText.Name = "VideoNameText";
            this.VideoNameText.PasswordChar = '\0';
            this.VideoNameText.SelectedText = "";
            this.VideoNameText.SelectionLength = 0;
            this.VideoNameText.SelectionStart = 0;
            this.VideoNameText.Size = new System.Drawing.Size(416, 23);
            this.VideoNameText.TabIndex = 21;
            this.VideoNameText.Text = "上海堡垒";
            this.VideoNameText.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(11, 72);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "搜索视频：";
            // 
            // textBox_Info
            // 
            this.textBox_Info.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Info.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Info.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Info.Location = new System.Drawing.Point(10, 156);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.Size = new System.Drawing.Size(872, 472);
            this.textBox_Info.TabIndex = 6;
            this.textBox_Info.Text = "Video Information List here";
            // 
            // MovieID
            // 
            this.MovieID.Depth = 0;
            this.MovieID.Hint = "";
            this.MovieID.Location = new System.Drawing.Point(493, 119);
            this.MovieID.MouseState = MaterialSkin.MouseState.HOVER;
            this.MovieID.Name = "MovieID";
            this.MovieID.PasswordChar = '\0';
            this.MovieID.SelectedText = "";
            this.MovieID.SelectionLength = 0;
            this.MovieID.SelectionStart = 0;
            this.MovieID.Size = new System.Drawing.Size(119, 23);
            this.MovieID.TabIndex = 21;
            this.MovieID.Text = "1";
            this.MovieID.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(305, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(169, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "选择并输入视频编号：";
            // 
            // DownloadM
            // 
            this.DownloadM.Depth = 0;
            this.DownloadM.Font = new System.Drawing.Font("宋体", 12F);
            this.DownloadM.Location = new System.Drawing.Point(762, 111);
            this.DownloadM.MouseState = MaterialSkin.MouseState.HOVER;
            this.DownloadM.Name = "DownloadM";
            this.DownloadM.Primary = true;
            this.DownloadM.Size = new System.Drawing.Size(113, 34);
            this.DownloadM.TabIndex = 24;
            this.DownloadM.Text = "点击下载";
            this.DownloadM.UseVisualStyleBackColor = true;
            this.DownloadM.Click += new System.EventHandler(this.DownloadM_Click);
            // 
            // MuShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 638);
            this.Controls.Add(this.DownloadM);
            this.Controls.Add(this.PlayMovieButt);
            this.Controls.Add(this.VideoStartF);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.VideoNameText);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBox_Info);
            this.Name = "MuShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton PlayMovieButt;
        private MaterialSkin.Controls.MaterialRaisedButton VideoStartF;
        private MaterialSkin.Controls.MaterialSingleLineTextField VideoNameText;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox textBox_Info;
        private MaterialSkin.Controls.MaterialSingleLineTextField MovieID;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton DownloadM;
    }
}