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
    public partial class main_menu : Form
    {
        
        public main_menu()
        {
            InitializeComponent();
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st1 = treeView1.SelectedNode.Text;
            int sqq = treeView1.SelectedNode.Index;
            if (st1 == "Вступ")
            {
                webBrowser1.Navigate(path + "\\texts\\вступ.htm");
            }
            if (st1 == "Види порушень")
            {
                webBrowser1.Navigate(path + "\\texts\\Види_порушення_безпеки.htm");
            }
            if (st1 == "Класифікація методів захисту")
            {
                webBrowser1.Navigate(path + "\\texts\\класиф.htm");
            }
            if (st1 == "Антивірусники")
            {
                webBrowser1.Navigate(path + "\\texts\\вирус.htm");
            }
            if (st1 == "Криптографія")
            {
                webBrowser1.Navigate(path + "\\texts\\крипт.htm");
            }
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            webBrowser1.Navigate(path + "\\texts\\вступ.htm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void main_menu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
