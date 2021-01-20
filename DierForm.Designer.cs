
namespace InheritanceEx
{
    partial class DierForm
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
            this.lblDieren = new System.Windows.Forms.Label();
            this.radioKat = new System.Windows.Forms.RadioButton();
            this.radioPapegaai = new System.Windows.Forms.RadioButton();
            this.radioMens = new System.Windows.Forms.RadioButton();
            this.lblKiesZin = new System.Windows.Forms.Label();
            this.btnStrelen = new System.Windows.Forms.Button();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.textBoxDierNaam = new System.Windows.Forms.TextBox();
            this.lblGeefDierNaam = new System.Windows.Forms.Label();
            this.btnPraten = new System.Windows.Forms.Button();
            this.btnEten = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.listBoxVragen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDieren
            // 
            this.lblDieren.AutoSize = true;
            this.lblDieren.Location = new System.Drawing.Point(32, 25);
            this.lblDieren.Name = "lblDieren";
            this.lblDieren.Size = new System.Drawing.Size(38, 13);
            this.lblDieren.TabIndex = 0;
            this.lblDieren.Text = "Dieren";
            // 
            // radioKat
            // 
            this.radioKat.AutoSize = true;
            this.radioKat.Location = new System.Drawing.Point(35, 50);
            this.radioKat.Name = "radioKat";
            this.radioKat.Size = new System.Drawing.Size(41, 17);
            this.radioKat.TabIndex = 1;
            this.radioKat.TabStop = true;
            this.radioKat.Text = "Kat";
            this.radioKat.UseVisualStyleBackColor = true;
            // 
            // radioPapegaai
            // 
            this.radioPapegaai.AutoSize = true;
            this.radioPapegaai.Location = new System.Drawing.Point(35, 73);
            this.radioPapegaai.Name = "radioPapegaai";
            this.radioPapegaai.Size = new System.Drawing.Size(70, 17);
            this.radioPapegaai.TabIndex = 2;
            this.radioPapegaai.TabStop = true;
            this.radioPapegaai.Text = "Papegaai";
            this.radioPapegaai.UseVisualStyleBackColor = true;
            // 
            // radioMens
            // 
            this.radioMens.AutoSize = true;
            this.radioMens.Location = new System.Drawing.Point(35, 96);
            this.radioMens.Name = "radioMens";
            this.radioMens.Size = new System.Drawing.Size(51, 17);
            this.radioMens.TabIndex = 3;
            this.radioMens.TabStop = true;
            this.radioMens.Text = "Mens";
            this.radioMens.UseVisualStyleBackColor = true;
            // 
            // lblKiesZin
            // 
            this.lblKiesZin.AutoSize = true;
            this.lblKiesZin.Location = new System.Drawing.Point(32, 148);
            this.lblKiesZin.Name = "lblKiesZin";
            this.lblKiesZin.Size = new System.Drawing.Size(140, 13);
            this.lblKiesZin.TabIndex = 4;
            this.lblKiesZin.Text = "Kies een zin uit om te praten";
            // 
            // btnStrelen
            // 
            this.btnStrelen.Location = new System.Drawing.Point(35, 307);
            this.btnStrelen.Name = "btnStrelen";
            this.btnStrelen.Size = new System.Drawing.Size(116, 63);
            this.btnStrelen.TabIndex = 6;
            this.btnStrelen.Text = "Strelen";
            this.btnStrelen.UseVisualStyleBackColor = true;
            this.btnStrelen.Click += new System.EventHandler(this.btnStrelen_Click);
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Enabled = false;
            this.btnAanmaken.Location = new System.Drawing.Point(439, 38);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(116, 40);
            this.btnAanmaken.TabIndex = 9;
            this.btnAanmaken.Text = "Aanmaken";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // textBoxDierNaam
            // 
            this.textBoxDierNaam.Location = new System.Drawing.Point(240, 50);
            this.textBoxDierNaam.Name = "textBoxDierNaam";
            this.textBoxDierNaam.Size = new System.Drawing.Size(136, 20);
            this.textBoxDierNaam.TabIndex = 10;
            this.textBoxDierNaam.TextChanged += new System.EventHandler(this.textBoxDierNaam_TextChanged);
            // 
            // lblGeefDierNaam
            // 
            this.lblGeefDierNaam.AutoSize = true;
            this.lblGeefDierNaam.Location = new System.Drawing.Point(237, 25);
            this.lblGeefDierNaam.Name = "lblGeefDierNaam";
            this.lblGeefDierNaam.Size = new System.Drawing.Size(110, 13);
            this.lblGeefDierNaam.TabIndex = 11;
            this.lblGeefDierNaam.Text = "Geef \"dier\" een naam";
            // 
            // btnPraten
            // 
            this.btnPraten.Enabled = false;
            this.btnPraten.Location = new System.Drawing.Point(240, 169);
            this.btnPraten.Name = "btnPraten";
            this.btnPraten.Size = new System.Drawing.Size(116, 43);
            this.btnPraten.TabIndex = 12;
            this.btnPraten.Text = "Praten ";
            this.btnPraten.UseVisualStyleBackColor = true;
            this.btnPraten.Click += new System.EventHandler(this.btnPraten_Click);
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(240, 307);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(116, 63);
            this.btnEten.TabIndex = 13;
            this.btnEten.Text = "Eten";
            this.btnEten.UseVisualStyleBackColor = true;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(439, 307);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(116, 63);
            this.btnSluiten.TabIndex = 14;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // listBoxVragen
            // 
            this.listBoxVragen.FormattingEnabled = true;
            this.listBoxVragen.Items.AddRange(new object[] {
            "Hallo ",
            "Goedendag",
            "Goedemorgen",
            "Hoe gaat het?",
            "Hoe laat is het?",
            "Welke dag is het?",
            "Welk dier ben jij?",
            "Wat is je naam?"});
            this.listBoxVragen.Location = new System.Drawing.Point(35, 169);
            this.listBoxVragen.Name = "listBoxVragen";
            this.listBoxVragen.Size = new System.Drawing.Size(120, 108);
            this.listBoxVragen.TabIndex = 15;
            this.listBoxVragen.SelectedIndexChanged += new System.EventHandler(this.listBoxZin_SelectedIndexChanged);
            // 
            // DierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 434);
            this.Controls.Add(this.listBoxVragen);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.btnPraten);
            this.Controls.Add(this.lblGeefDierNaam);
            this.Controls.Add(this.textBoxDierNaam);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.btnStrelen);
            this.Controls.Add(this.lblKiesZin);
            this.Controls.Add(this.radioMens);
            this.Controls.Add(this.radioPapegaai);
            this.Controls.Add(this.radioKat);
            this.Controls.Add(this.lblDieren);
            this.Name = "DierForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDieren;
        private System.Windows.Forms.RadioButton radioKat;
        private System.Windows.Forms.RadioButton radioPapegaai;
        private System.Windows.Forms.RadioButton radioMens;
        private System.Windows.Forms.Label lblKiesZin;
        private System.Windows.Forms.Button btnStrelen;
        private System.Windows.Forms.Button btnAanmaken;
        private System.Windows.Forms.TextBox textBoxDierNaam;
        private System.Windows.Forms.Label lblGeefDierNaam;
        private System.Windows.Forms.Button btnPraten;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.ListBox listBoxVragen;
    }
}