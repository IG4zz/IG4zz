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

        /// <summary>
        /// Функция проверки наличия только символов и цифр в строке
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        bool ValidCharFound(string str)//
        {
            bool valid = true;// 
           
                 foreach (char c in str)    //  искать символ c в строке str
                 {
                    string Temp = c.ToString();
                     if (Regex.IsMatch(Temp, @"[-0-9,]"))
                     {
                       valid = true;    //  то результат=истина
                     }
                     else
                     {
                    valid = false;  //  иначе ложь
                    break;
                     }
                 }
                  return valid;
        }

        /// <summary>
        /// Нажатие кнопки Зашифровать
        /// Шифрует текст из поля Дешифрованный текст
        /// и переносит полученный текст в поле Зашифрованный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text != null && textBoxKey.Text != "")
            {
                if (ValidCharFound(textBoxKey.Text))
                {
                    int Key = Convert.ToInt32(textBoxKey.Text); //  (Ключ должен быть в пределах значений алфавита)
                    if (Key > -33 && Key < 33)
                    {
                        string Text = Convert.ToString(textBoxDecryptText.Text.ToLower()); //   храню фразу, которую буду шифровать
                        string Crypt = ""; //   храню результат шифрования
                        string Space = " ";
                        string Comma = ",";
                        string Dot = ".";
                        string Dash = "-";
                        string ExclamationMark = "!";
                        string QuestionMark = "?";
                        string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; //  русский алфавит

                        //    цикл перебора букв шифруемого слова

                        for (int i = 0; i < Text.Length; i++) 
                        {
                            // цикл сравнения каждой буквы с алфавитом

                            for (int j = 0; j < RusAlphabet.Length; j++) 
                            {
                                if (Text[i] == RusAlphabet[j]) //   в случае совпадения, создаю переменную, где храню номер буквы со сдвигом
                                {
                                    int EndPosition = j + Key; //  номер буквы + сдвиг по ключу

                                    while (EndPosition <= RusAlphabet.Length) //   проверка того, чтобы новая буква не уходила за рамки алфавита
                                    {
                                        EndPosition += RusAlphabet.Length;
                                    }

                                    while (EndPosition >= RusAlphabet.Length) // проверка того, чтобы новая буква не уходила за рамки алфавита
                                    {
                                        EndPosition -= RusAlphabet.Length;
                                    }

                                    Crypt += RusAlphabet[EndPosition]; // заношу зашифрованную букву в переменную, для ее хранения
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

        /// <summary>
        /// Нажатие кнопки Выход
        /// Производит выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Нажатие кнопки Справка
        /// Открывает окно со справочной информацией
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
           
            FormHelp formHelp = new();
            formHelp.Show();
        }

        /// <summary>
        /// Нажатие клавиши F1
        /// Открывает окно со справочной информацией
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormWork_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                buttonHelp.PerformClick();
            }
        }

        /// <summary>
        /// Нажатие кнопки Дешифровать
        /// Дешифрует текст из поля Зашифрованный текст
        /// и переносит полученный текст в поле Дешифрованный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                      string RusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; // русский алфавит

                      // цикл перебора букв шифруемого слова

                       for (int i = 0; i < Text.Length; i++) 
                       {
                            // цикл сравнения каждой буквы с алфавитом

                            for (int j = 0; j < RusAlphabet.Length; j++) 
                            {

                                if (Text[i] == RusAlphabet[j]) // в случае совпадения, создаю переменную, где храню номер буквы со сдвигом
                                {
                                    int EndPosition = j - Key; // номер буквы + сдвиг по ключу

                                    while (EndPosition <= RusAlphabet.Length) // чтобы новая буква не уходила за рамки алфавита
                                    {
                                        EndPosition += RusAlphabet.Length; 
                                    }
  
                                    while (EndPosition >= RusAlphabet.Length) // чтобы новая буква не уходила за рамки алфавита
                                    {
                                        EndPosition -= RusAlphabet.Length; 
                                    }

                                    Crypt +=RusAlphabet[EndPosition]; // заношу зашифрованную букву в переменную, для ее хранения
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

        /// <summary>
        /// Нажатие кнопки Очистить поле(Дешифрованный текст)
        /// Очищает поле Дешифрованный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearEncryptText_Click(object sender, EventArgs e)
        {
            textBoxEncryptText.Text = "";
        }

        /// <summary>
        /// Нажатие кнопки Очистить поле(Зашифрованный текст)
        /// Очищает поле Зашифрованный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearDecryptText_Click(object sender, EventArgs e)
        {
            textBoxDecryptText.Text = "";
        }

        /// <summary>
        /// Нажатие кнопки Сохранить(Дешифрованный текст)
        /// Сохраняет текст из поля Дешифрованный текст в текстовый файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveDecryptText_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBoxDecryptText.Text);
        }

        /// <summary>
        /// Нажатие кнопки Сохранить(Зашифрованный текст)
        /// Сохраняет текст из поля Зашифрованный текст в текстовый файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveEncryptText_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBoxEncryptText.Text);
           
        }

        /// <summary>
        /// Нажатие кнопки Открыть(Дешифрованный текст)
        /// Открывает диалоговое окно выбора текстового файла
        /// и переносит текст из него в поле Дешифрованный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenDecryptText_Click(object sender, EventArgs e)
        {
            try     //  если программа не сможет получить файл
            {
                openFileDialog1.ShowDialog();
                textBoxInput.Text = openFileDialog1.FileName;
                textBoxDecryptText.Clear();
                textBoxDecryptText.Text = File.ReadAllText(textBoxInput.Text, Encoding.GetEncoding(65001));
            }
            catch (Exception)   //  то выведет сообщение на экран
            {
                MessageBox.Show("Текстовый документ отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие кнопки Открыть(Зашифрованный текст)
        /// Открывает диалоговое окно выбора текстового файла
        /// и переносит текст из него в поле Зашифрованный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenEncryptText_Click(object sender, EventArgs e)
        {
            try     //  если программа не сможет получить файл
            {
                openFileDialog1.ShowDialog();
                textBoxOutput.Text = openFileDialog1.FileName;
                textBoxEncryptText.Clear();
                textBoxEncryptText.Text = File.ReadAllText(textBoxOutput.Text, Encoding.GetEncoding(65001));
            }
            catch (Exception)   //  то выведет сообщение на экран
            {
                MessageBox.Show("Текстовый документ отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Клик по основному окну
        /// Снимает фокус со всех элементов управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormWork_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}

