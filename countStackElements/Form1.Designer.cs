namespace countStackElements
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
            this.stackOutput = new System.Windows.Forms.TextBox();
            this.inputNumber = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.countElements = new System.Windows.Forms.Button();
            this.countElementsOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // stackOutput
            // 
            this.stackOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stackOutput.Location = new System.Drawing.Point(13, 13);
            this.stackOutput.Multiline = true;
            this.stackOutput.Name = "stackOutput";
            this.stackOutput.ReadOnly = true;
            this.stackOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stackOutput.Size = new System.Drawing.Size(94, 531);
            this.stackOutput.TabIndex = 0;
            this.stackOutput.WordWrap = false;
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(113, 14);
            this.inputNumber.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.inputNumber.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(120, 20);
            this.inputNumber.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(113, 41);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 28);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(114, 76);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 26);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete first";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // countElements
            // 
            this.countElements.Location = new System.Drawing.Point(114, 109);
            this.countElements.Name = "countElements";
            this.countElements.Size = new System.Drawing.Size(119, 23);
            this.countElements.TabIndex = 4;
            this.countElements.Text = "Count elements";
            this.countElements.UseVisualStyleBackColor = true;
            this.countElements.Click += new System.EventHandler(this.countElements_Click);
            // 
            // countElementsOutput
            // 
            this.countElementsOutput.AutoSize = true;
            this.countElementsOutput.Location = new System.Drawing.Point(239, 114);
            this.countElementsOutput.Name = "countElementsOutput";
            this.countElementsOutput.Size = new System.Drawing.Size(0, 13);
            this.countElementsOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 556);
            this.Controls.Add(this.countElementsOutput);
            this.Controls.Add(this.countElements);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.stackOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stackOutput;
        private System.Windows.Forms.NumericUpDown inputNumber;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button countElements;
        private System.Windows.Forms.Label countElementsOutput;
    }
}

