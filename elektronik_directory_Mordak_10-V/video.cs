using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace elektronik_directory_Mordak_10_V
{
    public partial class video : Form
    {
        string path = Application.StartupPath;
        bool bOol = false;
        public video()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = (string)listBox1.Items[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            string st;
            int k;
            listBox1.Items.Clear();
            try
            {
                string[] dirs = Directory.GetFiles(path + "\\Player\\videoi");
                foreach (string fname in dirs)
                {
                    listBox1.Items.Add(fname);
                    int dl = path.Length;
                    st = fname.Remove(0, dl);
                    k = st.LastIndexOf("\\");
                    st = st.Remove(0, k + 1);
                    k = st.IndexOf(".");
                    st = st.Substring(0, k);

                }
            }
            catch (Exception ee)
            {

            }
            bOol = true;

            axWindowsMediaPlayer1.BringToFront();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void video_FormClosing(object sender, FormClosingEventArgs e)
        {
            theor main = new theor();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
                main.StartPosition = FormStartPosition.CenterScreen;
                main.Show();
                Hide();
            }
        }
    }
}
