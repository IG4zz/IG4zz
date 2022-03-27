using System;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие кнопки Закрыть
        /// Закрывает окно со справочной информацией
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
