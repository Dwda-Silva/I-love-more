﻿namespace WindowsFormsApp1
{
    partial class DuzentoaQuinhentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuzentoaQuinhentos));
            this.lblMensagemMenorQueZero2 = new System.Windows.Forms.Label();
            this.lblMensagemMenorQueZero = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensagemMenorQueZero2
            // 
            this.lblMensagemMenorQueZero2.AutoSize = true;
            this.lblMensagemMenorQueZero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagemMenorQueZero2.Location = new System.Drawing.Point(82, 49);
            this.lblMensagemMenorQueZero2.Name = "lblMensagemMenorQueZero2";
            this.lblMensagemMenorQueZero2.Size = new System.Drawing.Size(286, 20);
            this.lblMensagemMenorQueZero2.TabIndex = 8;
            this.lblMensagemMenorQueZero2.Text = "Mas não chega nem perto do quanto ";
            // 
            // lblMensagemMenorQueZero
            // 
            this.lblMensagemMenorQueZero.AutoSize = true;
            this.lblMensagemMenorQueZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagemMenorQueZero.Location = new System.Drawing.Point(82, 29);
            this.lblMensagemMenorQueZero.Name = "lblMensagemMenorQueZero";
            this.lblMensagemMenorQueZero.Size = new System.Drawing.Size(152, 20);
            this.lblMensagemMenorQueZero.TabIndex = 7;
            this.lblMensagemMenorQueZero.Text = "Esste valor está ok";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(157, 108);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 40);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "a sua namorada ama você.";
            // 
            // DuzentoaQuinhentos
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagemMenorQueZero2);
            this.Controls.Add(this.lblMensagemMenorQueZero);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DuzentoaQuinhentos";
            this.Text = "precisa de titulo ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagemMenorQueZero2;
        private System.Windows.Forms.Label lblMensagemMenorQueZero;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
    }
}