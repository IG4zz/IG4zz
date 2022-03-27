using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace CaesarCipher
{
    public partial class FormWork : Form
    {
        public FormWork()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        bool ValidCharFound(string str)//функция проверки наличия только символовцифр и , в //строке
        {
            bool valid = true;// 
           
                 foreach (char c in str) // искать символ c в строке str
                 {
                    string bfr = c.ToString();
                     if (Regex.IsMatch(bfr, @"[-0-9,]"))
                     {
                       valid = true;//то результат=истина
                     }
                     else
                     {
                    valid = false;//иначе ложь
                    break;
                     }
                 }
                  return valid;
        }
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text != null && textBoxKey.Text != "")
            {
                if (ValidCharFound(textBoxKey.Text))
                {
                    int Key = Convert.ToInt32(textBoxKey.Text); //(Ключ должен быть в пределах значений алфавита)
                    if (Key > -33 && Key < 33)
                    {
                        string Text = Convert.ToString(textBoxDecryptText.Text.ToLower()); // храню фразу, которую буду шифровать
                        string Crypt = ""; // храню результат шифрования
                        string Space = " ";
                        string Comma = ",";
                        string Dot = ".";
                        string Dash = "-";
                        string ExclamationMark = "!";
                        string QuestionMark = "?";
                        string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; // работаю с русским алфавитом
                        for (int i = 0; i < Text.Length; i++) // цикл перебора букв шифруемого слова
                        {
                            for (int j = 0; j < RusAlphabet.Length; j++) // цикл сравнения каждой буквы с алфавитом
                            {
                                if (Text[i] == RusAlphabet[j]) // в случае совпадения, создаю переменную, где храню номер буквы со сдвигом
                                {
                                    int end_position = j + Key; // номер буквы + сдвиг по ключу

                                    while (end_position <= RusAlphabet.Length) // чтобы новая буква не уходила за рамки алфавита
                                    {
                                        end_position += RusAlphabet.Length;
                                    }

                                    while (end_position >= RusAlphabet.Length) // чтобы новая буква не уходила за рамки алфавита
                                    {
                                        end_position -= RusAlphabet.Length;
                                    }

                                    Crypt += RusAlphabet[end_position]; // заношу зашифрованную букву в переменную, для ее хранения
                                }
                            }

                            if (Text[i] == Convert.ToChar(Space))
                            {
                                Crypt += Space;
                            }

                            if (Text[i] == Convert.ToChar(Comma))
                            {
                                Crypt += Comma;
                            }

                            if (Text[i] == Convert.ToChar(Dot))
                            {
                                Crypt += Dot;
                            }

                            if (Text[i] == Convert.ToChar(Dash))
                            {
                                Crypt += Dash;
                            }

                            if (Text[i] == Convert.ToChar(ExclamationMark))
                            {
                                Crypt += ExclamationMark;
                            }

                            if (Text[i] == Convert.ToChar(QuestionMark))
                            {
                                Crypt += QuestionMark;
                            }
                        }

                        textBoxEncryptText.Text = Crypt;
                    }
                    else
                        MessageBox.Show("Некорректное значение ключа шифрования!" +
                           "\nКлюч может принимать значения от -32 до 32", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                    MessageBox.Show("Укажите числовые значения в поле Ключ шифрования!", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Значение Ключа шифрования отсутствует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
           
            FormHelp formHelp = new();
            formHelp.Show();
        }

        void buttonHelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                buttonHelp.Select();
                buttonHelp_Click(buttonHelp, null);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text != null && textBoxKey.Text != "")
            {
                if (ValidCharFound(textBoxKey.Text))
                {
                    int Key = Convert.ToInt32(textBoxKey.Text); //(Ключ должен быть в пределах значений алфавита)
                    if (Key > -33 && Key < 33)
                    {                      
                      string Text = Convert.ToString(textBoxEncryptText.Text.ToLower()); // храню фразу, которую буду шифровать
                      string Crypt = ""; // храню результат шифрования
                      string Space = " ";
                      string Comma = ",";
                      string Dot = ".";
                      string Dash = "-";
                      string ExclamationMark = "!";
                      string QuestionMark = "?";
                      string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; // работаю с русским алфавитом

                      for (int i = 0; i < Text.Length; i++) // цикл перебора букв шифруемого слова
                      {
                        for (int j = 0; j < RusAlphabet.Length; j++) // цикл сравнения каждой буквы с алфавитом
                        {
                           if (Text[i] == RusAlphabet[j]) // в случае совпадения, создаю переменную, где храню номер буквы со сдвигом
                           {
                            int end_position = j - Key; // номер буквы + сдвиг по ключу

                                    while (end_position <= RusAlphabet.Length) // чтобы новая буква не уходила за рамки алфавита
                                    { 
                                      end_position += RusAlphabet.Length; 
                                    }
  
                                    while (end_position >= RusAlphabet.Length) // чтобы новая буква не уходила за рамки алфавита
                                    {
                                      end_position -= RusAlphabet.Length; 
                                    }

                              Crypt +=RusAlphabet[end_position]; // заношу зашифрованную букву в переменную, для ее хранения
                           }
                        }

                            if (Text[i] == Convert.ToChar(Space))
                            {
                                Crypt += Space;
                            }

                            if (Text[i] == Convert.ToChar(Comma))
                            {
                                Crypt += Comma;
                            }

                            if (Text[i] == Convert.ToChar(Dot))
                            {
                                Crypt += Dot;
                            }

                            if (Text[i] == Convert.ToChar(Dash))
                            {
                                Crypt += Dash;
                            }

                            if (Text[i] == Convert.ToChar(ExclamationMark))
                            {
                                Crypt += ExclamationMark;
                            }

                            if (Text[i] == Convert.ToChar(QuestionMark))
                            {
                                Crypt += QuestionMark;
                            }
                      }
                      textBoxDecryptText.Text = Crypt;
                    }
                    else
                        MessageBox.Show("Некорректное значение ключа шифрования!" +
                           "\nКлюч может принимать значения от -32 до 32", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Укажите числовые значения в поле Ключ шифрования!", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Значение Ключа шифрования отсутствует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonClearEncryptText_Click(object sender, EventArgs e)
        {
            textBoxEncryptText.Text = "";
        }

        private void buttonClearDecryptText_Click(object sender, EventArgs e)
        {
            textBoxDecryptText.Text = "";
        }

        private void buttonSaveDecryptText_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBoxDecryptText.Text);
        }

        private void buttonSaveEncryptText_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBoxEncryptText.Text);
           
        }

        private void buttonOpenDecryptText_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                textBoxInput.Text = openFileDialog1.FileName;
                textBoxDecryptText.Clear();
                textBoxDecryptText.Text = File.ReadAllText(textBoxInput.Text, Encoding.GetEncoding(65001));
            }
            catch
            {
                MessageBox.Show("Текстовый документ отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenEncryptText_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                textBoxOutput.Text = openFileDialog1.FileName;
                textBoxEncryptText.Clear();
                textBoxEncryptText.Text = File.ReadAllText(textBoxOutput.Text, Encoding.GetEncoding(65001));
            }
            catch
            {
                MessageBox.Show("Текстовый документ отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

