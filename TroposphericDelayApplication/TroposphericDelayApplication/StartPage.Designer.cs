namespace TroposphericDelayApplication
{
    partial class StartPage
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
            this.userDataTileButton = new MetroFramework.Controls.MetroTile();
            this.standartDataTileButton = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // userDataTileButton
            // 
            this.userDataTileButton.BackColor = System.Drawing.Color.White;
            this.userDataTileButton.Location = new System.Drawing.Point(23, 83);
            this.userDataTileButton.Name = "userDataTileButton";
            this.userDataTileButton.Size = new System.Drawing.Size(240, 139);
            this.userDataTileButton.TabIndex = 0;
            this.userDataTileButton.Text = "Calculate tropospheric delay\r\nwith user data";
            this.userDataTileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userDataTileButton.Click += new System.EventHandler(this.userDataTileButton_Click);
            // 
            // standartDataTileButton
            // 
            this.standartDataTileButton.Location = new System.Drawing.Point(311, 83);
            this.standartDataTileButton.Name = "standartDataTileButton";
            this.standartDataTileButton.Size = new System.Drawing.Size(240, 139);
            this.standartDataTileButton.TabIndex = 1;
            this.standartDataTileButton.Text = "Calculate tropospheric delay\r\nwith standart data";
            this.standartDataTileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.standartDataTileButton.Click += new System.EventHandler(this.standartDataTileButton_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.standartDataTileButton);
            this.Controls.Add(this.userDataTileButton);
            this.Name = "StartPage";
            this.Text = "                              Start Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile userDataTileButton;
        private MetroFramework.Controls.MetroTile standartDataTileButton;
    }
}

