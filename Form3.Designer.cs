﻿namespace Cinema
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvet = new System.Windows.Forms.Button();
            this.btnHayır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekrar silmek istiyor musunuz?";
            // 
            // btnEvet
            // 
            this.btnEvet.Location = new System.Drawing.Point(128, 40);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(75, 23);
            this.btnEvet.TabIndex = 1;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = true;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnHayır
            // 
            this.btnHayır.Location = new System.Drawing.Point(47, 40);
            this.btnHayır.Name = "btnHayır";
            this.btnHayır.Size = new System.Drawing.Size(75, 23);
            this.btnHayır.TabIndex = 2;
            this.btnHayır.Text = "Hayır";
            this.btnHayır.UseVisualStyleBackColor = true;
            this.btnHayır.Click += new System.EventHandler(this.btnHayır_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 87);
            this.Controls.Add(this.btnHayır);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Button btnHayır;
    }
}