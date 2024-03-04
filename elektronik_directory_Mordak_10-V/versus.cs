using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elektronik_directory_Mordak_10_V
{
    public partial class versus : Form
    {
        static theor theor1 = new theor();
        static test testik = new test();
        public versus()
        {
            InitializeComponent();
            AddOwnedForm(theor1);
            AddOwnedForm(testik);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            theor1.StartPosition = FormStartPosition.CenterScreen;
            theor1.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            testik.StartPosition = FormStartPosition.CenterScreen;
            testik.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void versus_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Yellow;
        }

        private void versus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
