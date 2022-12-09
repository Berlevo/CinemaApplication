namespace Cinema
{
    partial class Form2
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.rdbBay = new System.Windows.Forms.RadioButton();
            this.rdbBayan = new System.Windows.Forms.RadioButton();
            this.btOnay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdSoyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(68, 74);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(142, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(68, 100);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(142, 20);
            this.txtTC.TabIndex = 3;
            this.txtTC.UseSystemPasswordChar = true;
            // 
            // rdbBay
            // 
            this.rdbBay.AutoSize = true;
            this.rdbBay.Location = new System.Drawing.Point(216, 77);
            this.rdbBay.Name = "rdbBay";
            this.rdbBay.Size = new System.Drawing.Size(43, 17);
            this.rdbBay.TabIndex = 4;
            this.rdbBay.TabStop = true;
            this.rdbBay.Text = "Bay";
            this.rdbBay.UseVisualStyleBackColor = true;
            // 
            // rdbBayan
            // 
            this.rdbBayan.AutoSize = true;
            this.rdbBayan.Location = new System.Drawing.Point(216, 100);
            this.rdbBayan.Name = "rdbBayan";
            this.rdbBayan.Size = new System.Drawing.Size(55, 17);
            this.rdbBayan.TabIndex = 5;
            this.rdbBayan.TabStop = true;
            this.rdbBayan.Text = "Bayan";
            this.rdbBayan.UseVisualStyleBackColor = true;
            // 
            // btOnay
            // 
            this.btOnay.Location = new System.Drawing.Point(226, 126);
            this.btOnay.Name = "btOnay";
            this.btOnay.Size = new System.Drawing.Size(53, 23);
            this.btOnay.TabIndex = 6;
            this.btOnay.Text = "Onayla";
            this.btOnay.UseVisualStyleBackColor = true;
            this.btOnay.Click += new System.EventHandler(this.btOnay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 161);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btOnay);
            this.Controls.Add(this.rdbBayan);
            this.Controls.Add(this.rdbBay);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.RadioButton rdbBay;
        private System.Windows.Forms.RadioButton rdbBayan;
        private System.Windows.Forms.Button btOnay;
        private System.Windows.Forms.Button button2;
    }
}