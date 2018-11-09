namespace BroodjesBestellen
{
    partial class FrmBroodjes
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
            this.CbBroodjes = new System.Windows.Forms.ComboBox();
            this.GbBestelling = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RtbOpmerking = new System.Windows.Forms.RichTextBox();
            this.PbxBroodje = new System.Windows.Forms.PictureBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbBestelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBroodje)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbBroodjes
            // 
            this.CbBroodjes.FormattingEnabled = true;
            this.CbBroodjes.Location = new System.Drawing.Point(6, 19);
            this.CbBroodjes.Name = "CbBroodjes";
            this.CbBroodjes.Size = new System.Drawing.Size(121, 21);
            this.CbBroodjes.TabIndex = 0;
            // 
            // GbBestelling
            // 
            this.GbBestelling.Controls.Add(this.button1);
            this.GbBestelling.Controls.Add(this.RtbOpmerking);
            this.GbBestelling.Controls.Add(this.PbxBroodje);
            this.GbBestelling.Controls.Add(this.CbBroodjes);
            this.GbBestelling.Location = new System.Drawing.Point(12, 38);
            this.GbBestelling.Name = "GbBestelling";
            this.GbBestelling.Size = new System.Drawing.Size(492, 331);
            this.GbBestelling.TabIndex = 1;
            this.GbBestelling.TabStop = false;
            this.GbBestelling.Text = "Bestelling";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bestel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RtbOpmerking
            // 
            this.RtbOpmerking.Location = new System.Drawing.Point(12, 150);
            this.RtbOpmerking.Name = "RtbOpmerking";
            this.RtbOpmerking.Size = new System.Drawing.Size(474, 157);
            this.RtbOpmerking.TabIndex = 2;
            this.RtbOpmerking.Text = "";
            // 
            // PbxBroodje
            // 
            this.PbxBroodje.Location = new System.Drawing.Point(185, 19);
            this.PbxBroodje.Name = "PbxBroodje";
            this.PbxBroodje.Size = new System.Drawing.Size(301, 118);
            this.PbxBroodje.TabIndex = 1;
            this.PbxBroodje.TabStop = false;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(128, 12);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(150, 20);
            this.txtNaam.TabIndex = 2;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(13, 15);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(109, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Naam en achternaam";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 376);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.backToMenuToolStripMenuItem.Text = "Back to menu";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.undoToolStripMenuItem.Text = "undo";
            // 
            // FrmBroodjes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BroodjesBestellen.Properties.Resources.munt_base_wit_3;
            this.ClientSize = new System.Drawing.Size(516, 400);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.GbBestelling);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBroodjes";
            this.Text = "Broodjes";
            this.Load += new System.EventHandler(this.FrmBroodjes_Load);
            this.GbBestelling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxBroodje)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbBroodjes;
        private System.Windows.Forms.GroupBox GbBestelling;
        private System.Windows.Forms.RichTextBox RtbOpmerking;
        private System.Windows.Forms.PictureBox PbxBroodje;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

