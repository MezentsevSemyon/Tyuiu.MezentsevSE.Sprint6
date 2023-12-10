
namespace Tyuiu.MezentsevSE.Sprint6.Task7.V23
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
            this.components = new System.ComponentModel.Container();
            this.panelOne_MSE = new System.Windows.Forms.Panel();
            this.buttonHelp_MSE = new System.Windows.Forms.Button();
            this.buttonSave_MSE = new System.Windows.Forms.Button();
            this.buttonDone_MSE = new System.Windows.Forms.Button();
            this.buttonOpenFile_MSE = new System.Windows.Forms.Button();
            this.panelTwo_MSE = new System.Windows.Forms.Panel();
            this.groupBoxUslovie_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_MSE = new System.Windows.Forms.TextBox();
            this.panelThree_MSE = new System.Windows.Forms.Panel();
            this.groupBoxVvod_MSE = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_MSE = new System.Windows.Forms.DataGridView();
            this.panelFour_MSE = new System.Windows.Forms.Panel();
            this.groupBoxResult_MSE = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_MSE = new System.Windows.Forms.DataGridView();
            this.splitterOne_MSE = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_MSE = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_MSE = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_MSE = new System.Windows.Forms.SaveFileDialog();
            this.panelOne_MSE.SuspendLayout();
            this.panelTwo_MSE.SuspendLayout();
            this.groupBoxUslovie_MSE.SuspendLayout();
            this.panelThree_MSE.SuspendLayout();
            this.groupBoxVvod_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MSE)).BeginInit();
            this.panelFour_MSE.SuspendLayout();
            this.groupBoxResult_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MSE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_MSE
            // 
            this.panelOne_MSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOne_MSE.Controls.Add(this.buttonHelp_MSE);
            this.panelOne_MSE.Controls.Add(this.buttonSave_MSE);
            this.panelOne_MSE.Controls.Add(this.buttonDone_MSE);
            this.panelOne_MSE.Controls.Add(this.buttonOpenFile_MSE);
            this.panelOne_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_MSE.Location = new System.Drawing.Point(0, 0);
            this.panelOne_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelOne_MSE.Name = "panelOne_MSE";
            this.panelOne_MSE.Size = new System.Drawing.Size(626, 72);
            this.panelOne_MSE.TabIndex = 0;
            // 
            // buttonHelp_MSE
            // 
            this.buttonHelp_MSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_MSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MSE.ForeColor = System.Drawing.Color.Black;
            this.buttonHelp_MSE.Location = new System.Drawing.Point(544, 4);
            this.buttonHelp_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_MSE.Name = "buttonHelp_MSE";
            this.buttonHelp_MSE.Size = new System.Drawing.Size(79, 62);
            this.buttonHelp_MSE.TabIndex = 0;
            this.buttonHelp_MSE.Text = "Справка";
            this.toolTipButton_MSE.SetToolTip(this.buttonHelp_MSE, "Сведение о программе");
            this.buttonHelp_MSE.UseVisualStyleBackColor = false;
            this.buttonHelp_MSE.Click += new System.EventHandler(this.buttonHelp_MSE_Click);
            // 
            // buttonSave_MSE
            // 
            this.buttonSave_MSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSave_MSE.Enabled = false;
            this.buttonSave_MSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_MSE.ForeColor = System.Drawing.Color.Black;
            this.buttonSave_MSE.Location = new System.Drawing.Point(176, 4);
            this.buttonSave_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave_MSE.Name = "buttonSave_MSE";
            this.buttonSave_MSE.Size = new System.Drawing.Size(80, 62);
            this.buttonSave_MSE.TabIndex = 0;
            this.buttonSave_MSE.Text = "Сохранить";
            this.toolTipButton_MSE.SetToolTip(this.buttonSave_MSE, " Сохранить обработанные данных в файл в формате CSV");
            this.buttonSave_MSE.UseVisualStyleBackColor = false;
            this.buttonSave_MSE.Click += new System.EventHandler(this.buttonSave_MSE_Click);
            // 
            // buttonDone_MSE
            // 
            this.buttonDone_MSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_MSE.Enabled = false;
            this.buttonDone_MSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_MSE.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_MSE.Location = new System.Drawing.Point(90, 4);
            this.buttonDone_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_MSE.Name = "buttonDone_MSE";
            this.buttonDone_MSE.Size = new System.Drawing.Size(82, 62);
            this.buttonDone_MSE.TabIndex = 0;
            this.buttonDone_MSE.Text = "Выполнить";
            this.toolTipButton_MSE.SetToolTip(this.buttonDone_MSE, "Выполнить обработку данных");
            this.buttonDone_MSE.UseVisualStyleBackColor = false;
            this.buttonDone_MSE.Click += new System.EventHandler(this.buttonDone_MSE_Click);
            // 
            // buttonOpenFile_MSE
            // 
            this.buttonOpenFile_MSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonOpenFile_MSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_MSE.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenFile_MSE.Location = new System.Drawing.Point(2, 4);
            this.buttonOpenFile_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile_MSE.Name = "buttonOpenFile_MSE";
            this.buttonOpenFile_MSE.Size = new System.Drawing.Size(83, 62);
            this.buttonOpenFile_MSE.TabIndex = 0;
            this.buttonOpenFile_MSE.Text = "Открыть файл";
            this.toolTipButton_MSE.SetToolTip(this.buttonOpenFile_MSE, "Открыть файл для обработки данных в формале CSV");
            this.buttonOpenFile_MSE.UseVisualStyleBackColor = false;
            this.buttonOpenFile_MSE.Click += new System.EventHandler(this.buttonOpenFile_MSE_Click);
            // 
            // panelTwo_MSE
            // 
            this.panelTwo_MSE.Controls.Add(this.groupBoxUslovie_MSE);
            this.panelTwo_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_MSE.Location = new System.Drawing.Point(0, 72);
            this.panelTwo_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelTwo_MSE.Name = "panelTwo_MSE";
            this.panelTwo_MSE.Size = new System.Drawing.Size(626, 80);
            this.panelTwo_MSE.TabIndex = 1;
            // 
            // groupBoxUslovie_MSE
            // 
            this.groupBoxUslovie_MSE.Controls.Add(this.textBoxUslovie_MSE);
            this.groupBoxUslovie_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUslovie_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovie_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxUslovie_MSE.Name = "groupBoxUslovie_MSE";
            this.groupBoxUslovie_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxUslovie_MSE.Size = new System.Drawing.Size(626, 80);
            this.groupBoxUslovie_MSE.TabIndex = 0;
            this.groupBoxUslovie_MSE.TabStop = false;
            this.groupBoxUslovie_MSE.Text = "Условие:";
            // 
            // textBoxUslovie_MSE
            // 
            this.textBoxUslovie_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie_MSE.Location = new System.Drawing.Point(2, 15);
            this.textBoxUslovie_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUslovie_MSE.Multiline = true;
            this.textBoxUslovie_MSE.Name = "textBoxUslovie_MSE";
            this.textBoxUslovie_MSE.ReadOnly = true;
            this.textBoxUslovie_MSE.Size = new System.Drawing.Size(622, 63);
            this.textBoxUslovie_MSE.TabIndex = 0;
            this.textBoxUslovie_MSE.Text = "Дан файл InPutFileTask7V23.csv в котором хранится матрица целочисленных значений." +
    " Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в последн" +
    "ем столбце значения меньше 2 на 2";
            // 
            // panelThree_MSE
            // 
            this.panelThree_MSE.Controls.Add(this.groupBoxVvod_MSE);
            this.panelThree_MSE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_MSE.Location = new System.Drawing.Point(0, 152);
            this.panelThree_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelThree_MSE.Name = "panelThree_MSE";
            this.panelThree_MSE.Size = new System.Drawing.Size(298, 279);
            this.panelThree_MSE.TabIndex = 2;
            // 
            // groupBoxVvod_MSE
            // 
            this.groupBoxVvod_MSE.Controls.Add(this.dataGridViewIn_MSE);
            this.groupBoxVvod_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvod_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvod_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxVvod_MSE.Name = "groupBoxVvod_MSE";
            this.groupBoxVvod_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxVvod_MSE.Size = new System.Drawing.Size(298, 279);
            this.groupBoxVvod_MSE.TabIndex = 0;
            this.groupBoxVvod_MSE.TabStop = false;
            this.groupBoxVvod_MSE.Text = "Ввод:";
            // 
            // dataGridViewIn_MSE
            // 
            this.dataGridViewIn_MSE.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewIn_MSE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_MSE.ColumnHeadersVisible = false;
            this.dataGridViewIn_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_MSE.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewIn_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewIn_MSE.Name = "dataGridViewIn_MSE";
            this.dataGridViewIn_MSE.RowHeadersVisible = false;
            this.dataGridViewIn_MSE.RowHeadersWidth = 51;
            this.dataGridViewIn_MSE.RowTemplate.Height = 24;
            this.dataGridViewIn_MSE.Size = new System.Drawing.Size(294, 262);
            this.dataGridViewIn_MSE.TabIndex = 0;
            // 
            // panelFour_MSE
            // 
            this.panelFour_MSE.Controls.Add(this.groupBoxResult_MSE);
            this.panelFour_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_MSE.Location = new System.Drawing.Point(300, 152);
            this.panelFour_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelFour_MSE.Name = "panelFour_MSE";
            this.panelFour_MSE.Size = new System.Drawing.Size(326, 279);
            this.panelFour_MSE.TabIndex = 3;
            // 
            // groupBoxResult_MSE
            // 
            this.groupBoxResult_MSE.Controls.Add(this.dataGridViewOut_MSE);
            this.groupBoxResult_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_MSE.Name = "groupBoxResult_MSE";
            this.groupBoxResult_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_MSE.Size = new System.Drawing.Size(326, 279);
            this.groupBoxResult_MSE.TabIndex = 0;
            this.groupBoxResult_MSE.TabStop = false;
            this.groupBoxResult_MSE.Text = "Вывод:";
            // 
            // dataGridViewOut_MSE
            // 
            this.dataGridViewOut_MSE.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewOut_MSE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_MSE.ColumnHeadersVisible = false;
            this.dataGridViewOut_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_MSE.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewOut_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOut_MSE.Name = "dataGridViewOut_MSE";
            this.dataGridViewOut_MSE.RowHeadersVisible = false;
            this.dataGridViewOut_MSE.RowHeadersWidth = 51;
            this.dataGridViewOut_MSE.RowTemplate.Height = 24;
            this.dataGridViewOut_MSE.Size = new System.Drawing.Size(322, 262);
            this.dataGridViewOut_MSE.TabIndex = 0;
            // 
            // splitterOne_MSE
            // 
            this.splitterOne_MSE.Location = new System.Drawing.Point(298, 152);
            this.splitterOne_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.splitterOne_MSE.Name = "splitterOne_MSE";
            this.splitterOne_MSE.Size = new System.Drawing.Size(2, 279);
            this.splitterOne_MSE.TabIndex = 4;
            this.splitterOne_MSE.TabStop = false;
            // 
            // openFileDialogTask_MSE
            // 
            this.openFileDialogTask_MSE.FileName = "InPutFileTask7V23";
            // 
            // toolTipButton_MSE
            // 
            this.toolTipButton_MSE.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButton_MSE.IsBalloon = true;
            this.toolTipButton_MSE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_MSE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 431);
            this.Controls.Add(this.panelFour_MSE);
            this.Controls.Add(this.splitterOne_MSE);
            this.Controls.Add(this.panelThree_MSE);
            this.Controls.Add(this.panelTwo_MSE);
            this.Controls.Add(this.panelOne_MSE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(642, 462);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 23 | Мезенцев С.Е.";
            this.panelOne_MSE.ResumeLayout(false);
            this.panelTwo_MSE.ResumeLayout(false);
            this.groupBoxUslovie_MSE.ResumeLayout(false);
            this.groupBoxUslovie_MSE.PerformLayout();
            this.panelThree_MSE.ResumeLayout(false);
            this.groupBoxVvod_MSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MSE)).EndInit();
            this.panelFour_MSE.ResumeLayout(false);
            this.groupBoxResult_MSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_MSE;
        private System.Windows.Forms.Button buttonHelp_MSE;
        private System.Windows.Forms.Button buttonSave_MSE;
        private System.Windows.Forms.Button buttonDone_MSE;
        private System.Windows.Forms.Button buttonOpenFile_MSE;
        private System.Windows.Forms.Panel panelTwo_MSE;
        private System.Windows.Forms.Panel panelThree_MSE;
        private System.Windows.Forms.Panel panelFour_MSE;
        private System.Windows.Forms.Splitter splitterOne_MSE;
        private System.Windows.Forms.GroupBox groupBoxUslovie_MSE;
        private System.Windows.Forms.GroupBox groupBoxVvod_MSE;
        private System.Windows.Forms.GroupBox groupBoxResult_MSE;
        private System.Windows.Forms.TextBox textBoxUslovie_MSE;
        private System.Windows.Forms.DataGridView dataGridViewIn_MSE;
        private System.Windows.Forms.DataGridView dataGridViewOut_MSE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MSE;
        private System.Windows.Forms.ToolTip toolTipButton_MSE;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_MSE;
    }
}

