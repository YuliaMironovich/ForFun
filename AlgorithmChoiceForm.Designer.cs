namespace TroposphericDelayApplication
{
    partial class AlgorithmChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgorithmChoiceForm));
            this.SaastamoinenModelRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.HopfieldModelRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.NeilModelRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.BlackModelRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.BackTile = new MetroFramework.Controls.MetroTile();
            this.ForwardTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // SaastamoinenModelRadioButton
            // 
            this.SaastamoinenModelRadioButton.AutoSize = true;
            this.SaastamoinenModelRadioButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.SaastamoinenModelRadioButton.Location = new System.Drawing.Point(84, 122);
            this.SaastamoinenModelRadioButton.Name = "SaastamoinenModelRadioButton";
            this.SaastamoinenModelRadioButton.Size = new System.Drawing.Size(195, 25);
            this.SaastamoinenModelRadioButton.TabIndex = 0;
            this.SaastamoinenModelRadioButton.TabStop = true;
            this.SaastamoinenModelRadioButton.Text = "Saastamoinen model";
            this.SaastamoinenModelRadioButton.UseVisualStyleBackColor = true;
            this.SaastamoinenModelRadioButton.CheckedChanged += new System.EventHandler(this.SaastamoinenModelRadioButton_CheckedChanged);
            // 
            // HopfieldModelRadioButton
            // 
            this.HopfieldModelRadioButton.AutoSize = true;
            this.HopfieldModelRadioButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.HopfieldModelRadioButton.Location = new System.Drawing.Point(84, 173);
            this.HopfieldModelRadioButton.Name = "HopfieldModelRadioButton";
            this.HopfieldModelRadioButton.Size = new System.Drawing.Size(153, 25);
            this.HopfieldModelRadioButton.TabIndex = 1;
            this.HopfieldModelRadioButton.TabStop = true;
            this.HopfieldModelRadioButton.Text = "Hopfield model";
            this.HopfieldModelRadioButton.UseVisualStyleBackColor = true;
            this.HopfieldModelRadioButton.CheckedChanged += new System.EventHandler(this.HopfieldModelRadioButton_CheckedChanged);
            // 
            // NeilModelRadioButton
            // 
            this.NeilModelRadioButton.AutoSize = true;
            this.NeilModelRadioButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.NeilModelRadioButton.Location = new System.Drawing.Point(369, 122);
            this.NeilModelRadioButton.Name = "NeilModelRadioButton";
            this.NeilModelRadioButton.Size = new System.Drawing.Size(114, 25);
            this.NeilModelRadioButton.TabIndex = 2;
            this.NeilModelRadioButton.TabStop = true;
            this.NeilModelRadioButton.Text = "Neil model";
            this.NeilModelRadioButton.UseVisualStyleBackColor = true;
            this.NeilModelRadioButton.CheckedChanged += new System.EventHandler(this.NeilModelRadioButton_CheckedChanged);
            // 
            // BlackModelRadioButton
            // 
            this.BlackModelRadioButton.AutoSize = true;
            this.BlackModelRadioButton.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.BlackModelRadioButton.Location = new System.Drawing.Point(369, 173);
            this.BlackModelRadioButton.Name = "BlackModelRadioButton";
            this.BlackModelRadioButton.Size = new System.Drawing.Size(124, 25);
            this.BlackModelRadioButton.TabIndex = 3;
            this.BlackModelRadioButton.TabStop = true;
            this.BlackModelRadioButton.Text = "Black model";
            this.BlackModelRadioButton.UseVisualStyleBackColor = true;
            this.BlackModelRadioButton.CheckedChanged += new System.EventHandler(this.BlackModelRadioButton_CheckedChanged);
            // 
            // BackTile
            // 
            this.BackTile.Location = new System.Drawing.Point(23, 10);
            this.BackTile.Name = "BackTile";
            this.BackTile.Size = new System.Drawing.Size(52, 52);
            this.BackTile.Style = MetroFramework.MetroColorStyle.White;
            this.BackTile.TabIndex = 5;
            this.BackTile.TileImage = ((System.Drawing.Image)(resources.GetObject("BackTile.TileImage")));
            this.BackTile.UseTileImage = true;
            this.BackTile.Click += new System.EventHandler(this.BackTile_Click);
            // 
            // ForwardTile
            // 
            this.ForwardTile.Location = new System.Drawing.Point(499, 10);
            this.ForwardTile.Name = "ForwardTile";
            this.ForwardTile.Size = new System.Drawing.Size(52, 52);
            this.ForwardTile.Style = MetroFramework.MetroColorStyle.White;
            this.ForwardTile.TabIndex = 6;
            this.ForwardTile.TileImage = ((System.Drawing.Image)(resources.GetObject("ForwardTile.TileImage")));
            this.ForwardTile.UseTileImage = true;
            this.ForwardTile.Click += new System.EventHandler(this.ForwardTile_Click);
            // 
            // AlgorithmChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.ForwardTile);
            this.Controls.Add(this.BackTile);
            this.Controls.Add(this.BlackModelRadioButton);
            this.Controls.Add(this.NeilModelRadioButton);
            this.Controls.Add(this.HopfieldModelRadioButton);
            this.Controls.Add(this.SaastamoinenModelRadioButton);
            this.Name = "AlgorithmChoiceForm";
            this.Text = "                            Select algorithm";
            this.Load += new System.EventHandler(this.AlgorithmChoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton SaastamoinenModelRadioButton;
        private MetroFramework.Controls.MetroRadioButton HopfieldModelRadioButton;
        private MetroFramework.Controls.MetroRadioButton NeilModelRadioButton;
        private MetroFramework.Controls.MetroRadioButton BlackModelRadioButton;
        private MetroFramework.Controls.MetroTile BackTile;
        private MetroFramework.Controls.MetroTile ForwardTile;
    }
}