
namespace InheritanceEx
{
    partial class MainForm
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
            this.btnRekening = new System.Windows.Forms.Button();
            this.btnDieren = new System.Windows.Forms.Button();
            this.btnCilinder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRekening
            // 
            this.btnRekening.Location = new System.Drawing.Point(66, 34);
            this.btnRekening.Name = "btnRekening";
            this.btnRekening.Size = new System.Drawing.Size(75, 23);
            this.btnRekening.TabIndex = 0;
            this.btnRekening.Text = "Rekening";
            this.btnRekening.UseVisualStyleBackColor = true;
            this.btnRekening.Click += new System.EventHandler(this.btnRekening_Click);
            // 
            // btnDieren
            // 
            this.btnDieren.Location = new System.Drawing.Point(66, 63);
            this.btnDieren.Name = "btnDieren";
            this.btnDieren.Size = new System.Drawing.Size(75, 23);
            this.btnDieren.TabIndex = 1;
            this.btnDieren.Text = "Dieren";
            this.btnDieren.UseVisualStyleBackColor = true;
            this.btnDieren.Click += new System.EventHandler(this.btnDieren_Click);
            // 
            // btnCilinder
            // 
            this.btnCilinder.Location = new System.Drawing.Point(66, 92);
            this.btnCilinder.Name = "btnCilinder";
            this.btnCilinder.Size = new System.Drawing.Size(75, 23);
            this.btnCilinder.TabIndex = 2;
            this.btnCilinder.Text = "Cilinder";
            this.btnCilinder.UseVisualStyleBackColor = true;
            this.btnCilinder.Click += new System.EventHandler(this.btnCilinder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 162);
            this.Controls.Add(this.btnCilinder);
            this.Controls.Add(this.btnDieren);
            this.Controls.Add(this.btnRekening);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRekening;
        private System.Windows.Forms.Button btnDieren;
        private System.Windows.Forms.Button btnCilinder;
    }
}