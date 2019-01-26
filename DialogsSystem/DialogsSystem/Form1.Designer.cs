namespace DialogsSystem
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
            this.comboCharacters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.npcText = new System.Windows.Forms.TextBox();
            this.listAnswers = new System.Windows.Forms.ListBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCharacters
            // 
            this.comboCharacters.FormattingEnabled = true;
            this.comboCharacters.Location = new System.Drawing.Point(12, 24);
            this.comboCharacters.Name = "comboCharacters";
            this.comboCharacters.Size = new System.Drawing.Size(121, 21);
            this.comboCharacters.TabIndex = 1;
            this.comboCharacters.SelectedIndexChanged += new System.EventHandler(this.comboCharacters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать персонажа";
            // 
            // npcText
            // 
            this.npcText.Location = new System.Drawing.Point(139, 24);
            this.npcText.Multiline = true;
            this.npcText.Name = "npcText";
            this.npcText.Size = new System.Drawing.Size(352, 68);
            this.npcText.TabIndex = 3;
            // 
            // listAnswers
            // 
            this.listAnswers.FormattingEnabled = true;
            this.listAnswers.Location = new System.Drawing.Point(139, 98);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(352, 56);
            this.listAnswers.TabIndex = 4;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(139, 160);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 5;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 190);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.listAnswers);
            this.Controls.Add(this.npcText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCharacters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboCharacters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox npcText;
        private System.Windows.Forms.ListBox listAnswers;
        private System.Windows.Forms.Button btnAnswer;
    }
}

