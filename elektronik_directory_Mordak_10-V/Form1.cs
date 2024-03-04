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
    public partial class title : Form
    {
        public versus main = new versus();
        public title()
        {
            InitializeComponent();
            AddOwnedForm(main);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
            Hide();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
            Hide();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            label2.ForeColor = Color.Blue;
            
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            
        }

        private void title_Load(object sender, EventArgs e)
        {

        }
    }
}
