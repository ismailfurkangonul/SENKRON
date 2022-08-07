namespace ASENKRON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnBirlestir = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(298, 149);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 0;
            this.btnCikar.Text = "Cikar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(403, 149);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(75, 23);
            this.btnBol.TabIndex = 1;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnBirlestir
            // 
            this.btnBirlestir.Location = new System.Drawing.Point(349, 178);
            this.btnBirlestir.Name = "btnBirlestir";
            this.btnBirlestir.Size = new System.Drawing.Size(75, 23);
            this.btnBirlestir.TabIndex = 2;
            this.btnBirlestir.Text = "Birleştir";
            this.btnBirlestir.UseVisualStyleBackColor = true;
            this.btnBirlestir.Click += new System.EventHandler(this.btnBirlestir_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(335, 37);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 23);
            this.txtNumber1.TabIndex = 3;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(335, 76);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 23);
            this.txtNumber2.TabIndex = 4;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(335, 120);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(100, 23);
            this.txtNumber3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnBirlestir);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCikar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnBirlestir;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
    }
}
