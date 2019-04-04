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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.RtbOpmerking = new System.Windows.Forms.RichTextBox();
            this.btnBestel = new System.Windows.Forms.Button();
            this.TxtHoeveelheid = new System.Windows.Forms.TextBox();
            this.TxtPrijs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBroodje = new System.Windows.Forms.ComboBox();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(172, 61);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(347, 20);
            this.txtNaam.TabIndex = 0;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNaam.Location = new System.Drawing.Point(57, 64);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(109, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Naam en achternaam";
            // 
            // RtbOpmerking
            // 
            this.RtbOpmerking.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbOpmerking.Location = new System.Drawing.Point(60, 141);
            this.RtbOpmerking.Name = "RtbOpmerking";
            this.RtbOpmerking.Size = new System.Drawing.Size(459, 178);
            this.RtbOpmerking.TabIndex = 4;
            this.RtbOpmerking.Text = "";
            // 
            // btnBestel
            // 
            this.btnBestel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBestel.BackgroundImage = global::BroodjesBestellen.Properties.Resources.S811CBK;
            this.btnBestel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBestel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBestel.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestel.Location = new System.Drawing.Point(60, 343);
            this.btnBestel.Name = "btnBestel";
            this.btnBestel.Size = new System.Drawing.Size(83, 33);
            this.btnBestel.TabIndex = 3;
            this.btnBestel.Text = "Bestel";
            this.btnBestel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBestel.UseVisualStyleBackColor = false;
            this.btnBestel.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtHoeveelheid
            // 
            this.TxtHoeveelheid.Location = new System.Drawing.Point(172, 115);
            this.TxtHoeveelheid.Name = "TxtHoeveelheid";
            this.TxtHoeveelheid.Size = new System.Drawing.Size(121, 20);
            this.TxtHoeveelheid.TabIndex = 2;
            this.TxtHoeveelheid.TextChanged += new System.EventHandler(this.TxtHoeveelheid_TextChanged);
            // 
            // TxtPrijs
            // 
            this.TxtPrijs.Location = new System.Drawing.Point(343, 86);
            this.TxtPrijs.Name = "TxtPrijs";
            this.TxtPrijs.Size = new System.Drawing.Size(176, 20);
            this.TxtPrijs.TabIndex = 3;
            this.TxtPrijs.TextChanged += new System.EventHandler(this.TxtPrijs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(123, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Broodje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(99, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hoeveelheid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(311, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prijs";
            // 
            // txtBroodje
            // 
            this.txtBroodje.FormattingEnabled = true;
            this.txtBroodje.Location = new System.Drawing.Point(172, 88);
            this.txtBroodje.Name = "txtBroodje";
            this.txtBroodje.Size = new System.Drawing.Size(121, 21);
            this.txtBroodje.TabIndex = 1;
            this.txtBroodje.SelectedIndexChanged += new System.EventHandler(this.txtBroodje_SelectedIndexChanged);
            // 
            // txtTotaal
            // 
            this.txtTotaal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotaal.Location = new System.Drawing.Point(343, 112);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.ReadOnly = true;
            this.txtTotaal.Size = new System.Drawing.Size(176, 20);
            this.txtTotaal.TabIndex = 9;
            this.txtTotaal.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(300, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Totaal";
            // 
            // FrmBroodjes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BroodjesBestellen.Properties.Resources.S811CBK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 437);
            this.Controls.Add(this.RtbOpmerking);
            this.Controls.Add(this.txtBroodje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.TxtPrijs);
            this.Controls.Add(this.TxtHoeveelheid);
            this.Controls.Add(this.btnBestel);
            this.Name = "FrmBroodjes";
            this.Text = "Broodjes";
            this.Load += new System.EventHandler(this.FrmBroodjes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.RichTextBox RtbOpmerking;
        private System.Windows.Forms.Button btnBestel;
        private System.Windows.Forms.TextBox TxtHoeveelheid;
        private System.Windows.Forms.TextBox TxtPrijs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBroodje;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.Label label4;
    }
}

