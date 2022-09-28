namespace CheckBox_Kontrola
{
    partial class Form1
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
            this.ckbDorucak = new System.Windows.Forms.CheckBox();
            this.ckbRucak = new System.Windows.Forms.CheckBox();
            this.ckbVecera = new System.Windows.Forms.CheckBox();
            this.txtOdabir = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.ckbSakrij = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckbDorucak
            // 
            this.ckbDorucak.AutoSize = true;
            this.ckbDorucak.Location = new System.Drawing.Point(22, 27);
            this.ckbDorucak.Name = "ckbDorucak";
            this.ckbDorucak.Size = new System.Drawing.Size(67, 17);
            this.ckbDorucak.TabIndex = 0;
            this.ckbDorucak.Text = "Dorucak";
            this.ckbDorucak.UseVisualStyleBackColor = true;
            // 
            // ckbRucak
            // 
            this.ckbRucak.AutoSize = true;
            this.ckbRucak.Location = new System.Drawing.Point(22, 51);
            this.ckbRucak.Name = "ckbRucak";
            this.ckbRucak.Size = new System.Drawing.Size(58, 17);
            this.ckbRucak.TabIndex = 1;
            this.ckbRucak.Text = "Rucak";
            this.ckbRucak.UseVisualStyleBackColor = true;
            this.ckbRucak.CheckedChanged += new System.EventHandler(this.ckbRucak_CheckedChanged);
            // 
            // ckbVecera
            // 
            this.ckbVecera.AutoSize = true;
            this.ckbVecera.Location = new System.Drawing.Point(22, 75);
            this.ckbVecera.Name = "ckbVecera";
            this.ckbVecera.Size = new System.Drawing.Size(60, 17);
            this.ckbVecera.TabIndex = 2;
            this.ckbVecera.Text = "Vecera";
            this.ckbVecera.UseVisualStyleBackColor = true;
            // 
            // txtOdabir
            // 
            this.txtOdabir.Location = new System.Drawing.Point(152, 27);
            this.txtOdabir.Multiline = true;
            this.txtOdabir.Name = "txtOdabir";
            this.txtOdabir.ReadOnly = true;
            this.txtOdabir.Size = new System.Drawing.Size(158, 65);
            this.txtOdabir.TabIndex = 3;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(22, 122);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(126, 23);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // ckbSakrij
            // 
            this.ckbSakrij.AutoSize = true;
            this.ckbSakrij.Location = new System.Drawing.Point(177, 127);
            this.ckbSakrij.Name = "ckbSakrij";
            this.ckbSakrij.Size = new System.Drawing.Size(99, 17);
            this.ckbSakrij.TabIndex = 5;
            this.ckbSakrij.Text = "Sakrij narudžbu";
            this.ckbSakrij.UseVisualStyleBackColor = true;
            this.ckbSakrij.CheckedChanged += new System.EventHandler(this.ckbSakrij_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbSakrij);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtOdabir);
            this.Controls.Add(this.ckbVecera);
            this.Controls.Add(this.ckbRucak);
            this.Controls.Add(this.ckbDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbDorucak;
        private System.Windows.Forms.CheckBox ckbRucak;
        private System.Windows.Forms.CheckBox ckbVecera;
        private System.Windows.Forms.TextBox txtOdabir;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.CheckBox ckbSakrij;
    }
}

