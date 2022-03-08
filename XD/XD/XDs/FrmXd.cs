using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnXD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EkisDe", "XD", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asi no se escribe pendejo", "Xd", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asi tampoco", "XD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puedo ver que te llamas Jhon", "XD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
