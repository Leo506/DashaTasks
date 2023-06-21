namespace BullsAndCows
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
            this.label2 = new System.Windows.Forms.Label();
            this.numberLengthInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.correctCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.placedCount = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.guessCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.spentTime = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numberLengthInput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угадайте задуманное компютером число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число знаков";
            // 
            // numberLengthInput
            // 
            this.numberLengthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLengthInput.Location = new System.Drawing.Point(161, 79);
            this.numberLengthInput.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numberLengthInput.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberLengthInput.Name = "numberLengthInput";
            this.numberLengthInput.Size = new System.Drawing.Size(45, 23);
            this.numberLengthInput.TabIndex = 2;
            this.numberLengthInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число";
            // 
            // guessInput
            // 
            this.guessInput.Enabled = false;
            this.guessInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessInput.Location = new System.Drawing.Point(94, 134);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(112, 23);
            this.guessInput.TabIndex = 4;
            this.guessInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuessInputChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Угадано цифр:";
            // 
            // correctCount
            // 
            this.correctCount.AutoSize = true;
            this.correctCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctCount.Location = new System.Drawing.Point(173, 185);
            this.correctCount.Name = "correctCount";
            this.correctCount.Size = new System.Drawing.Size(87, 24);
            this.correctCount.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Из них на своих местах:";
            // 
            // placedCount
            // 
            this.placedCount.AutoSize = true;
            this.placedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placedCount.Location = new System.Drawing.Point(259, 232);
            this.placedCount.Name = "placedCount";
            this.placedCount.Size = new System.Drawing.Size(76, 24);
            this.placedCount.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(29, 315);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(128, 46);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(263, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Завершить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StopButtonClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guessCount,
            this.spentTime});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // guessCount
            // 
            this.guessCount.Name = "guessCount";
            this.guessCount.Size = new System.Drawing.Size(69, 17);
            this.guessCount.Text = "Попыток: 0";
            // 
            // spentTime
            // 
            this.spentTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.spentTime.Name = "spentTime";
            this.spentTime.Size = new System.Drawing.Size(148, 17);
            this.spentTime.Text = "Затраченное время: 0 сек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.placedCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.correctCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberLengthInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Угадай число";
            ((System.ComponentModel.ISupportInitialize)(this.numberLengthInput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberLengthInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label correctCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label placedCount;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel guessCount;
        private System.Windows.Forms.ToolStripStatusLabel spentTime;
    }
}

