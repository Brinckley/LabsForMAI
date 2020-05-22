using MatrixCode.Classes.NewTry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCode
{
    public partial class Form1 : Form
    {
        public int[,] bornMatrix = new int[3, 7];
        public string rlMistake = "";
        public string rlBmatrix = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_excecute_Click(object sender, EventArgs e)
        {
            int word = 0;
            textAnswer.Text = "";
            if (!radioCodeIn.Checked && !radioCodeOut.Checked)
            {
                MessageBox.Show("Функция не выбрана!");
                return;
            }
            try
            {
                word = Int32.Parse(TextMessage.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно введено сообщение!");
                return;
            }
            try
            {//botnMatrix - пораждающая матрица
                //заполнение
                bornMatrix[0, 0] = Int32.Parse(matrixText11.Text);
                bornMatrix[0, 1] = Int32.Parse(matrixText12.Text);
                bornMatrix[0, 2] = Int32.Parse(matrixText13.Text);
                bornMatrix[0, 3] = Int32.Parse(matrixText14.Text);
                bornMatrix[0, 4] = Int32.Parse(matrixText15.Text);
                bornMatrix[0, 5] = Int32.Parse(matrixText16.Text);
                bornMatrix[1, 0] = Int32.Parse(matrixText21.Text);
                bornMatrix[1, 1] = Int32.Parse(matrixText22.Text);
                bornMatrix[1, 2] = Int32.Parse(matrixText23.Text);
                bornMatrix[1, 3] = Int32.Parse(matrixText24.Text);
                bornMatrix[1, 4] = Int32.Parse(matrixText25.Text);
                bornMatrix[1, 5] = Int32.Parse(matrixText26.Text);
                bornMatrix[2, 0] = Int32.Parse(matrixText31.Text);
                bornMatrix[2, 1] = Int32.Parse(matrixText32.Text);
                bornMatrix[2, 2] = Int32.Parse(matrixText33.Text);
                bornMatrix[2, 3] = Int32.Parse(matrixText34.Text);
                bornMatrix[2, 4] = Int32.Parse(matrixText35.Text);
                bornMatrix[2, 5] = Int32.Parse(matrixText36.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно введена матрица!");
                return;
            }
            if (radioCodeIn.Checked)
            {
                richTextBox1.Text = "";
                if (TextMessage.Text.Length != 3)
                {
                    MessageBox.Show("Неверно введено сообщение!");
                    return;
                }
                labelMistakeNumber.Visible = false;
                int[] wordArray = MatrixWorkerClass.wordToArray(word, 3);
                int[] answer = MatrixWorkerClass.codeInto(ref bornMatrix, wordArray);
                for (int i = 0; i < answer.Length; ++i)
                {
                    textAnswer.Text = textAnswer.Text + " " + Convert.ToString(answer[i]);
                }
                return;
            }
            else
            {
                if (radioCodeOut.Checked)
                {
                    richTextBox1.Text = "";
                    if (TextMessage.Text.Length != 6) {
                        MessageBox.Show("Неверно введено сообщение!");
                        return;
                    }
                    labelMistakeNumber.Visible = true;
                    string[] bmatrix = new string[8];
                    string sword = "";
                    int ssum = 0;
                    for (int i = 0; i < 8; ++i)
                    {
                        sword = Convert.ToString(i, 2);
                        if (i < 2)
                        {
                            sword = "00" + sword;
                        }
                        if (i > 1 && i < 4)
                        {
                            sword = "0" + sword;
                        }
                        for (int j = 0; j < bornMatrix.GetLength(1) - 1; ++j)
                        {
                            ssum = 0;
                            for (int k = 0; k < bornMatrix.GetLength(0); ++k)
                            {
                                if (sword[k] == '1')
                                {
                                    ssum += bornMatrix[k, j] * 1;
                                }
                                else
                                {
                                    ssum += bornMatrix[k, j] * 0;
                                }
                            }
                            bmatrix[i] += Convert.ToString(ssum % 2);

                        }
                    }
                    string[,] vs = new string[Mistake.n.Length, bmatrix.Length];
                    string lag = "";
                    for (int i = 0; i < Mistake.n.Length; ++i)
                    {
                        richTextBox1.Text += Mistake.ns[i] + "  |  ";
                        for (int j = 1; j < bmatrix.Length; ++j)
                        {
                            lag = bmatrix[j];
                            if (Mistake.n[i] == 6)
                            {
                                if (lag[0] == '1')
                                {
                                    lag = lag.Remove(0, 1).Insert(0, "0");
                                }
                                else
                                {
                                    lag = lag.Remove(0, 1).Insert(0, "1");
                                }
                                if (lag[1] == '1')
                                {
                                    lag = lag.Remove(1, 1).Insert(1, "0");
                                }
                                else
                                {
                                    lag = lag.Remove(1, 1).Insert(1, "1");
                                }
                            }
                            else
                            {
                                if (Mistake.n[i] != -1)
                                {
                                    if (lag[5 - Mistake.n[i]] == '1')
                                    {
                                        lag = lag.Remove(5 - Mistake.n[i], 1).Insert(5 - Mistake.n[i], "0");
                                    }
                                    else
                                    {
                                        lag = lag.Remove(5 - Mistake.n[i], 1).Insert(5 - Mistake.n[i], "1");
                                    }
                                }
                            }
                            richTextBox1.Text += lag + "  |  ";
                            vs[i, j] = lag;
                        }
                        richTextBox1.Text += "\r\n";
                    }
                    string tmp = "";
                    for (int i = 0; i < vs.GetLength(0); ++i)
                    {
                        textAnswer.Text += "!";
                        for (int j = 0; j < vs.GetLength(1); ++j)
                        {
                            if (TextMessage.Text == vs[i, j])
                            {
                                tmp = bmatrix[j];
                                if (6 - i + 1 == 0)
                                {
                                    labelMistakeNumber.Text = "Разряд с ошибкой - 1 и 0";
                                }
                                else
                                {
                                    if (6 - i + 1 == 7)
                                    {
                                        labelMistakeNumber.Text = "Ошибки нет";
                                    }
                                    else
                                    {
                                        labelMistakeNumber.Text = "Разряд с ошибкой - " + Convert.ToString(6 - i + 1);
                                    }
                                }
                                rlMistake = Mistake.ns[i];
                                rlBmatrix = bmatrix[j];
                            }
                        }
                    }
                    for (int i = 0; i < bmatrix.Length; ++i)
                    {
                        if (bmatrix[i] == tmp)
                        {
                            string answer = "";
                            while (i > 0)
                            {
                                answer += Convert.ToString(i % 2);
                                i /= 2;
                            }
                            if (answer.Length < 2)
                            {
                                answer = answer + "00";
                            }
                            if (answer.Length > 1 && answer.Length < 3)
                            {
                                answer = answer + "0";
                            }
                            textAnswer.Text = Convert.ToString(answer);
                            break;
                        }
                    }
                    return;
                }

            }

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            radioCodeIn.Checked = false;
            radioCodeOut.Checked = false;
            labelMistakeNumber.Visible = false;
            TextMessage.Text = "";
            textAnswer.Text = "";
            matrixText11.Text = "";
            matrixText12.Text = "";
            matrixText13.Text = "";
            matrixText14.Text = "";
            matrixText15.Text = "";
            matrixText16.Text = "";
            matrixText21.Text = "";
            matrixText22.Text = "";
            matrixText23.Text = "";
            matrixText24.Text = "";
            matrixText25.Text = "";
            matrixText26.Text = "";
            matrixText31.Text = "";
            matrixText32.Text = "";
            matrixText33.Text = "";
            matrixText34.Text = "";
            matrixText35.Text = "";
            matrixText36.Text = "";
            richTextBox1.Text = "";
        }

        private struct WordColor
        {
            public string word;
            public System.Drawing.Color color;
        }
        private System.Collections.Generic.List<WordColor> wordColors = new System.Collections.Generic.List<WordColor>();
        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (richTextBox1.Text.Contains(TextMessage.Text))
                {
                    int index = -1;
                    int selectStart = richTextBox1.SelectionStart;

                    while ((index = richTextBox1.Text.IndexOf(TextMessage.Text, (index + 1))) != -1)
                    {
                        richTextBox1.Select((index + 0), 6);
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.Select(selectStart, 0);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                }
                if (richTextBox1.Text.Contains(rlMistake))
                {
                    int index = -1;
                    int selectStart = richTextBox1.SelectionStart;

                    while ((index = richTextBox1.Text.IndexOf(rlMistake, (index + 1))) != -1)
                    {
                        richTextBox1.Select((index + 0), 6);
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.Select(selectStart, 0);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                }
                if (richTextBox1.Text.Contains(rlBmatrix))
                {
                    int index = -1;
                    int selectStart = richTextBox1.SelectionStart;

                    while ((index = richTextBox1.Text.IndexOf(rlBmatrix, (index + 1))) != -1)
                    {
                        richTextBox1.Select((index + 0), 6);
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.Select(selectStart, 0);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                }
            }
            else {
                MessageBox.Show("Нет таблицы смежных классов");
            }
        }
    }
}