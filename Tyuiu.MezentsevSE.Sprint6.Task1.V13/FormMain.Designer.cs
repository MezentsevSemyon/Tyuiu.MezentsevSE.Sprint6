
namespace Tyuiu.MezentsevSE.Sprint6.Task1.V13
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxtTask_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MSE = new System.Windows.Forms.TextBox();
            this.groupBoxValue_MSE = new System.Windows.Forms.GroupBox();
            this.labelFinish_MSE = new System.Windows.Forms.Label();
            this.labelStart_MSE = new System.Windows.Forms.Label();
            this.textBoxFinish_MSE = new System.Windows.Forms.TextBox();
            this.textBoxStart_MSE = new System.Windows.Forms.TextBox();
            this.buttonResult_MSE = new System.Windows.Forms.Button();
            this.groupBoxResult_MSE = new System.Windows.Forms.GroupBox();
            this.labelResult_MSE = new System.Windows.Forms.Label();
            this.textBoxResult_MSE = new System.Windows.Forms.TextBox();
            this.buttonInfo_MSE = new System.Windows.Forms.Button();
            this.groupBoxtTask_MSE.SuspendLayout();
            this.groupBoxValue_MSE.SuspendLayout();
            this.groupBoxResult_MSE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxtTask_MSE
            // 
            this.groupBoxtTask_MSE.Controls.Add(this.textBoxTask_MSE);
            this.groupBoxtTask_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxtTask_MSE.Location = new System.Drawing.Point(3, 3);
            this.groupBoxtTask_MSE.Name = "groupBoxtTask_MSE";
            this.groupBoxtTask_MSE.Size = new System.Drawing.Size(429, 229);
            this.groupBoxtTask_MSE.TabIndex = 0;
            this.groupBoxtTask_MSE.TabStop = false;
            this.groupBoxtTask_MSE.Text = "Условие";
            // 
            // textBoxTask_MSE
            // 
            this.textBoxTask_MSE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_MSE.Location = new System.Drawing.Point(0, 21);
            this.textBoxTask_MSE.Multiline = true;
            this.textBoxTask_MSE.Name = "textBoxTask_MSE";
            this.textBoxTask_MSE.ReadOnly = true;
            this.textBoxTask_MSE.Size = new System.Drawing.Size(423, 202);
            this.textBoxTask_MSE.TabIndex = 0;
            this.textBoxTask_MSE.Text = "Написать программу, которая выводит таблицу значений функции";
            // 
            // groupBoxValue_MSE
            // 
            this.groupBoxValue_MSE.Controls.Add(this.labelFinish_MSE);
            this.groupBoxValue_MSE.Controls.Add(this.labelStart_MSE);
            this.groupBoxValue_MSE.Controls.Add(this.textBoxFinish_MSE);
            this.groupBoxValue_MSE.Controls.Add(this.textBoxStart_MSE);
            this.groupBoxValue_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxValue_MSE.Location = new System.Drawing.Point(3, 333);
            this.groupBoxValue_MSE.Name = "groupBoxValue_MSE";
            this.groupBoxValue_MSE.Size = new System.Drawing.Size(276, 105);
            this.groupBoxValue_MSE.TabIndex = 1;
            this.groupBoxValue_MSE.TabStop = false;
            this.groupBoxValue_MSE.Text = "Ввод данных";
            // 
            // labelFinish_MSE
            // 
            this.labelFinish_MSE.AutoSize = true;
            this.labelFinish_MSE.Location = new System.Drawing.Point(164, 43);
            this.labelFinish_MSE.Name = "labelFinish_MSE";
            this.labelFinish_MSE.Size = new System.Drawing.Size(82, 16);
            this.labelFinish_MSE.TabIndex = 3;
            this.labelFinish_MSE.Text = "Конец шага";
            // 
            // labelStart_MSE
            // 
            this.labelStart_MSE.AutoSize = true;
            this.labelStart_MSE.Location = new System.Drawing.Point(6, 43);
            this.labelStart_MSE.Name = "labelStart_MSE";
            this.labelStart_MSE.Size = new System.Drawing.Size(92, 16);
            this.labelStart_MSE.TabIndex = 2;
            this.labelStart_MSE.Text = "Начало шага";
            // 
            // textBoxFinish_MSE
            // 
            this.textBoxFinish_MSE.Location = new System.Drawing.Point(167, 62);
            this.textBoxFinish_MSE.Name = "textBoxFinish_MSE";
            this.textBoxFinish_MSE.Size = new System.Drawing.Size(100, 22);
            this.textBoxFinish_MSE.TabIndex = 1;
            // 
            // textBoxStart_MSE
            // 
            this.textBoxStart_MSE.Location = new System.Drawing.Point(6, 62);
            this.textBoxStart_MSE.Name = "textBoxStart_MSE";
            this.textBoxStart_MSE.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_MSE.TabIndex = 0;
            this.textBoxStart_MSE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonResult_MSE
            // 
            this.buttonResult_MSE.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonResult_MSE.Location = new System.Drawing.Point(418, 365);
            this.buttonResult_MSE.Name = "buttonResult_MSE";
            this.buttonResult_MSE.Size = new System.Drawing.Size(90, 52);
            this.buttonResult_MSE.TabIndex = 2;
            this.buttonResult_MSE.Text = "Выполнить";
            this.buttonResult_MSE.UseVisualStyleBackColor = false;
            this.buttonResult_MSE.Click += new System.EventHandler(this.buttonResult_MSE_Click);
            // 
            // groupBoxResult_MSE
            // 
            this.groupBoxResult_MSE.Controls.Add(this.labelResult_MSE);
            this.groupBoxResult_MSE.Controls.Add(this.textBoxResult_MSE);
            this.groupBoxResult_MSE.Location = new System.Drawing.Point(524, 24);
            this.groupBoxResult_MSE.Name = "groupBoxResult_MSE";
            this.groupBoxResult_MSE.Size = new System.Drawing.Size(264, 414);
            this.groupBoxResult_MSE.TabIndex = 4;
            this.groupBoxResult_MSE.TabStop = false;
            this.groupBoxResult_MSE.Text = "Вывод данных";
            // 
            // labelResult_MSE
            // 
            this.labelResult_MSE.AutoSize = true;
            this.labelResult_MSE.Location = new System.Drawing.Point(6, 25);
            this.labelResult_MSE.Name = "labelResult_MSE";
            this.labelResult_MSE.Size = new System.Drawing.Size(62, 13);
            this.labelResult_MSE.TabIndex = 1;
            this.labelResult_MSE.Text = "Результат:";
            // 
            // textBoxResult_MSE
            // 
            this.textBoxResult_MSE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_MSE.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_MSE.Location = new System.Drawing.Point(6, 41);
            this.textBoxResult_MSE.Multiline = true;
            this.textBoxResult_MSE.Name = "textBoxResult_MSE";
            this.textBoxResult_MSE.ReadOnly = true;
            this.textBoxResult_MSE.Size = new System.Drawing.Size(258, 367);
            this.textBoxResult_MSE.TabIndex = 0;
            // 
            // buttonInfo_MSE
            // 
            this.buttonInfo_MSE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_MSE.Location = new System.Drawing.Point(330, 365);
            this.buttonInfo_MSE.Name = "buttonInfo_MSE";
            this.buttonInfo_MSE.Size = new System.Drawing.Size(66, 52);
            this.buttonInfo_MSE.TabIndex = 5;
            this.buttonInfo_MSE.Text = "Справка";
            this.buttonInfo_MSE.UseVisualStyleBackColor = false;
            this.buttonInfo_MSE.Click += new System.EventHandler(this.buttonInfo_MSE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_MSE);
            this.Controls.Add(this.groupBoxResult_MSE);
            this.Controls.Add(this.buttonResult_MSE);
            this.Controls.Add(this.groupBoxValue_MSE);
            this.Controls.Add(this.groupBoxtTask_MSE);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 |  Вариант 13 | Мезенцев С.Е. ";
            this.groupBoxtTask_MSE.ResumeLayout(false);
            this.groupBoxtTask_MSE.PerformLayout();
            this.groupBoxValue_MSE.ResumeLayout(false);
            this.groupBoxValue_MSE.PerformLayout();
            this.groupBoxResult_MSE.ResumeLayout(false);
            this.groupBoxResult_MSE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxtTask_MSE;
        private System.Windows.Forms.TextBox textBoxTask_MSE;
        private System.Windows.Forms.GroupBox groupBoxValue_MSE;
        private System.Windows.Forms.TextBox textBoxStart_MSE;
        private System.Windows.Forms.Label labelFinish_MSE;
        private System.Windows.Forms.Label labelStart_MSE;
        private System.Windows.Forms.TextBox textBoxFinish_MSE;
        private System.Windows.Forms.Button buttonResult_MSE;
        private System.Windows.Forms.GroupBox groupBoxResult_MSE;
        private System.Windows.Forms.Label labelResult_MSE;
        private System.Windows.Forms.TextBox textBoxResult_MSE;
        private System.Windows.Forms.Button buttonInfo_MSE;
    }
}

