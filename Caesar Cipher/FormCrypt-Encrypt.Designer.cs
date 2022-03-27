
namespace CaesarCipher
{
    partial class FormWork
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWork));
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxDecryptText = new System.Windows.Forms.TextBox();
            this.textBoxEncryptText = new System.Windows.Forms.TextBox();
            this.labelDecryptText = new System.Windows.Forms.Label();
            this.labelEncryptText = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSaveEncryptText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonClearEncryptText = new System.Windows.Forms.Button();
            this.buttonClearDecryptText = new System.Windows.Forms.Button();
            this.buttonSaveDecryptText = new System.Windows.Forms.Button();
            this.buttonOpenDecryptText = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonOpenEncryptText = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(339, 138);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(101, 23);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(339, 177);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(101, 23);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "Дешифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(360, 93);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(56, 23);
            this.textBoxKey.TabIndex = 2;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(314, 65);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(159, 15);
            this.labelKey.TabIndex = 3;
            this.labelKey.Text = "Введите ключ шифрования";
            // 
            // textBoxDecryptText
            // 
            this.textBoxDecryptText.Location = new System.Drawing.Point(4, 65);
            this.textBoxDecryptText.Multiline = true;
            this.textBoxDecryptText.Name = "textBoxDecryptText";
            this.textBoxDecryptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDecryptText.Size = new System.Drawing.Size(292, 168);
            this.textBoxDecryptText.TabIndex = 4;
            // 
            // textBoxEncryptText
            // 
            this.textBoxEncryptText.Location = new System.Drawing.Point(490, 62);
            this.textBoxEncryptText.Multiline = true;
            this.textBoxEncryptText.Name = "textBoxEncryptText";
            this.textBoxEncryptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEncryptText.Size = new System.Drawing.Size(298, 171);
            this.textBoxEncryptText.TabIndex = 5;
            // 
            // labelDecryptText
            // 
            this.labelDecryptText.AutoSize = true;
            this.labelDecryptText.Location = new System.Drawing.Point(73, 38);
            this.labelDecryptText.Name = "labelDecryptText";
            this.labelDecryptText.Size = new System.Drawing.Size(135, 15);
            this.labelDecryptText.TabIndex = 6;
            this.labelDecryptText.Text = "Дешифрованный текст";
            // 
            // labelEncryptText
            // 
            this.labelEncryptText.AutoSize = true;
            this.labelEncryptText.Location = new System.Drawing.Point(571, 38);
            this.labelEncryptText.Name = "labelEncryptText";
            this.labelEncryptText.Size = new System.Drawing.Size(134, 15);
            this.labelEncryptText.TabIndex = 7;
            this.labelEncryptText.Text = "Зашифрованный текст";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(713, 415);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(12, 415);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonHelp_KeyDown);
            // 
            // buttonSaveEncryptText
            // 
            this.buttonSaveEncryptText.Location = new System.Drawing.Point(571, 253);
            this.buttonSaveEncryptText.Name = "buttonSaveEncryptText";
            this.buttonSaveEncryptText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEncryptText.TabIndex = 10;
            this.buttonSaveEncryptText.Text = "Сохранить";
            this.buttonSaveEncryptText.UseVisualStyleBackColor = true;
            this.buttonSaveEncryptText.Click += new System.EventHandler(this.buttonSaveEncryptText_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Шифр";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // buttonClearEncryptText
            // 
            this.buttonClearEncryptText.Location = new System.Drawing.Point(652, 253);
            this.buttonClearEncryptText.Name = "buttonClearEncryptText";
            this.buttonClearEncryptText.Size = new System.Drawing.Size(107, 23);
            this.buttonClearEncryptText.TabIndex = 11;
            this.buttonClearEncryptText.Text = "Очистить поле";
            this.buttonClearEncryptText.UseVisualStyleBackColor = true;
            this.buttonClearEncryptText.Click += new System.EventHandler(this.buttonClearEncryptText_Click);
            // 
            // buttonClearDecryptText
            // 
            this.buttonClearDecryptText.Location = new System.Drawing.Point(166, 253);
            this.buttonClearDecryptText.Name = "buttonClearDecryptText";
            this.buttonClearDecryptText.Size = new System.Drawing.Size(107, 23);
            this.buttonClearDecryptText.TabIndex = 12;
            this.buttonClearDecryptText.Text = "Очистить поле";
            this.buttonClearDecryptText.UseVisualStyleBackColor = true;
            this.buttonClearDecryptText.Click += new System.EventHandler(this.buttonClearDecryptText_Click);
            // 
            // buttonSaveDecryptText
            // 
            this.buttonSaveDecryptText.Location = new System.Drawing.Point(85, 253);
            this.buttonSaveDecryptText.Name = "buttonSaveDecryptText";
            this.buttonSaveDecryptText.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDecryptText.TabIndex = 13;
            this.buttonSaveDecryptText.Text = "Сохранить";
            this.buttonSaveDecryptText.UseVisualStyleBackColor = true;
            this.buttonSaveDecryptText.Click += new System.EventHandler(this.buttonSaveDecryptText_Click);
            // 
            // buttonOpenDecryptText
            // 
            this.buttonOpenDecryptText.Location = new System.Drawing.Point(4, 253);
            this.buttonOpenDecryptText.Name = "buttonOpenDecryptText";
            this.buttonOpenDecryptText.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenDecryptText.TabIndex = 14;
            this.buttonOpenDecryptText.Text = "Открыть";
            this.buttonOpenDecryptText.UseVisualStyleBackColor = true;
            this.buttonOpenDecryptText.Click += new System.EventHandler(this.buttonOpenDecryptText_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(4, 300);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(156, 23);
            this.textBoxInput.TabIndex = 15;
            this.textBoxInput.Visible = false;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(490, 300);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(156, 23);
            this.textBoxOutput.TabIndex = 16;
            this.textBoxOutput.Visible = false;
            // 
            // buttonOpenEncryptText
            // 
            this.buttonOpenEncryptText.Location = new System.Drawing.Point(490, 253);
            this.buttonOpenEncryptText.Name = "buttonOpenEncryptText";
            this.buttonOpenEncryptText.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenEncryptText.TabIndex = 17;
            this.buttonOpenEncryptText.Text = "Открыть";
            this.buttonOpenEncryptText.UseVisualStyleBackColor = true;
            this.buttonOpenEncryptText.Click += new System.EventHandler(this.buttonOpenEncryptText_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.CreatePrompt = true;
            this.saveFileDialog2.DefaultExt = "txt";
            this.saveFileDialog2.RestoreDirectory = true;
            this.saveFileDialog2.SupportMultiDottedExtensions = true;
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOpenEncryptText);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonOpenDecryptText);
            this.Controls.Add(this.buttonSaveDecryptText);
            this.Controls.Add(this.buttonClearDecryptText);
            this.Controls.Add(this.buttonClearEncryptText);
            this.Controls.Add(this.buttonSaveEncryptText);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelEncryptText);
            this.Controls.Add(this.labelDecryptText);
            this.Controls.Add(this.textBoxEncryptText);
            this.Controls.Add(this.textBoxDecryptText);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxDecryptText;
        private System.Windows.Forms.TextBox textBoxEncryptText;
        private System.Windows.Forms.Label labelDecryptText;
        private System.Windows.Forms.Label labelEncryptText;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSaveEncryptText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonClearEncryptText;
        private System.Windows.Forms.Button buttonClearDecryptText;
        private System.Windows.Forms.Button buttonSaveDecryptText;
        private System.Windows.Forms.Button buttonOpenDecryptText;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonOpenEncryptText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

