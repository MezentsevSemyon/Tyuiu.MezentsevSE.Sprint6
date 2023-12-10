
namespace Tyuiu.MezentsevSE.Sprint6.Task2.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MSE = new System.Windows.Forms.TextBox();
            this.labelTask_MSE = new System.Windows.Forms.Label();
            this.groupBoxVVod_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxStop_MSE = new System.Windows.Forms.TextBox();
            this.textBoxStart_MSE = new System.Windows.Forms.TextBox();
            this.labelStop_MSE = new System.Windows.Forms.Label();
            this.labelStart_MSE = new System.Windows.Forms.Label();
            this.buttonInfo_MSE = new System.Windows.Forms.Button();
            this.buttonRes_MSE = new System.Windows.Forms.Button();
            this.groupBoxAns_MSE = new System.Windows.Forms.GroupBox();
            this.chartFunction_MSE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_MSE = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRes_MSE = new System.Windows.Forms.Label();
            this.groupBoxTask_MSE.SuspendLayout();
            this.groupBoxVVod_MSE.SuspendLayout();
            this.groupBoxAns_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MSE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MSE
            // 
            this.groupBoxTask_MSE.Controls.Add(this.textBoxTask_MSE);
            this.groupBoxTask_MSE.Controls.Add(this.labelTask_MSE);
            this.groupBoxTask_MSE.Location = new System.Drawing.Point(9, 10);
            this.groupBoxTask_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_MSE.Name = "groupBoxTask_MSE";
            this.groupBoxTask_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_MSE.Size = new System.Drawing.Size(427, 278);
            this.groupBoxTask_MSE.TabIndex = 0;
            this.groupBoxTask_MSE.TabStop = false;
            this.groupBoxTask_MSE.Text = "Условие";
            // 
            // textBoxTask_MSE
            // 
            this.textBoxTask_MSE.Location = new System.Drawing.Point(4, 17);
            this.textBoxTask_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_MSE.Multiline = true;
            this.textBoxTask_MSE.Name = "textBoxTask_MSE";
            this.textBoxTask_MSE.ReadOnly = true;
            this.textBoxTask_MSE.Size = new System.Drawing.Size(419, 257);
            this.textBoxTask_MSE.TabIndex = 1;
            this.textBoxTask_MSE.Text = " Протабулировать функцию cos(x))/(x-0.7))-sin(x)*12*x+2 на заданном диапазоне. Ре" +
    "зультат вывести  в DataGridView и построить график функции.";
            // 
            // labelTask_MSE
            // 
            this.labelTask_MSE.AutoSize = true;
            this.labelTask_MSE.Location = new System.Drawing.Point(56, 47);
            this.labelTask_MSE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTask_MSE.Name = "labelTask_MSE";
            this.labelTask_MSE.Size = new System.Drawing.Size(7, 26);
            this.labelTask_MSE.TabIndex = 0;
            this.labelTask_MSE.Text = "\r\n\r\n";
            // 
            // groupBoxVVod_MSE
            // 
            this.groupBoxVVod_MSE.Controls.Add(this.textBoxStop_MSE);
            this.groupBoxVVod_MSE.Controls.Add(this.textBoxStart_MSE);
            this.groupBoxVVod_MSE.Controls.Add(this.labelStop_MSE);
            this.groupBoxVVod_MSE.Controls.Add(this.labelStart_MSE);
            this.groupBoxVVod_MSE.Location = new System.Drawing.Point(14, 292);
            this.groupBoxVVod_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxVVod_MSE.Name = "groupBoxVVod_MSE";
            this.groupBoxVVod_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxVVod_MSE.Size = new System.Drawing.Size(228, 63);
            this.groupBoxVVod_MSE.TabIndex = 1;
            this.groupBoxVVod_MSE.TabStop = false;
            this.groupBoxVVod_MSE.Text = "Ввод данных";
            // 
            // textBoxStop_MSE
            // 
            this.textBoxStop_MSE.Location = new System.Drawing.Point(134, 35);
            this.textBoxStop_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStop_MSE.Name = "textBoxStop_MSE";
            this.textBoxStop_MSE.Size = new System.Drawing.Size(76, 20);
            this.textBoxStop_MSE.TabIndex = 3;
            // 
            // textBoxStart_MSE
            // 
            this.textBoxStart_MSE.Location = new System.Drawing.Point(8, 35);
            this.textBoxStart_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStart_MSE.Name = "textBoxStart_MSE";
            this.textBoxStart_MSE.Size = new System.Drawing.Size(76, 20);
            this.textBoxStart_MSE.TabIndex = 2;
            // 
            // labelStop_MSE
            // 
            this.labelStop_MSE.AutoSize = true;
            this.labelStop_MSE.Location = new System.Drawing.Point(132, 18);
            this.labelStop_MSE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStop_MSE.Name = "labelStop_MSE";
            this.labelStop_MSE.Size = new System.Drawing.Size(69, 13);
            this.labelStop_MSE.TabIndex = 1;
            this.labelStop_MSE.Text = "Конец шага:";
            // 
            // labelStart_MSE
            // 
            this.labelStart_MSE.AutoSize = true;
            this.labelStart_MSE.Location = new System.Drawing.Point(5, 18);
            this.labelStart_MSE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStart_MSE.Name = "labelStart_MSE";
            this.labelStart_MSE.Size = new System.Drawing.Size(67, 13);
            this.labelStart_MSE.TabIndex = 0;
            this.labelStart_MSE.Text = "Старт шага:";
            // 
            // buttonInfo_MSE
            // 
            this.buttonInfo_MSE.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_MSE.Location = new System.Drawing.Point(246, 292);
            this.buttonInfo_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_MSE.Name = "buttonInfo_MSE";
            this.buttonInfo_MSE.Size = new System.Drawing.Size(82, 63);
            this.buttonInfo_MSE.TabIndex = 2;
            this.buttonInfo_MSE.Text = "Справка";
            this.buttonInfo_MSE.UseVisualStyleBackColor = false;
            this.buttonInfo_MSE.Click += new System.EventHandler(this.buttonInfo_MSE_Click);
            // 
            // buttonRes_MSE
            // 
            this.buttonRes_MSE.BackColor = System.Drawing.Color.Green;
            this.buttonRes_MSE.Location = new System.Drawing.Point(333, 292);
            this.buttonRes_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRes_MSE.Name = "buttonRes_MSE";
            this.buttonRes_MSE.Size = new System.Drawing.Size(103, 63);
            this.buttonRes_MSE.TabIndex = 3;
            this.buttonRes_MSE.Text = "Выполнить";
            this.buttonRes_MSE.UseVisualStyleBackColor = false;
            this.buttonRes_MSE.Click += new System.EventHandler(this.buttonRes_MSE_Click);
            this.buttonRes_MSE.MouseEnter += new System.EventHandler(this.buttonRes_MSE_MouseEnter);
            this.buttonRes_MSE.MouseLeave += new System.EventHandler(this.buttonRes_MSE_MouseLeave);
            // 
            // groupBoxAns_MSE
            // 
            this.groupBoxAns_MSE.Controls.Add(this.chartFunction_MSE);
            this.groupBoxAns_MSE.Controls.Add(this.dataGridViewFunction_MSE);
            this.groupBoxAns_MSE.Controls.Add(this.labelRes_MSE);
            this.groupBoxAns_MSE.Location = new System.Drawing.Point(440, 10);
            this.groupBoxAns_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAns_MSE.Name = "groupBoxAns_MSE";
            this.groupBoxAns_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAns_MSE.Size = new System.Drawing.Size(520, 352);
            this.groupBoxAns_MSE.TabIndex = 4;
            this.groupBoxAns_MSE.TabStop = false;
            this.groupBoxAns_MSE.Text = "Вывод данных";
            // 
            // chartFunction_MSE
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_MSE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_MSE.Legends.Add(legend2);
            this.chartFunction_MSE.Location = new System.Drawing.Point(128, 33);
            this.chartFunction_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.chartFunction_MSE.Name = "chartFunction_MSE";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_MSE.Series.Add(series2);
            this.chartFunction_MSE.Size = new System.Drawing.Size(387, 314);
            this.chartFunction_MSE.TabIndex = 2;
            this.chartFunction_MSE.Text = "chart1";
            // 
            // dataGridViewFunction_MSE
            // 
            this.dataGridViewFunction_MSE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_MSE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_MSE.Location = new System.Drawing.Point(7, 33);
            this.dataGridViewFunction_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFunction_MSE.Name = "dataGridViewFunction_MSE";
            this.dataGridViewFunction_MSE.RowHeadersVisible = false;
            this.dataGridViewFunction_MSE.RowHeadersWidth = 51;
            this.dataGridViewFunction_MSE.RowTemplate.Height = 24;
            this.dataGridViewFunction_MSE.Size = new System.Drawing.Size(117, 312);
            this.dataGridViewFunction_MSE.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(x)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // labelRes_MSE
            // 
            this.labelRes_MSE.AutoSize = true;
            this.labelRes_MSE.Location = new System.Drawing.Point(4, 17);
            this.labelRes_MSE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRes_MSE.Name = "labelRes_MSE";
            this.labelRes_MSE.Size = new System.Drawing.Size(62, 13);
            this.labelRes_MSE.TabIndex = 0;
            this.labelRes_MSE.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 366);
            this.Controls.Add(this.groupBoxAns_MSE);
            this.Controls.Add(this.buttonRes_MSE);
            this.Controls.Add(this.buttonInfo_MSE);
            this.Controls.Add(this.groupBoxVVod_MSE);
            this.Controls.Add(this.groupBoxTask_MSE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Спринт 6| Таск 2| Вариант 6| Мезенцев С.Е.";
            this.groupBoxTask_MSE.ResumeLayout(false);
            this.groupBoxTask_MSE.PerformLayout();
            this.groupBoxVVod_MSE.ResumeLayout(false);
            this.groupBoxVVod_MSE.PerformLayout();
            this.groupBoxAns_MSE.ResumeLayout(false);
            this.groupBoxAns_MSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MSE;
        private System.Windows.Forms.TextBox textBoxTask_MSE;
        private System.Windows.Forms.Label labelTask_MSE;
        private System.Windows.Forms.GroupBox groupBoxVVod_MSE;
        private System.Windows.Forms.TextBox textBoxStop_MSE;
        private System.Windows.Forms.TextBox textBoxStart_MSE;
        private System.Windows.Forms.Label labelStop_MSE;
        private System.Windows.Forms.Label labelStart_MSE;
        private System.Windows.Forms.Button buttonInfo_MSE;
        private System.Windows.Forms.Button buttonRes_MSE;
        private System.Windows.Forms.GroupBox groupBoxAns_MSE;
        private System.Windows.Forms.DataGridView dataGridViewFunction_MSE;
        private System.Windows.Forms.Label labelRes_MSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MSE;
    }
}

