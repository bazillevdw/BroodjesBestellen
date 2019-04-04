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
            this.GbBestelling = new System.Windows.Forms.GroupBox();
            this.txtBroodje = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrijs = new System.Windows.Forms.TextBox();
            this.TxtHoeveelheid = new System.Windows.Forms.TextBox();
            this.btnBestel = new System.Windows.Forms.Button();
            this.RtbOpmerking = new System.Windows.Forms.RichTextBox();
            this.PbxBroodje = new System.Windows.Forms.PictureBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbBestelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBroodje)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbBestelling
            // 
            this.GbBestelling.Controls.Add(this.txtBroodje);
            this.GbBestelling.Controls.Add(this.label3);
            this.GbBestelling.Controls.Add(this.label2);
            this.GbBestelling.Controls.Add(this.label1);
            this.GbBestelling.Controls.Add(this.TxtPrijs);
            this.GbBestelling.Controls.Add(this.TxtHoeveelheid);
            this.GbBestelling.Controls.Add(this.btnBestel);
            this.GbBestelling.Controls.Add(this.RtbOpmerking);
            this.GbBestelling.Controls.Add(this.PbxBroodje);
            this.GbBestelling.Location = new System.Drawing.Point(0, 38);
            this.GbBestelling.Name = "GbBestelling";
            this.GbBestelling.Size = new System.Drawing.Size(523, 314);
            this.GbBestelling.TabIndex = 1;
            this.GbBestelling.TabStop = false;
            this.GbBestelling.Text = "Bestelling";
            this.GbBestelling.Enter += new System.EventHandler(this.GbBestelling_Enter);
            // 
            // txtBroodje
            // 
            this.txtBroodje.FormattingEnabled = true;
            this.txtBroodje.Location = new System.Drawing.Point(89, 20);
            this.txtBroodje.Name = "txtBroodje";
            this.txtBroodje.Size = new System.Drawing.Size(121, 21);
            this.txtBroodje.TabIndex = 1;
            this.txtBroodje.SelectedIndexChanged += new System.EventHandler(this.txtBroodje_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prijs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hoeveelheid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Broodje";
            // 
            // TxtPrijs
            // 
            this.TxtPrijs.Location = new System.Drawing.Point(89, 73);
            this.TxtPrijs.Name = "TxtPrijs";
            this.TxtPrijs.Size = new System.Drawing.Size(121, 20);
            this.TxtPrijs.TabIndex = 3;
            // 
            // TxtHoeveelheid
            // 
            this.TxtHoeveelheid.Location = new System.Drawing.Point(89, 47);
            this.TxtHoeveelheid.Name = "TxtHoeveelheid";
            this.TxtHoeveelheid.Size = new System.Drawing.Size(121, 20);
            this.TxtHoeveelheid.TabIndex = 2;
            // 
            // btnBestel
            // 
            this.btnBestel.Location = new System.Drawing.Point(89, 114);
            this.btnBestel.Name = "btnBestel";
            this.btnBestel.Size = new System.Drawing.Size(121, 23);
            this.btnBestel.TabIndex = 3;
            this.btnBestel.Text = "Bestel";
            this.btnBestel.UseVisualStyleBackColor = true;
            this.btnBestel.Click += new System.EventHandler(this.button1_Click);
            // 
            // RtbOpmerking
            // 
            this.RtbOpmerking.Location = new System.Drawing.Point(4, 143);
            this.RtbOpmerking.Name = "RtbOpmerking";
            this.RtbOpmerking.Size = new System.Drawing.Size(516, 157);
            this.RtbOpmerking.TabIndex = 4;
            this.RtbOpmerking.Text = "";
            // 
            // PbxBroodje
            // 
            this.PbxBroodje.Location = new System.Drawing.Point(216, 19);
            this.PbxBroodje.Name = "PbxBroodje";
            this.PbxBroodje.Size = new System.Drawing.Size(301, 118);
            this.PbxBroodje.TabIndex = 1;
            this.PbxBroodje.TabStop = false;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(121, 12);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(201, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(6, 15);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(109, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Naam en achternaam";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 349);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.backToMenuToolStripMenuItem.Text = "Terug naar Keuze menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // FrmBroodjes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BroodjesBestellen.Properties.Resources.munt_base_wit_3;
            this.ClientSize = new System.Drawing.Size(520, 373);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.GbBestelling);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBroodjes";
            this.Text = "Broodjes";
            this.Load += new System.EventHandler(this.FrmBroodjes_Load);
            this.GbBestelling.ResumeLayout(false);
            this.GbBestelling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBroodje)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbBestelling;
        private System.Windows.Forms.RichTextBox RtbOpmerking;
        private System.Windows.Forms.PictureBox PbxBroodje;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnBestel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrijs;
        private System.Windows.Forms.TextBox TxtHoeveelheid;
        private System.Windows.Forms.ComboBox txtBroodje;
    }
}

