namespace CountingGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNumberN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNumberK = new System.Windows.Forms.NumericUpDown();
            this.calculateNumberOfLast = new System.Windows.Forms.Button();
            this.outputNumberOfLast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите N";
            // 
            // inputNumberN
            // 
            this.inputNumberN.Location = new System.Drawing.Point(78, 7);
            this.inputNumberN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.inputNumberN.Name = "inputNumberN";
            this.inputNumberN.Size = new System.Drawing.Size(120, 20);
            this.inputNumberN.TabIndex = 1;
            this.inputNumberN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.inputNumberN.ValueChanged += new System.EventHandler(this.inputNumberN_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите k";
            // 
            // inputNumberK
            // 
            this.inputNumberK.Location = new System.Drawing.Point(268, 7);
            this.inputNumberK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumberK.Name = "inputNumberK";
            this.inputNumberK.Size = new System.Drawing.Size(120, 20);
            this.inputNumberK.TabIndex = 3;
            this.inputNumberK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculateNumberOfLast
            // 
            this.calculateNumberOfLast.Location = new System.Drawing.Point(118, 46);
            this.calculateNumberOfLast.Name = "calculateNumberOfLast";
            this.calculateNumberOfLast.Size = new System.Drawing.Size(188, 29);
            this.calculateNumberOfLast.TabIndex = 4;
            this.calculateNumberOfLast.Text = "Вычислить номер последнего";
            this.calculateNumberOfLast.UseVisualStyleBackColor = true;
            this.calculateNumberOfLast.Click += new System.EventHandler(this.calculateNumberOfLast_Click);
            // 
            // outputNumberOfLast
            // 
            this.outputNumberOfLast.AutoSize = true;
            this.outputNumberOfLast.Location = new System.Drawing.Point(193, 90);
            this.outputNumberOfLast.Name = "outputNumberOfLast";
            this.outputNumberOfLast.Size = new System.Drawing.Size(0, 13);
            this.outputNumberOfLast.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 445);
            this.Controls.Add(this.outputNumberOfLast);
            this.Controls.Add(this.calculateNumberOfLast);
            this.Controls.Add(this.inputNumberK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNumberN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputNumberN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputNumberK;
        private System.Windows.Forms.Button calculateNumberOfLast;
        private System.Windows.Forms.Label outputNumberOfLast;
    }
}

