
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
            this.tree_dgv = new System.Windows.Forms.DataGridView();
            this.code_dgv = new System.Windows.Forms.DataGridView();
            this.clear_button = new System.Windows.Forms.Button();
            this.code_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tree_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // source_textBox
            // 
            this.source_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.source_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.source_textBox.Location = new System.Drawing.Point(12, 14);
            this.source_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.source_textBox.Multiline = true;
            this.source_textBox.Name = "source_textBox";
            this.source_textBox.Size = new System.Drawing.Size(1091, 212);
            this.source_textBox.TabIndex = 0;
            // 
            // cryptographic_textBox
            // 
            this.cryptographic_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cryptographic_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptographic_textBox.Location = new System.Drawing.Point(12, 247);
            this.cryptographic_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cryptographic_textBox.Multiline = true;
            this.cryptographic_textBox.Name = "cryptographic_textBox";
            this.cryptographic_textBox.ReadOnly = true;
            this.cryptographic_textBox.Size = new System.Drawing.Size(1091, 212);
            this.cryptographic_textBox.TabIndex = 1;
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.Color.Lime;
            this.encrypt_button.FlatAppearance.BorderSize = 0;
            this.encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypt_button.Location = new System.Drawing.Point(12, 465);
            this.encrypt_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(164, 55);
            this.encrypt_button.TabIndex = 2;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.BackColor = System.Drawing.Color.Lime;
            this.decrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_button.Location = new System.Drawing.Point(181, 465);
            this.decrypt_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(164, 55);
            this.decrypt_button.TabIndex = 3;
            this.decrypt_button.Text = "Decipher";
            this.decrypt_button.UseVisualStyleBackColor = false;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // tree_dgv
            // 
            this.tree_dgv.AllowUserToAddRows = false;
            this.tree_dgv.AllowUserToDeleteRows = false;
            this.tree_dgv.AllowUserToResizeColumns = false;
            this.tree_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tree_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tree_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tree_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tree_dgv.Location = new System.Drawing.Point(334, 527);
            this.tree_dgv.Margin = new System.Windows.Forms.Padding(5);
            this.tree_dgv.Name = "tree_dgv";
            this.tree_dgv.RowHeadersVisible = false;
            this.tree_dgv.RowHeadersWidth = 51;
            this.tree_dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tree_dgv.Size = new System.Drawing.Size(769, 339);
            this.tree_dgv.TabIndex = 8;
            // 
            // code_dgv
            // 
            this.code_dgv.AllowUserToAddRows = false;
            this.code_dgv.AllowUserToDeleteRows = false;
            this.code_dgv.AllowUserToResizeColumns = false;
            this.code_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.code_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.code_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.code_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.code_dgv.Location = new System.Drawing.Point(12, 527);
            this.code_dgv.Margin = new System.Windows.Forms.Padding(5);
            this.code_dgv.Name = "code_dgv";
            this.code_dgv.RowHeadersVisible = false;
            this.code_dgv.RowHeadersWidth = 51;
            this.code_dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.code_dgv.Size = new System.Drawing.Size(311, 339);
            this.code_dgv.TabIndex = 9;
            // 
            // clear_button
            // 
            this.clear_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_button.BackColor = System.Drawing.Color.Red;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(969, 465);
            this.clear_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(133, 55);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // code_button
            // 
            this.code_button.BackColor = System.Drawing.Color.Lime;
            this.code_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.code_button.Location = new System.Drawing.Point(351, 465);
            this.code_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.code_button.Name = "code_button";
            this.code_button.Size = new System.Drawing.Size(245, 55);
            this.code_button.TabIndex = 11;
            this.code_button.Text = "Generation Code";
            this.code_button.UseVisualStyleBackColor = false;
            this.code_button.Click += new System.EventHandler(this.kod_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 883);
            this.Controls.Add(this.code_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.code_dgv);
            this.Controls.Add(this.tree_dgv);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.cryptographic_textBox);
            this.Controls.Add(this.source_textBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tree_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox source_textBox;
        private System.Windows.Forms.TextBox cryptographic_textBox;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.DataGridView tree_dgv;
        private System.Windows.Forms.DataGridView code_dgv;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button code_button;
    }
}

