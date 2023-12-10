
namespace Tyuiu.MezentsevSE.Sprint6.Task4.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelUp_MSE = new System.Windows.Forms.Panel();
            this.buttonInfo_MSE = new System.Windows.Forms.Button();
            this.buttonSave_MSE = new System.Windows.Forms.Button();
            this.buttonDone_MSE = new System.Windows.Forms.Button();
            this.groupBoxInput_MSE = new System.Windows.Forms.GroupBox();
            this.labelStop_MSE = new System.Windows.Forms.TextBox();
            this.labelStart_MSE = new System.Windows.Forms.TextBox();
            this.textBoxStop_MSE = new System.Windows.Forms.TextBox();
            this.textBoxStart_MSE = new System.Windows.Forms.TextBox();
            this.groupBoxTask_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MSE = new System.Windows.Forms.TextBox();
            this.panelCentre_MSE = new System.Windows.Forms.Panel();
            this.chartFunc_MSE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft_MSE = new System.Windows.Forms.Panel();
            this.groupBoxRes_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxDone_MSE = new System.Windows.Forms.TextBox();
            this.splitterA_MSE = new System.Windows.Forms.Splitter();
            this.panelUp_MSE.SuspendLayout();
            this.groupBoxInput_MSE.SuspendLayout();
            this.groupBoxTask_MSE.SuspendLayout();
            this.panelCentre_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MSE)).BeginInit();
            this.panelLeft_MSE.SuspendLayout();
            this.groupBoxRes_MSE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp_MSE
            // 
            this.panelUp_MSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUp_MSE.Controls.Add(this.buttonInfo_MSE);
            this.panelUp_MSE.Controls.Add(this.buttonSave_MSE);
            this.panelUp_MSE.Controls.Add(this.buttonDone_MSE);
            this.panelUp_MSE.Controls.Add(this.groupBoxInput_MSE);
            this.panelUp_MSE.Controls.Add(this.groupBoxTask_MSE);
            this.panelUp_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_MSE.Location = new System.Drawing.Point(0, 0);
            this.panelUp_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelUp_MSE.Name = "panelUp_MSE";
            this.panelUp_MSE.Size = new System.Drawing.Size(718, 93);
            this.panelUp_MSE.TabIndex = 0;
            // 
            // buttonInfo_MSE
            // 
            this.buttonInfo_MSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_MSE.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_MSE.Location = new System.Drawing.Point(637, 8);
            this.buttonInfo_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_MSE.Name = "buttonInfo_MSE";
            this.buttonInfo_MSE.Size = new System.Drawing.Size(73, 79);
            this.buttonInfo_MSE.TabIndex = 2;
            this.buttonInfo_MSE.Text = "Справка";
            this.buttonInfo_MSE.UseVisualStyleBackColor = false;
            this.buttonInfo_MSE.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSave_MSE
            // 
            this.buttonSave_MSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSave_MSE.Location = new System.Drawing.Point(546, 8);
            this.buttonSave_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave_MSE.Name = "buttonSave_MSE";
            this.buttonSave_MSE.Size = new System.Drawing.Size(73, 79);
            this.buttonSave_MSE.TabIndex = 2;
            this.buttonSave_MSE.Text = "Сохранить";
            this.buttonSave_MSE.UseVisualStyleBackColor = false;
            this.buttonSave_MSE.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDone_MSE
            // 
            this.buttonDone_MSE.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_MSE.Location = new System.Drawing.Point(454, 8);
            this.buttonDone_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_MSE.Name = "buttonDone_MSE";
            this.buttonDone_MSE.Size = new System.Drawing.Size(75, 79);
            this.buttonDone_MSE.TabIndex = 2;
            this.buttonDone_MSE.Text = "Выполнить";
            this.buttonDone_MSE.UseVisualStyleBackColor = false;
            this.buttonDone_MSE.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxInput_MSE
            // 
            this.groupBoxInput_MSE.Controls.Add(this.labelStop_MSE);
            this.groupBoxInput_MSE.Controls.Add(this.labelStart_MSE);
            this.groupBoxInput_MSE.Controls.Add(this.textBoxStop_MSE);
            this.groupBoxInput_MSE.Controls.Add(this.textBoxStart_MSE);
            this.groupBoxInput_MSE.Location = new System.Drawing.Point(291, 0);
            this.groupBoxInput_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_MSE.Name = "groupBoxInput_MSE";
            this.groupBoxInput_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInput_MSE.Size = new System.Drawing.Size(159, 89);
            this.groupBoxInput_MSE.TabIndex = 1;
            this.groupBoxInput_MSE.TabStop = false;
            this.groupBoxInput_MSE.Text = "Ввод данных:";
            // 
            // labelStop_MSE
            // 
            this.labelStop_MSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStop_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelStop_MSE.Location = new System.Drawing.Point(85, 45);
            this.labelStop_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.labelStop_MSE.Name = "labelStop_MSE";
            this.labelStop_MSE.ReadOnly = true;
            this.labelStop_MSE.Size = new System.Drawing.Size(67, 13);
            this.labelStop_MSE.TabIndex = 0;
            this.labelStop_MSE.Text = "Конец шага:";
            // 
            // labelStart_MSE
            // 
            this.labelStart_MSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStart_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelStart_MSE.Location = new System.Drawing.Point(2, 45);
            this.labelStart_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.labelStart_MSE.Name = "labelStart_MSE";
            this.labelStart_MSE.ReadOnly = true;
            this.labelStart_MSE.Size = new System.Drawing.Size(67, 13);
            this.labelStart_MSE.TabIndex = 0;
            this.labelStart_MSE.Text = "Старт шага:";
            // 
            // textBoxStop_MSE
            // 
            this.textBoxStop_MSE.Location = new System.Drawing.Point(85, 66);
            this.textBoxStop_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStop_MSE.Name = "textBoxStop_MSE";
            this.textBoxStop_MSE.Size = new System.Drawing.Size(68, 20);
            this.textBoxStop_MSE.TabIndex = 0;
            // 
            // textBoxStart_MSE
            // 
            this.textBoxStart_MSE.Location = new System.Drawing.Point(2, 66);
            this.textBoxStart_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStart_MSE.Name = "textBoxStart_MSE";
            this.textBoxStart_MSE.Size = new System.Drawing.Size(68, 20);
            this.textBoxStart_MSE.TabIndex = 0;
            // 
            // groupBoxTask_MSE
            // 
            this.groupBoxTask_MSE.Controls.Add(this.textBoxTask_MSE);
            this.groupBoxTask_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_MSE.Name = "groupBoxTask_MSE";
            this.groupBoxTask_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_MSE.Size = new System.Drawing.Size(291, 89);
            this.groupBoxTask_MSE.TabIndex = 0;
            this.groupBoxTask_MSE.TabStop = false;
            this.groupBoxTask_MSE.Text = "Условие";
            // 
            // textBoxTask_MSE
            // 
            this.textBoxTask_MSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxTask_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_MSE.Location = new System.Drawing.Point(2, 15);
            this.textBoxTask_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_MSE.Multiline = true;
            this.textBoxTask_MSE.Name = "textBoxTask_MSE";
            this.textBoxTask_MSE.ReadOnly = true;
            this.textBoxTask_MSE.Size = new System.Drawing.Size(287, 72);
            this.textBoxTask_MSE.TabIndex = 0;
            this.textBoxTask_MSE.Text = "Протабулировать функцию (5*x+2,5) / (Sin(x)-2) + 2 на заданном диапазоне от -5 до" +
    " 5. Результат вывести в textBox, построить график функции и сохранить в файл Out" +
    "PutFileTask4V19.txt по нажатию кнопки.\n";
            // 
            // panelCentre_MSE
            // 
            this.panelCentre_MSE.BackColor = System.Drawing.SystemColors.Control;
            this.panelCentre_MSE.Controls.Add(this.chartFunc_MSE);
            this.panelCentre_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre_MSE.Location = new System.Drawing.Point(0, 93);
            this.panelCentre_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelCentre_MSE.Name = "panelCentre_MSE";
            this.panelCentre_MSE.Size = new System.Drawing.Size(718, 259);
            this.panelCentre_MSE.TabIndex = 0;
            // 
            // chartFunc_MSE
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunc_MSE.ChartAreas.Add(chartArea3);
            this.chartFunc_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartFunc_MSE.Legends.Add(legend3);
            this.chartFunc_MSE.Location = new System.Drawing.Point(0, 0);
            this.chartFunc_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.chartFunc_MSE.Name = "chartFunc_MSE";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunc_MSE.Series.Add(series3);
            this.chartFunc_MSE.Size = new System.Drawing.Size(718, 259);
            this.chartFunc_MSE.TabIndex = 0;
            this.chartFunc_MSE.Text = "chartFunc";
            title3.Name = "TitleFunc";
            title3.Text = "График функции (5*x+2,5) / (Sin(x)-2) + 2 ";
            this.chartFunc_MSE.Titles.Add(title3);
            // 
            // panelLeft_MSE
            // 
            this.panelLeft_MSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLeft_MSE.Controls.Add(this.groupBoxRes_MSE);
            this.panelLeft_MSE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MSE.Location = new System.Drawing.Point(0, 93);
            this.panelLeft_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft_MSE.Name = "panelLeft_MSE";
            this.panelLeft_MSE.Size = new System.Drawing.Size(133, 259);
            this.panelLeft_MSE.TabIndex = 0;
            // 
            // groupBoxRes_MSE
            // 
            this.groupBoxRes_MSE.Controls.Add(this.textBoxDone_MSE);
            this.groupBoxRes_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRes_MSE.Name = "groupBoxRes_MSE";
            this.groupBoxRes_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRes_MSE.Size = new System.Drawing.Size(133, 259);
            this.groupBoxRes_MSE.TabIndex = 0;
            this.groupBoxRes_MSE.TabStop = false;
            this.groupBoxRes_MSE.Text = "Вывод";
            // 
            // textBoxDone_MSE
            // 
            this.textBoxDone_MSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDone_MSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDone_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDone_MSE.Location = new System.Drawing.Point(2, 15);
            this.textBoxDone_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDone_MSE.Multiline = true;
            this.textBoxDone_MSE.Name = "textBoxDone_MSE";
            this.textBoxDone_MSE.ReadOnly = true;
            this.textBoxDone_MSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDone_MSE.Size = new System.Drawing.Size(129, 242);
            this.textBoxDone_MSE.TabIndex = 0;
            // 
            // splitterA_MSE
            // 
            this.splitterA_MSE.Location = new System.Drawing.Point(133, 93);
            this.splitterA_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.splitterA_MSE.Name = "splitterA_MSE";
            this.splitterA_MSE.Size = new System.Drawing.Size(2, 259);
            this.splitterA_MSE.TabIndex = 1;
            this.splitterA_MSE.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 352);
            this.Controls.Add(this.splitterA_MSE);
            this.Controls.Add(this.panelLeft_MSE);
            this.Controls.Add(this.panelCentre_MSE);
            this.Controls.Add(this.panelUp_MSE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(734, 391);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Мезенцев С.Е.|";
            this.panelUp_MSE.ResumeLayout(false);
            this.groupBoxInput_MSE.ResumeLayout(false);
            this.groupBoxInput_MSE.PerformLayout();
            this.groupBoxTask_MSE.ResumeLayout(false);
            this.groupBoxTask_MSE.PerformLayout();
            this.panelCentre_MSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MSE)).EndInit();
            this.panelLeft_MSE.ResumeLayout(false);
            this.groupBoxRes_MSE.ResumeLayout(false);
            this.groupBoxRes_MSE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_MSE;
        private System.Windows.Forms.Panel panelCentre_MSE;
        private System.Windows.Forms.Panel panelLeft_MSE;
        private System.Windows.Forms.Splitter splitterA_MSE;
        private System.Windows.Forms.GroupBox groupBoxTask_MSE;
        private System.Windows.Forms.GroupBox groupBoxRes_MSE;
        private System.Windows.Forms.GroupBox groupBoxInput_MSE;
        private System.Windows.Forms.TextBox labelStop_MSE;
        private System.Windows.Forms.TextBox labelStart_MSE;
        private System.Windows.Forms.TextBox textBoxStop_MSE;
        private System.Windows.Forms.TextBox textBoxStart_MSE;
        private System.Windows.Forms.TextBox textBoxTask_MSE;
        private System.Windows.Forms.TextBox textBoxDone_MSE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_MSE;
        private System.Windows.Forms.Button buttonInfo_MSE;
        private System.Windows.Forms.Button buttonSave_MSE;
        private System.Windows.Forms.Button buttonDone_MSE;
    }
}

