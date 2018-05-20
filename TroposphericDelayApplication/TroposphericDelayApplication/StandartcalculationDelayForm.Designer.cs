namespace TroposphericDelayApplication
{
    partial class StandartCalculationDelayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandartCalculationDelayForm));
            this.BackTile = new MetroFramework.Controls.MetroTile();
            this.CalculateTile = new MetroFramework.Controls.MetroTile();
            this.DelayTextBox = new MetroFramework.Controls.MetroTextBox();
            this.delayLabel = new MetroFramework.Controls.MetroLabel();
            this.AltitudeLabel = new MetroFramework.Controls.MetroLabel();
            this.AltitudeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.latitudeLabel = new MetroFramework.Controls.MetroLabel();
            this.LatitudeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // BackTile
            // 
            this.BackTile.Location = new System.Drawing.Point(10, 11);
            this.BackTile.Name = "BackTile";
            this.BackTile.Size = new System.Drawing.Size(52, 52);
            this.BackTile.Style = MetroFramework.MetroColorStyle.White;
            this.BackTile.TabIndex = 19;
            this.BackTile.TileImage = ((System.Drawing.Image)(resources.GetObject("BackTile.TileImage")));
            this.BackTile.UseTileImage = true;
            this.BackTile.Click += new System.EventHandler(this.BackTile_Click);
            // 
            // CalculateTile
            // 
            this.CalculateTile.Location = new System.Drawing.Point(382, 84);
            this.CalculateTile.Name = "CalculateTile";
            this.CalculateTile.Size = new System.Drawing.Size(167, 64);
            this.CalculateTile.TabIndex = 18;
            this.CalculateTile.Text = "Calculate";
            this.CalculateTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CalculateTile.Click += new System.EventHandler(this.CalculateTile_Click);
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Location = new System.Drawing.Point(131, 154);
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.Size = new System.Drawing.Size(193, 76);
            this.DelayTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.DelayTextBox.TabIndex = 17;
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.delayLabel.Location = new System.Drawing.Point(21, 173);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(58, 25);
            this.delayLabel.TabIndex = 16;
            this.delayLabel.Text = "Delay:";
            // 
            // AltitudeLabel
            // 
            this.AltitudeLabel.AutoSize = true;
            this.AltitudeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AltitudeLabel.Location = new System.Drawing.Point(21, 119);
            this.AltitudeLabel.Name = "AltitudeLabel";
            this.AltitudeLabel.Size = new System.Drawing.Size(104, 25);
            this.AltitudeLabel.TabIndex = 15;
            this.AltitudeLabel.Text = "Altitude (m):";
            // 
            // AltitudeTextBox
            // 
            this.AltitudeTextBox.Location = new System.Drawing.Point(131, 119);
            this.AltitudeTextBox.Name = "AltitudeTextBox";
            this.AltitudeTextBox.Size = new System.Drawing.Size(193, 29);
            this.AltitudeTextBox.TabIndex = 14;
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.latitudeLabel.Location = new System.Drawing.Point(21, 84);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(98, 25);
            this.latitudeLabel.TabIndex = 13;
            this.latitudeLabel.Text = "Latitude (°):";
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.Location = new System.Drawing.Point(131, 84);
            this.LatitudeTextBox.Name = "LatitudeTextBox";
            this.LatitudeTextBox.Size = new System.Drawing.Size(193, 29);
            this.LatitudeTextBox.TabIndex = 12;
            // 
            // StandartCalculationDelayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.BackTile);
            this.Controls.Add(this.CalculateTile);
            this.Controls.Add(this.DelayTextBox);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.AltitudeLabel);
            this.Controls.Add(this.AltitudeTextBox);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.LatitudeTextBox);
            this.Name = "StandartCalculationDelayForm";
            this.Text = "          Input data and calculate tropospheric delay";
            this.Load += new System.EventHandler(this.StandartCalculationDelayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile BackTile;
        private MetroFramework.Controls.MetroTile CalculateTile;
        private MetroFramework.Controls.MetroTextBox DelayTextBox;
        private MetroFramework.Controls.MetroLabel delayLabel;
        private MetroFramework.Controls.MetroLabel AltitudeLabel;
        private MetroFramework.Controls.MetroTextBox AltitudeTextBox;
        private MetroFramework.Controls.MetroLabel latitudeLabel;
        private MetroFramework.Controls.MetroTextBox LatitudeTextBox;
    }
}