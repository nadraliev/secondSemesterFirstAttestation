namespace MergeTwoListsForm
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
            this.first_list = new System.Windows.Forms.TextBox();
            this.generate_first_list = new System.Windows.Forms.Button();
            this.second_list = new System.Windows.Forms.TextBox();
            this.generate_second_list = new System.Windows.Forms.Button();
            this.result_list = new System.Windows.Forms.TextBox();
            this.merge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleted_elements = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first_list
            // 
            this.first_list.Location = new System.Drawing.Point(13, 39);
            this.first_list.Multiline = true;
            this.first_list.Name = "first_list";
            this.first_list.ReadOnly = true;
            this.first_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.first_list.Size = new System.Drawing.Size(100, 494);
            this.first_list.TabIndex = 0;
            this.first_list.WordWrap = false;
            // 
            // generate_first_list
            // 
            this.generate_first_list.Location = new System.Drawing.Point(13, 13);
            this.generate_first_list.Name = "generate_first_list";
            this.generate_first_list.Size = new System.Drawing.Size(100, 23);
            this.generate_first_list.TabIndex = 1;
            this.generate_first_list.Text = "Сгенерировать";
            this.generate_first_list.UseVisualStyleBackColor = true;
            this.generate_first_list.Click += new System.EventHandler(this.generate_first_list_Click);
            // 
            // second_list
            // 
            this.second_list.Location = new System.Drawing.Point(167, 39);
            this.second_list.Multiline = true;
            this.second_list.Name = "second_list";
            this.second_list.ReadOnly = true;
            this.second_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.second_list.Size = new System.Drawing.Size(100, 494);
            this.second_list.TabIndex = 2;
            this.second_list.WordWrap = false;
            // 
            // generate_second_list
            // 
            this.generate_second_list.Location = new System.Drawing.Point(167, 13);
            this.generate_second_list.Name = "generate_second_list";
            this.generate_second_list.Size = new System.Drawing.Size(100, 23);
            this.generate_second_list.TabIndex = 3;
            this.generate_second_list.Text = "Сгенерировать";
            this.generate_second_list.UseVisualStyleBackColor = true;
            this.generate_second_list.Click += new System.EventHandler(this.generate_second_list_Click);
            // 
            // result_list
            // 
            this.result_list.Location = new System.Drawing.Point(362, 39);
            this.result_list.Multiline = true;
            this.result_list.Name = "result_list";
            this.result_list.ReadOnly = true;
            this.result_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_list.Size = new System.Drawing.Size(100, 494);
            this.result_list.TabIndex = 4;
            this.result_list.WordWrap = false;
            // 
            // merge
            // 
            this.merge.Location = new System.Drawing.Point(274, 267);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(75, 23);
            this.merge.TabIndex = 5;
            this.merge.Text = "--->";
            this.merge.UseVisualStyleBackColor = true;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результат";
            // 
            // deleted_elements
            // 
            this.deleted_elements.Location = new System.Drawing.Point(480, 39);
            this.deleted_elements.Multiline = true;
            this.deleted_elements.Name = "deleted_elements";
            this.deleted_elements.ReadOnly = true;
            this.deleted_elements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deleted_elements.Size = new System.Drawing.Size(100, 494);
            this.deleted_elements.TabIndex = 7;
            this.deleted_elements.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Удаленные елементы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleted_elements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.result_list);
            this.Controls.Add(this.generate_second_list);
            this.Controls.Add(this.second_list);
            this.Controls.Add(this.generate_first_list);
            this.Controls.Add(this.first_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_list;
        private System.Windows.Forms.Button generate_first_list;
        private System.Windows.Forms.TextBox second_list;
        private System.Windows.Forms.Button generate_second_list;
        private System.Windows.Forms.TextBox result_list;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleted_elements;
        private System.Windows.Forms.Label label2;
    }
}

