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
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.ButtonWasClicked += new Form2.ClickButton(form2_clicked);
        }
        GroupBox koltuk;
        Label lblad;
        Button koltuks;
        int i = 0;
        Boolean a = true;
        Image boss = Image.FromFile("blue.png");
        Image dolus = Image.FromFile("red.png");
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Button seat;
            Button seat1;

            #region label
            lblad = new Label();
            lblad.Location = new Point(10, 9);
            lblad.Size = new Size(460, 40);
            lblad.Text = "SİNEMA OTOMASYONU";
            lblad.Name = "Başlık";
            lblad.BackColor = Color.Gray;
            lblad.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            lblad.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblad);

            Label bos = new Label();
            bos.Location = new Point(410, 410);
            bos.Size = new Size(boss.Width, boss.Height);
            bos.Image = boss;
            this.Controls.Add(bos);

            Label dolu = new Label();
            dolu.Location = new Point(300, 410);
            dolu.Size = new Size(dolus.Width, dolus.Height);
            dolu.Image = dolus;
            this.Controls.Add(dolu);
            #endregion

            #region Koltuk
            koltuk = new GroupBox();
            koltuk.Location = new Point(12, 76);
            koltuk.Size = new Size(500, 328);
            koltuk.Text = "Koltuklar";
            koltuk.Name = "koltuk";
            koltuk.Visible = true;

            this.Controls.Add(koltuk);

            int y = 20;
            int y1 = 55;
            for (int i = 0; i < 3; i++)
            {
                int x = 100;
                int x1 = 30;
                for (int k = 0; k < 8; k++)
                {
                    seat = addButton(x, y);
                    x += 35;
                    koltuk.Controls.Add(seat);
                }
                
                for(int t = 0; t < 12; t++)
                {
                    seat1 = addButton(x1, y1);
                    x1 += 35;
                    koltuk.Controls.Add(seat1);
                }
                y = 35 + y1;
                y1 = 35 + y;
            }
            

            #endregion
        }

        
        Button addButton(int start, int end)
        {
            Image bos = Image.FromFile("blue.png");
            koltuks = new Button();
            koltuks.Location = new Point(start, end);
            koltuks.Size = new Size(bos.Width, bos.Height);
            koltuks.Name = i.ToString();
            koltuks.Image = bos;

            koltuks.Click += new EventHandler(s1_Click);
           
            i++;
            return koltuks;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void s1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Koltuklar koltuk = new Koltuklar();

            koltuk = (Koltuklar) button.Tag;
            
            form2.ShowDialog();

            button.Tag = koltuk;
            if(a == false)
            {
                button.Image = dolus;
                a = true;
            }
            else
            {
                button.Image = boss;
            }
            Refresh();
            
        }
        void form2_clicked()
        {
            a = false;
        }
    }
}
