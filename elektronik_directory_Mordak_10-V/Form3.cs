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
    public partial class Form3 : Form
    {
        string path = Application.StartupPath;
        int n, Count, nMain;
        static test main_menu = new test();
        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

        string[] codeMorse = new string[] { "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−" };

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string text;
                text = textBox1.Text;
                var cipher = new CaesarCipher();
                var message = text;
                var secretKey = int.Parse(textBox2.Text);
                var encryptedText = cipher.Encrypt(message, secretKey);
                listBox1.Items.Add("Зашифроване повідомлення:");
                listBox1.Items.Add(encryptedText);
            }
            if (checkBox2.Checked)
            {
                string input = textBox1.Text;
                input = input.ToUpper();
                string output = "";
                int index;
                foreach (char c in input)
                {
                    if (c != ' ')
                    {
                        index = Array.IndexOf(characters, c);
                        output += codeMorse[index] + " ";
                    }
                }
                output = output.Remove(output.Length - 1);
                listBox1.Items.Add("Зашифроване повідомлення:");
                listBox1.Items.Add(output);
            }
            if (checkBox3.Checked)
            {
                //передаем в конструктор класса буквы русского алфавита
                var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
                var inputText = textBox1.Text.ToUpper();

                var password = textBox2.Text.ToUpper();
                var encryptedText = cipher.Encrypt(inputText, password);
                listBox1.Items.Add("Зашифроване повідомлення:");
                listBox1.Items.Add(encryptedText);
            }
            if (checkBox4.Checked)
            {
                string text;
                text = textBox1.Text;
                var cipher = new CaesarCipher();
                var message = text;
                var secretKey = int.Parse(textBox4.Text) / int.Parse(textBox3.Text);
                var encryptedText = cipher.Encrypt(message, secretKey);
                listBox1.Items.Add("Зашифроване повідомлення:");
                listBox1.Items.Add(encryptedText);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "3";
            pictureBox1.Load(path + "/cezar.png");
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(path + "/morze.jpg");
            label2.Visible = false;
            textBox2.Visible = false;
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "СТУЛ";
            pictureBox1.Load(path + "/visener.png");
            label2.Visible = true;
            textBox2.Visible = true;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(path + "/public.jpg");
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked)
            {
                string text;
                text = textBox1.Text;
                var cipher = new CaesarCipher();
                var message = text;
                var secretKey = int.Parse(textBox2.Text);
                var encryptedText = cipher.Decrypt(message, secretKey);
                listBox1.Items.Add("Дешифроване повідомлення:");
                listBox1.Items.Add(encryptedText);
            }
            if (checkBox2.Checked)
            {
                string input = textBox1.Text;
                string[] split = input.Split(' ');
                string output = "";
                int index;
                foreach (string s in split)
                {
                    index = Array.IndexOf(codeMorse, s);
                    output += characters[index] + " ";
                }
                output = output.Remove(output.Length - 1);
                listBox1.Items.Add("Дешифроване повідомлення:");
                listBox1.Items.Add(output);
            }
            if (checkBox3.Checked)
            {
                //передаем в конструктор класса буквы русского алфавита
                var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
                var inputText = textBox1.Text.ToUpper();

                var password = textBox2.Text.ToUpper();
                var encryptedText = cipher.Decrypt(inputText, password);
                listBox1.Items.Add("Дешифроване повідомлення:");
                listBox1.Items.Add(encryptedText);
            }
            if (checkBox4.Checked)
            {
                string text;
                text = textBox1.Text;
                var cipher = new CaesarCipher();
                var message = text;
                var secretKey = int.Parse(textBox4.Text) / int.Parse(textBox3.Text);
                var encryptedText = cipher.Decrypt(message, secretKey);
                listBox1.Items.Add("Зашифроване повідомлення:");
                listBox1.Items.Add(encryptedText);
            }
        }

        public Form3()
        {
            InitializeComponent();
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                main_menu.StartPosition = FormStartPosition.CenterScreen;
                main_menu.Show();
                Hide();
            }
        }

        public class VigenereCipher
        {
            const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            readonly string letters;

            public VigenereCipher(string alphabet = null)
            {
                letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
            }

            //генерация повторяющегося пароля
            private string GetRepeatKey(string s, int n)
            {
                var p = s;
                while (p.Length < n)
                {
                    p += p;
                }

                return p.Substring(0, n);
            }

            private string Vigenere(string text, string password, bool encrypting = true)
            {
                var gamma = GetRepeatKey(password, text.Length);
                var retValue = "";
                var q = letters.Length;

                for (int i = 0; i < text.Length; i++)
                {
                    var letterIndex = letters.IndexOf(text[i]);
                    var codeIndex = letters.IndexOf(gamma[i]);
                    if (letterIndex < 0)
                    {
                        //если буква не найдена, добавляем её в исходном виде
                        retValue += text[i].ToString();
                    }
                    else
                    {
                        retValue += letters[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                    }
                }

                return retValue;
            }

            //шифрование текста
            public string Encrypt(string plainMessage, string password)
                => Vigenere(plainMessage, password);

            //дешифрование текста
            public string Decrypt(string encryptedMessage, string password)
                => Vigenere(encryptedMessage, password, false);
        }
        public class CaesarCipher
        {

            const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            private string CodeEncode(string text, int k)
            {

                var fullAlfabet = alfabet + alfabet.ToLower();
                var letterQty = fullAlfabet.Length;
                var retVal = "";
                for (int i = 0; i < text.Length; i++)
                {
                    var c = text[i];
                    var index = fullAlfabet.IndexOf(c);
                    if (index < 0)
                    {

                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = (letterQty + index + k) % letterQty;
                        retVal += fullAlfabet[codeIndex];
                    }
                }

                return retVal;
            }
            //шифрование текста
            public string Encrypt(string plainMessage, int key)
                => CodeEncode(plainMessage, key);

            //дешифрование текста
            public string Decrypt(string encryptedMessage, int key)
                => CodeEncode(encryptedMessage, -key);
        }
    }
}
