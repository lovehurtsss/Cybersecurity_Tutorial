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
    public partial class quest : Form
    {
        int correctAnswer = 0;
        int questionNumber = 1;
        int score = 0;
        int percentage = 0;
        int totalQuestions = 0;
        string path = Application.StartupPath;
        public quest()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 5;
        }
        private void quest_Load(object sender, EventArgs e)
        {

        }
        private void ClickedButton(object sender, EventArgs e)
        {
            
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "Мережні атаки спрямовані на зависання сервісів називаються:";
                    pictureBox1.Load(path + "/dos.jpg");
                    button1.Text = "Спам";
                    button2.Text = "DOS атака";
                    button3.Text = "Нюкання";
                    button4.Text = "Сніффінг(винюхування)";
                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestion.Text = "Як працюють програми ревізори";
                    pictureBox1.Load(path + "/revizor.jpg");
                    button1.Text = "запам'ятовують початковий стан програм";
                    button2.Text = "знаходять заражені вірусами файли й «лікують» їх";
                    button3.Text = "виявляють підозрілі дії при роботі комп'ютера";
                    button4.Text = "здійснюють пошук сигнатур вірусів";
                    correctAnswer = 1;
                    break;
                case 3:
                    pictureBox1.Load(path + "/zhuk.jpg");
                    lblQuestion.Text = "Що характеризує установку мікрофона в комп'ютері з метою перехоплення розмов обслуговуючого персоналу?";
                    button1.Text = "Жучок";
                    button2.Text = "Троян";
                    button3.Text = "QF";
                    button4.Text = "Epic Games";
                    correctAnswer = 1;
                    break;
                case 4:
                    lblQuestion.Text = "Для чого ця таблиця?";
                    pictureBox1.Load(path + "/visener.png");
                    button1.Text = "Шифр Цезаря";
                    button2.Text = "Азбука Морзе";
                    button3.Text = "Публічний ключ";
                    button4.Text = "Шифр Віженера";
                    correctAnswer = 4;
                    break;
                case 5:
                    pictureBox1.Load(path + "/virus.jpg");
                    lblQuestion.Text = "Комп'ютерний вірус це";
                    button1.Text = "чинні закони, укази та інші нормативні акти, які регламентують правила користування інформацією";
                    button2.Text = "програма для підвищення температури процессора";
                    button3.Text = "протокол запобігання руйнівним наслідкам";
                    button4.Text = "спеціально написана невелика за розмірами програма, яка може створювати свої копії";
                    correctAnswer = 4;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                MessageBox.Show("Самоперевірка пройшла успішно" + Environment.NewLine +
                                "Ти відповів на " + score + " з 5 питань, МОЛОДЕЦЬ" + Environment.NewLine +
                                "Процент правильних відповідей " + percentage + "%" + Environment.NewLine +
                                "Нажми ОК, щоб пройти щераз");
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                MessageBox.Show("Самоперевірка пройшла успішно" + Environment.NewLine +
                                "Ти відповів на" + score + "з 5 питань, МОЛОДЕЦЬ" + Environment.NewLine +
                                "Процент правильних відповідей" + percentage + " %" + Environment.NewLine +
                                "Нажми ОК, щоб пройти щераз");
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                MessageBox.Show("Самоперевірка пройшла успішно" + Environment.NewLine +
                                "Ти відповів на" + score + "з 5 питань, МОЛОДЕЦЬ" + Environment.NewLine +
                                "Процент правильних відповідей" + percentage + " %" + Environment.NewLine +
                                "Нажми ОК, щоб пройти щераз");
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                MessageBox.Show("Самоперевірка пройшла успішно" + Environment.NewLine +
                                "Ти відповів на" + score + "з 5 питань, МОЛОДЕЦЬ" + Environment.NewLine +
                                "Процент правильних відповідей" + percentage + " %" + Environment.NewLine +
                                "Нажми ОК, щоб пройти щераз");
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
    }
}
