
namespace Tyuiu.MezentsevSE.Sprint6.Task3.V18
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
            this.buttonRes_MSE = new System.Windows.Forms.Button();
            this.DataGridViewRes_MSE = new System.Windows.Forms.DataGridView();
            this.textBoxTask_MSE = new System.Windows.Forms.TextBox();
            this.labelRes_MSE = new System.Windows.Forms.Label();
            this.buttonInfo_MSE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_MSE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRes_MSE
            // 
            this.buttonRes_MSE.BackColor = System.Drawing.Color.Green;
            this.buttonRes_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRes_MSE.Location = new System.Drawing.Point(23, 312);
            this.buttonRes_MSE.Name = "buttonRes_MSE";
            this.buttonRes_MSE.Size = new System.Drawing.Size(157, 85);
            this.buttonRes_MSE.TabIndex = 1;
            this.buttonRes_MSE.Text = "Заменить";
            this.buttonRes_MSE.UseVisualStyleBackColor = false;
            this.buttonRes_MSE.Click += new System.EventHandler(this.buttonRes_MSE_Click);
            this.buttonRes_MSE.MouseEnter += new System.EventHandler(this.buttonRes_MSE_MouseEnter);
            this.buttonRes_MSE.MouseLeave += new System.EventHandler(this.buttonRes_MSE_MouseLeave);
            // 
            // DataGridViewRes_MSE
            // 
            this.DataGridViewRes_MSE.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridViewRes_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewRes_MSE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRes_MSE.Location = new System.Drawing.Point(372, 102);
            this.DataGridViewRes_MSE.Name = "DataGridViewRes_MSE";
            this.DataGridViewRes_MSE.RowHeadersVisible = false;
            this.DataGridViewRes_MSE.Size = new System.Drawing.Size(335, 295);
            this.DataGridViewRes_MSE.TabIndex = 2;
            // 
            // textBoxTask_MSE
            // 
            this.textBoxTask_MSE.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_MSE.Location = new System.Drawing.Point(23, 57);
            this.textBoxTask_MSE.Multiline = true;
            this.textBoxTask_MSE.Name = "textBoxTask_MSE";
            this.textBoxTask_MSE.Size = new System.Drawing.Size(269, 223);
            this.textBoxTask_MSE.TabIndex = 3;
            this.textBoxTask_MSE.Text = "В матрице\r\n{-19, -19, 1, 18, 7}\r\n{ 5, 3, -4, -6, -12}\r\n{ -15, 6, 2, 2, -14}\r\n{ -9" +
    ", -10, 15, -5, -6}\r\n{ -13, -15, -9, 7, 1}\r\nзаменить четные элементы 4 строки на " +
    "0\r\n\r\n";
            // 
            // labelRes_MSE
            // 
            this.labelRes_MSE.AutoSize = true;
            this.labelRes_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes_MSE.Location = new System.Drawing.Point(449, 48);
            this.labelRes_MSE.Name = "labelRes_MSE";
            this.labelRes_MSE.Size = new System.Drawing.Size(171, 37);
            this.labelRes_MSE.TabIndex = 4;
            this.labelRes_MSE.Text = "Результат:";
            // 
            // buttonInfo_MSE
            // 
            this.buttonInfo_MSE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_MSE.Location = new System.Drawing.Point(211, 312);
            this.buttonInfo_MSE.Name = "buttonInfo_MSE";
            this.buttonInfo_MSE.Size = new System.Drawing.Size(81, 85);
            this.buttonInfo_MSE.TabIndex = 5;
            this.buttonInfo_MSE.Text = "?";
            this.buttonInfo_MSE.UseVisualStyleBackColor = false;
            this.buttonInfo_MSE.Click += new System.EventHandler(this.buttonInfo_MSE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_MSE);
            this.Controls.Add(this.labelRes_MSE);
            this.Controls.Add(this.textBoxTask_MSE);
            this.Controls.Add(this.DataGridViewRes_MSE);
            this.Controls.Add(this.buttonRes_MSE);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Мезенцев С.Е.";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_MSE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRes_MSE;
        private System.Windows.Forms.DataGridView DataGridViewRes_MSE;
        private System.Windows.Forms.TextBox textBoxTask_MSE;
        private System.Windows.Forms.Label labelRes_MSE;
        private System.Windows.Forms.Button buttonInfo_MSE;
    }
}

