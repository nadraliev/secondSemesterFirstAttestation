namespace FindProgression
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
            this.open_file_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // open_file_button
            // 
            this.open_file_button.Location = new System.Drawing.Point(171, 48);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(115, 27);
            this.open_file_button.TabIndex = 0;
            this.open_file_button.Text = "Открыть файл";
            this.open_file_button.UseVisualStyleBackColor = true;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // result_label
            // 
            this.result_label.Location = new System.Drawing.Point(12, 93);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(452, 23);
            this.result_label.TabIndex = 1;
            this.result_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 463);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.open_file_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.Label result_label;
    }
}

