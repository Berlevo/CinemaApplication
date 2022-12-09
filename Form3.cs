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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public delegate void ClickButton();
        public event ClickButton ButtonWasClicke;

        private void btnEvet_Click(object sender, EventArgs e)
        {

            ButtonWasClicke();
            this.Close();
        }

        private void btnHayır_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
