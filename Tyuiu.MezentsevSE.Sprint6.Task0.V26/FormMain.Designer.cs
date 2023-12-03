
namespace Tyuiu.MezentsevSE.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonRes_MSE = new System.Windows.Forms.Button();
            this.groupBoxCondition_MSE = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_MSE = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_MSE = new System.Windows.Forms.TextBox();
            this.textBoxResult_MSE = new System.Windows.Forms.TextBox();
            this.groupBoxValue_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxValue_MSE = new System.Windows.Forms.TextBox();
            this.buttonInfo_MSE = new System.Windows.Forms.Button();
            this.labelResult_MSE = new System.Windows.Forms.Label();
            this.groupBoxCondition_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MSE)).BeginInit();
            this.groupBoxValue_MSE.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRes_MSE
            // 
            this.buttonRes_MSE.Location = new System.Drawing.Point(634, 357);
            this.buttonRes_MSE.Name = "buttonRes_MSE";
            this.buttonRes_MSE.Size = new System.Drawing.Size(112, 33);
            this.buttonRes_MSE.TabIndex = 1;
            this.buttonRes_MSE.Text = "Выполнить";
            this.buttonRes_MSE.UseVisualStyleBackColor = true;
            this.buttonRes_MSE.Click += new System.EventHandler(this.buttonRes_MSE_Click);
            // 
            // groupBoxCondition_MSE
            // 
            this.groupBoxCondition_MSE.Controls.Add(this.pictureBoxFormula_MSE);
            this.groupBoxCondition_MSE.Controls.Add(this.textBoxCondition_MSE);
            this.groupBoxCondition_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_MSE.Location = new System.Drawing.Point(49, 44);
            this.groupBoxCondition_MSE.Name = "groupBoxCondition_MSE";
            this.groupBoxCondition_MSE.Size = new System.Drawing.Size(697, 200);
            this.groupBoxCondition_MSE.TabIndex = 2;
            this.groupBoxCondition_MSE.TabStop = false;
            this.groupBoxCondition_MSE.Text = "Условие";
            // 
            // pictureBoxFormula_MSE
            // 
            this.pictureBoxFormula_MSE.ErrorImage = null;
            this.pictureBoxFormula_MSE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_MSE.Image")));
            this.pictureBoxFormula_MSE.Location = new System.Drawing.Point(541, 18);
            this.pictureBoxFormula_MSE.Name = "pictureBoxFormula_MSE";
            this.pictureBoxFormula_MSE.Size = new System.Drawing.Size(115, 54);
            this.pictureBoxFormula_MSE.TabIndex = 3;
            this.pictureBoxFormula_MSE.TabStop = false;
            // 
            // textBoxCondition_MSE
            // 
            this.textBoxCondition_MSE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxCondition_MSE.Location = new System.Drawing.Point(3, 18);
            this.textBoxCondition_MSE.Multiline = true;
            this.textBoxCondition_MSE.Name = "textBoxCondition_MSE";
            this.textBoxCondition_MSE.ReadOnly = true;
            this.textBoxCondition_MSE.Size = new System.Drawing.Size(483, 176);
            this.textBoxCondition_MSE.TabIndex = 0;
            this.textBoxCondition_MSE.Text = "Дано выражение, вычислить его значение при x = 3";
            this.textBoxCondition_MSE.TextChanged += new System.EventHandler(this.textBoxCondition_MSE_TextChanged);
            // 
            // textBoxResult_MSE
            // 
            this.textBoxResult_MSE.Location = new System.Drawing.Point(634, 409);
            this.textBoxResult_MSE.Name = "textBoxResult_MSE";
            this.textBoxResult_MSE.ReadOnly = true;
            this.textBoxResult_MSE.Size = new System.Drawing.Size(112, 20);
            this.textBoxResult_MSE.TabIndex = 3;
            // 
            // groupBoxValue_MSE
            // 
            this.groupBoxValue_MSE.Controls.Add(this.textBoxValue_MSE);
            this.groupBoxValue_MSE.Location = new System.Drawing.Point(49, 357);
            this.groupBoxValue_MSE.Name = "groupBoxValue_MSE";
            this.groupBoxValue_MSE.Size = new System.Drawing.Size(288, 59);
            this.groupBoxValue_MSE.TabIndex = 4;
            this.groupBoxValue_MSE.TabStop = false;
            this.groupBoxValue_MSE.Text = "Введите значение х:";
            // 
            // textBoxValue_MSE
            // 
            this.textBoxValue_MSE.Location = new System.Drawing.Point(6, 19);
            this.textBoxValue_MSE.Name = "textBoxValue_MSE";
            this.textBoxValue_MSE.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue_MSE.TabIndex = 0;
            this.textBoxValue_MSE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_MSE_KeyPress);
            // 
            // buttonInfo_MSE
            // 
            this.buttonInfo_MSE.Location = new System.Drawing.Point(590, 357);
            this.buttonInfo_MSE.Name = "buttonInfo_MSE";
            this.buttonInfo_MSE.Size = new System.Drawing.Size(36, 33);
            this.buttonInfo_MSE.TabIndex = 5;
            this.buttonInfo_MSE.Text = "?";
            this.buttonInfo_MSE.UseVisualStyleBackColor = true;
            this.buttonInfo_MSE.Click += new System.EventHandler(this.buttonInfo_MSE_Click);
            // 
            // labelResult_MSE
            // 
            this.labelResult_MSE.AutoSize = true;
            this.labelResult_MSE.Location = new System.Drawing.Point(663, 393);
            this.labelResult_MSE.Name = "labelResult_MSE";
            this.labelResult_MSE.Size = new System.Drawing.Size(59, 13);
            this.labelResult_MSE.TabIndex = 6;
            this.labelResult_MSE.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult_MSE);
            this.Controls.Add(this.buttonInfo_MSE);
            this.Controls.Add(this.groupBoxValue_MSE);
            this.Controls.Add(this.textBoxResult_MSE);
            this.Controls.Add(this.groupBoxCondition_MSE);
            this.Controls.Add(this.buttonRes_MSE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 |  Вариант 26 | Мезенцев С.Е. ";
            this.groupBoxCondition_MSE.ResumeLayout(false);
            this.groupBoxCondition_MSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MSE)).EndInit();
            this.groupBoxValue_MSE.ResumeLayout(false);
            this.groupBoxValue_MSE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRes_MSE;
        private System.Windows.Forms.GroupBox groupBoxCondition_MSE;
        private System.Windows.Forms.TextBox textBoxCondition_MSE;
        private System.Windows.Forms.PictureBox pictureBoxFormula_MSE;
        private System.Windows.Forms.TextBox textBoxResult_MSE;
        private System.Windows.Forms.GroupBox groupBoxValue_MSE;
        private System.Windows.Forms.TextBox textBoxValue_MSE;
        private System.Windows.Forms.Button buttonInfo_MSE;
        private System.Windows.Forms.Label labelResult_MSE;
    }
}

