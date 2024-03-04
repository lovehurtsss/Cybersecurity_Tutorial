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
    public partial class theor : Form
    {
        static video vidos = new video();
        static main_menu text = new main_menu();
        public theor()
        {
            InitializeComponent();
            AddOwnedForm(vidos);
            AddOwnedForm(text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            text.StartPosition = FormStartPosition.CenterScreen;
            text.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            vidos.StartPosition = FormStartPosition.CenterScreen;
            vidos.Show();
            Hide();
        }

        private void theor_FormClosing(object sender, FormClosingEventArgs e)
        {
            versus main = new versus();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
                main.StartPosition = FormStartPosition.CenterScreen;
                main.Show();
                Hide();
            }

        }

        private void theor_Load(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }
    }
}
