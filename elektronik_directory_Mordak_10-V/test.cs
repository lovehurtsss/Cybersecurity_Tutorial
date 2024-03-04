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
    public partial class test : Form
    {
        static quest questik = new quest();
        static Form3 shifr = new Form3();
        public test()
        {
            InitializeComponent();
            AddOwnedForm(questik);
            AddOwnedForm(shifr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void test_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            questik.StartPosition = FormStartPosition.CenterScreen;
            questik.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            shifr.StartPosition = FormStartPosition.CenterScreen;
            shifr.Show();
            Hide();
        }
    }
}
