
namespace Tyuiu.MezentsevSE.Sprint6.Task5.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelFirst_MSE = new System.Windows.Forms.Panel();
            this.buttonInfo_MSE = new System.Windows.Forms.Button();
            this.buttonOpenFile_MSE = new System.Windows.Forms.Button();
            this.buttonDone_MSE = new System.Windows.Forms.Button();
            this.groupBoxCondition_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MSE = new System.Windows.Forms.TextBox();
            this.panelSecond_MSE = new System.Windows.Forms.Panel();
            this.groupBoxDataOutPut_MSE = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_MSE = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelThird_MSE = new System.Windows.Forms.Panel();
            this.chartDiag_MSE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFirst_MSE.SuspendLayout();
            this.groupBoxCondition_MSE.SuspendLayout();
            this.panelSecond_MSE.SuspendLayout();
            this.groupBoxDataOutPut_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MSE)).BeginInit();
            this.panelThird_MSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MSE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFirst_MSE
            // 
            this.panelFirst_MSE.BackColor = System.Drawing.Color.White;
            this.panelFirst_MSE.Controls.Add(this.buttonInfo_MSE);
            this.panelFirst_MSE.Controls.Add(this.buttonOpenFile_MSE);
            this.panelFirst_MSE.Controls.Add(this.buttonDone_MSE);
            this.panelFirst_MSE.Controls.Add(this.groupBoxCondition_MSE);
            this.panelFirst_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFirst_MSE.Location = new System.Drawing.Point(0, 0);
            this.panelFirst_MSE.Name = "panelFirst_MSE";
            this.panelFirst_MSE.Size = new System.Drawing.Size(1101, 100);
            this.panelFirst_MSE.TabIndex = 0;
            // 
            // buttonInfo_MSE
            // 
            this.buttonInfo_MSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_MSE.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_MSE.ForeColor = System.Drawing.Color.White;
            this.buttonInfo_MSE.Location = new System.Drawing.Point(954, 12);
            this.buttonInfo_MSE.Name = "buttonInfo_MSE";
            this.buttonInfo_MSE.Size = new System.Drawing.Size(93, 78);
            this.buttonInfo_MSE.TabIndex = 1;
            this.buttonInfo_MSE.Text = "Справка";
            this.buttonInfo_MSE.UseVisualStyleBackColor = false;
            this.buttonInfo_MSE.Click += new System.EventHandler(this.buttonInfo_MSE_Click);
            this.buttonInfo_MSE.MouseLeave += new System.EventHandler(this.buttonInfo_MSE_MouseLeave);
            this.buttonInfo_MSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonInfo_MSE_MouseMove);
            // 
            // buttonOpenFile_MSE
            // 
            this.buttonOpenFile_MSE.BackColor = System.Drawing.Color.Orchid;
            this.buttonOpenFile_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_MSE.Location = new System.Drawing.Point(842, 13);
            this.buttonOpenFile_MSE.Name = "buttonOpenFile_MSE";
            this.buttonOpenFile_MSE.Size = new System.Drawing.Size(93, 78);
            this.buttonOpenFile_MSE.TabIndex = 1;
            this.buttonOpenFile_MSE.Text = "Открыть файл";
            this.buttonOpenFile_MSE.UseVisualStyleBackColor = false;
            this.buttonOpenFile_MSE.Click += new System.EventHandler(this.buttonOpenFile_MSE_Click);
            this.buttonOpenFile_MSE.MouseLeave += new System.EventHandler(this.buttonOpenFile_MSE_MouseLeave);
            this.buttonOpenFile_MSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_MSE_MouseMove);
            // 
            // buttonDone_MSE
            // 
            this.buttonDone_MSE.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_MSE.Location = new System.Drawing.Point(722, 12);
            this.buttonDone_MSE.Name = "buttonDone_MSE";
            this.buttonDone_MSE.Size = new System.Drawing.Size(93, 78);
            this.buttonDone_MSE.TabIndex = 1;
            this.buttonDone_MSE.Text = "Выполнить";
            this.buttonDone_MSE.UseVisualStyleBackColor = false;
            this.buttonDone_MSE.Click += new System.EventHandler(this.buttonDone_MSE_Click);
            this.buttonDone_MSE.MouseLeave += new System.EventHandler(this.buttonDone_MSE_MouseLeave);
            this.buttonDone_MSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MSE_MouseMove);
            // 
            // groupBoxCondition_MSE
            // 
            this.groupBoxCondition_MSE.Controls.Add(this.textBoxTask_MSE);
            this.groupBoxCondition_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_MSE.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition_MSE.Name = "groupBoxCondition_MSE";
            this.groupBoxCondition_MSE.Size = new System.Drawing.Size(662, 90);
            this.groupBoxCondition_MSE.TabIndex = 0;
            this.groupBoxCondition_MSE.TabStop = false;
            this.groupBoxCondition_MSE.Text = "Условие:";
            // 
            // textBoxTask_MSE
            // 
            this.textBoxTask_MSE.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask_MSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_MSE.Location = new System.Drawing.Point(3, 19);
            this.textBoxTask_MSE.Multiline = true;
            this.textBoxTask_MSE.Name = "textBoxTask_MSE";
            this.textBoxTask_MSE.ReadOnly = true;
            this.textBoxTask_MSE.Size = new System.Drawing.Size(656, 68);
            this.textBoxTask_MSE.TabIndex = 0;
            this.textBoxTask_MSE.TabStop = false;
            this.textBoxTask_MSE.Text = "Прочитать данные из файла InPutFileTask5V12.txt. Вывести в DataGridView\r\nвсе числ" +
    "а не кратные 5 и построить диаграмму по этим значениям.";
            // 
            // panelSecond_MSE
            // 
            this.panelSecond_MSE.BackColor = System.Drawing.Color.Fuchsia;
            this.panelSecond_MSE.Controls.Add(this.groupBoxDataOutPut_MSE);
            this.panelSecond_MSE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSecond_MSE.Location = new System.Drawing.Point(0, 100);
            this.panelSecond_MSE.Name = "panelSecond_MSE";
            this.panelSecond_MSE.Size = new System.Drawing.Size(200, 493);
            this.panelSecond_MSE.TabIndex = 1;
            // 
            // groupBoxDataOutPut_MSE
            // 
            this.groupBoxDataOutPut_MSE.BackColor = System.Drawing.Color.Crimson;
            this.groupBoxDataOutPut_MSE.Controls.Add(this.dataGridViewResult_MSE);
            this.groupBoxDataOutPut_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOutPut_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataOutPut_MSE.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDataOutPut_MSE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOutPut_MSE.Name = "groupBoxDataOutPut_MSE";
            this.groupBoxDataOutPut_MSE.Size = new System.Drawing.Size(200, 493);
            this.groupBoxDataOutPut_MSE.TabIndex = 0;
            this.groupBoxDataOutPut_MSE.TabStop = false;
            this.groupBoxDataOutPut_MSE.Text = "Вывод данных:";
            // 
            // dataGridViewResult_MSE
            // 
            this.dataGridViewResult_MSE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_MSE.ColumnHeadersVisible = false;
            this.dataGridViewResult_MSE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_MSE.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewResult_MSE.Name = "dataGridViewResult_MSE";
            this.dataGridViewResult_MSE.ReadOnly = true;
            this.dataGridViewResult_MSE.RowHeadersVisible = false;
            this.dataGridViewResult_MSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_MSE.Size = new System.Drawing.Size(194, 471);
            this.dataGridViewResult_MSE.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // panelThird_MSE
            // 
            this.panelThird_MSE.BackColor = System.Drawing.Color.Lime;
            this.panelThird_MSE.Controls.Add(this.chartDiag_MSE);
            this.panelThird_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThird_MSE.Location = new System.Drawing.Point(200, 100);
            this.panelThird_MSE.Name = "panelThird_MSE";
            this.panelThird_MSE.Size = new System.Drawing.Size(901, 493);
            this.panelThird_MSE.TabIndex = 2;
            // 
            // chartDiag_MSE
            // 
            chartArea10.Name = "ChartArea1";
            this.chartDiag_MSE.ChartAreas.Add(chartArea10);
            this.chartDiag_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartDiag_MSE.Legends.Add(legend10);
            this.chartDiag_MSE.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_MSE.Name = "chartDiag_MSE";
            this.chartDiag_MSE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series10.ChartArea = "ChartArea1";
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartDiag_MSE.Series.Add(series10);
            this.chartDiag_MSE.Size = new System.Drawing.Size(901, 493);
            this.chartDiag_MSE.TabIndex = 0;
            this.chartDiag_MSE.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 593);
            this.Controls.Add(this.panelThird_MSE);
            this.Controls.Add(this.panelSecond_MSE);
            this.Controls.Add(this.panelFirst_MSE);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 12 | Мезенцев С.Е.";
            this.panelFirst_MSE.ResumeLayout(false);
            this.groupBoxCondition_MSE.ResumeLayout(false);
            this.groupBoxCondition_MSE.PerformLayout();
            this.panelSecond_MSE.ResumeLayout(false);
            this.groupBoxDataOutPut_MSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MSE)).EndInit();
            this.panelThird_MSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFirst_MSE;
        private System.Windows.Forms.Button buttonInfo_MSE;
        private System.Windows.Forms.Button buttonOpenFile_MSE;
        private System.Windows.Forms.Button buttonDone_MSE;
        private System.Windows.Forms.GroupBox groupBoxCondition_MSE;
        private System.Windows.Forms.TextBox textBoxTask_MSE;
        private System.Windows.Forms.Panel panelSecond_MSE;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_MSE;
        private System.Windows.Forms.DataGridView dataGridViewResult_MSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panelThird_MSE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_MSE;
    }
}

