namespace TroposphericDelayApplication
{
    partial class CalculationDelayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationDelayForm));
            this.latitudeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.latitudeLabel = new MetroFramework.Controls.MetroLabel();
            this.LongitudeLabel = new MetroFramework.Controls.MetroLabel();
            this.longitudeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.delayLabel = new MetroFramework.Controls.MetroLabel();
            this.delayTextBox = new MetroFramework.Controls.MetroTextBox();
            this.calculateTile = new MetroFramework.Controls.MetroTile();
            this.BackTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(121, 85);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(193, 29);
            this.latitudeTextBox.TabIndex = 1;
            this.latitudeTextBox.Click += new System.EventHandler(this.latitudeTextBox_Click);
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.latitudeLabel.Location = new System.Drawing.Point(23, 85);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(76, 25);
            this.latitudeLabel.TabIndex = 4;
            this.latitudeLabel.Text = "Latitude:";
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LongitudeLabel.Location = new System.Drawing.Point(23, 120);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(92, 25);
            this.LongitudeLabel.TabIndex = 6;
            this.LongitudeLabel.Text = "Longitude:";
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Location = new System.Drawing.Point(121, 120);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(193, 29);
            this.longitudeTextBox.TabIndex = 5;
            this.longitudeTextBox.Click += new System.EventHandler(this.longitudeTextBox_Click);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.delayLabel.Location = new System.Drawing.Point(23, 174);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(58, 25);
            this.delayLabel.TabIndex = 8;
            this.delayLabel.Text = "Delay:";
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(121, 155);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(193, 76);
            this.delayTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.delayTextBox.TabIndex = 9;
            // 
            // calculateTile
            // 
            this.calculateTile.Location = new System.Drawing.Point(384, 85);
            this.calculateTile.Name = "calculateTile";
            this.calculateTile.Size = new System.Drawing.Size(167, 64);
            this.calculateTile.TabIndex = 10;
            this.calculateTile.Text = "Calculate";
            this.calculateTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackTile
            // 
            this.BackTile.Location = new System.Drawing.Point(9, 13);
            this.BackTile.Name = "BackTile";
            this.BackTile.Size = new System.Drawing.Size(52, 52);
            this.BackTile.Style = MetroFramework.MetroColorStyle.White;
            this.BackTile.TabIndex = 11;
            this.BackTile.TileImage = ((System.Drawing.Image)(resources.GetObject("BackTile.TileImage")));
            this.BackTile.UseTileImage = true;
            this.BackTile.Click += new System.EventHandler(this.BackTile_Click);
            // 
            // CalculationDelayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.BackTile);
            this.Controls.Add(this.calculateTile);
            this.Controls.Add(this.delayTextBox);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.LongitudeLabel);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.latitudeTextBox);
            this.Name = "CalculationDelayForm";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "          Input data and calculate tropospheric delay";
            this.Load += new System.EventHandler(this.CalculationDelayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox latitudeTextBox;
        private MetroFramework.Controls.MetroLabel latitudeLabel;
        private MetroFramework.Controls.MetroLabel LongitudeLabel;
        private MetroFramework.Controls.MetroTextBox longitudeTextBox;
        private MetroFramework.Controls.MetroLabel delayLabel;
        private MetroFramework.Controls.MetroTextBox delayTextBox;
        private MetroFramework.Controls.MetroTile calculateTile;
        private MetroFramework.Controls.MetroTile BackTile;
    }
}