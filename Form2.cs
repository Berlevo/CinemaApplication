using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form2 : Form
    {
        private Form3 form3;
        public Form2()
        {
            InitializeComponent();
            form3 = new Form3();
            form3.ButtonWasClicke += new Form3.ClickButton(form3_clicked);
        }
        Boolean a;
        public delegate void ClickButton();
        public event ClickButton ButtonWasClicked;
        Koltuklar koltuk = new Koltuklar();
        Boolean b = false;
        private void Form2_Load(object sender, EventArgs e)
        {
            koltuk.Dolubos = false;
            Label rezerve = new Label();
            rezerve.Location = new Point(10, 9);
            rezerve.Size = new Size(270, 40);
            rezerve.Text = "Rezervasyon Ekranı";
            rezerve.BackColor = Color.Gray;
            rezerve.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            rezerve.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(rezerve);
            
            if(txtAdSoyad.Text != "")
            {
                txtAdSoyad.Clear();
                txtTC.Clear();
                rdbBay.Checked = false;
                rdbBayan.Checked = false;
            }
            if(a == true)
            {
                txtAdSoyad.Text = txtAdSoyad.Text;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(b == true)
            {
                txtAdSoyad.Clear();
                txtTC.Clear();
                rdbBay.Checked = false;
                rdbBayan.Checked = false;
                this.Close();
            }
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btOnay_Click(object sender, EventArgs e)
        {
            a = true;
            ButtonWasClicked();
            this.Close();
        }
        void form3_clicked()
        {
            b = true;
        }
    }
}
