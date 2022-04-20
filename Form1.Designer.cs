
namespace Havman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.source_textBox = new System.Windows.Forms.TextBox();
            this.cryptographic_textBox = new System.Windows.Forms.TextBox();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // source_textBox
            // 
            this.source_textBox.Location = new System.Drawing.Point(12, 12);
            this.source_textBox.Multiline = true;
            this.source_textBox.Name = "source_textBox";
            this.source_textBox.Size = new System.Drawing.Size(1079, 123);
            this.source_textBox.TabIndex = 0;
            // 
            // cryptographic_textBox
            // 
            this.cryptographic_textBox.Location = new System.Drawing.Point(12, 154);
            this.cryptographic_textBox.Multiline = true;
            this.cryptographic_textBox.Name = "cryptographic_textBox";
            this.cryptographic_textBox.Size = new System.Drawing.Size(1079, 123);
            this.cryptographic_textBox.TabIndex = 1;
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(12, 283);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(133, 55);
            this.encrypt_button.TabIndex = 2;
            this.encrypt_button.Text = "button1";
            this.encrypt_button.UseVisualStyleBackColor = true;
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(958, 283);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(133, 55);
            this.decrypt_button.TabIndex = 3;
            this.decrypt_button.Text = "button2";
            this.decrypt_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 713);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.cryptographic_textBox);
            this.Controls.Add(this.source_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox source_textBox;
        private System.Windows.Forms.TextBox cryptographic_textBox;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Button decrypt_button;
    }
}

