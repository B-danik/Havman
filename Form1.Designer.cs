
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
            this.encrypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv_name = new System.Windows.Forms.DataGridView();
            this.clear_button = new System.Windows.Forms.Button();
            this.kod_button = new System.Windows.Forms.Button();
            this.cryptographic_textBox = new System.Windows.Forms.TextBox();
            this.source_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_name)).BeginInit();
            this.SuspendLayout();
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.Color.Lime;
            this.encrypt_button.FlatAppearance.BorderSize = 0;
            this.encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt_button.Location = new System.Drawing.Point(9, 378);
            this.encrypt_button.Margin = new System.Windows.Forms.Padding(2);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(123, 45);
            this.encrypt_button.TabIndex = 2;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.BackColor = System.Drawing.Color.Lime;
            this.decrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_button.Location = new System.Drawing.Point(136, 378);
            this.decrypt_button.Margin = new System.Windows.Forms.Padding(2);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(123, 45);
            this.decrypt_button.TabIndex = 3;
            this.decrypt_button.Text = "Decipher";
            this.decrypt_button.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(9, 429);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(383, 239);
            this.dgv.TabIndex = 8;
            // 
            // dgv_name
            // 
            this.dgv_name.AllowUserToAddRows = false;
            this.dgv_name.AllowUserToDeleteRows = false;
            this.dgv_name.AllowUserToResizeColumns = false;
            this.dgv_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_name.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_name.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_name.Location = new System.Drawing.Point(400, 429);
            this.dgv_name.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_name.Name = "dgv_name";
            this.dgv_name.ReadOnly = true;
            this.dgv_name.RowHeadersVisible = false;
            this.dgv_name.RowHeadersWidth = 51;
            this.dgv_name.Size = new System.Drawing.Size(542, 239);
            this.dgv_name.TabIndex = 9;
            // 
            // clear_button
            // 
            this.clear_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_button.BackColor = System.Drawing.Color.Red;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(842, 378);
            this.clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 45);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            // 
            // kod_button
            // 
            this.kod_button.BackColor = System.Drawing.Color.Lime;
            this.kod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kod_button.Location = new System.Drawing.Point(263, 378);
            this.kod_button.Margin = new System.Windows.Forms.Padding(2);
            this.kod_button.Name = "kod_button";
            this.kod_button.Size = new System.Drawing.Size(184, 45);
            this.kod_button.TabIndex = 11;
            this.kod_button.Text = "Generation Kod";
            this.kod_button.UseVisualStyleBackColor = false;
            // 
            // cryptographic_textBox
            // 
            this.cryptographic_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cryptographic_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptographic_textBox.Location = new System.Drawing.Point(9, 201);
            this.cryptographic_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.cryptographic_textBox.Multiline = true;
            this.cryptographic_textBox.Name = "cryptographic_textBox";
            this.cryptographic_textBox.ReadOnly = true;
            this.cryptographic_textBox.Size = new System.Drawing.Size(934, 173);
            this.cryptographic_textBox.TabIndex = 1;
            // 
            // source_textBox
            // 
            this.source_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.source_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.source_textBox.Location = new System.Drawing.Point(9, 11);
            this.source_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.source_textBox.Multiline = true;
            this.source_textBox.Name = "source_textBox";
            this.source_textBox.Size = new System.Drawing.Size(934, 173);
            this.source_textBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 681);
            this.Controls.Add(this.kod_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.dgv_name);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.cryptographic_textBox);
            this.Controls.Add(this.source_textBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView dgv_name;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button kod_button;
        private System.Windows.Forms.TextBox cryptographic_textBox;
        private System.Windows.Forms.TextBox source_textBox;
    }
}

