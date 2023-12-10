
namespace Tyuiu.MezentsevSE.Sprint6.Task6.V24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_MSE = new System.Windows.Forms.Panel();
            this.groupBoxTask_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MSE = new System.Windows.Forms.TextBox();
            this.panelTopButtons_MSE = new System.Windows.Forms.Panel();
            this.buttonHelp_MSE = new System.Windows.Forms.Button();
            this.buttonDone_MSE = new System.Windows.Forms.Button();
            this.buttonOpenFile_MSE = new System.Windows.Forms.Button();
            this.panelLeft_MSE = new System.Windows.Forms.Panel();
            this.groupBoxEnter_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxEnter_MSE = new System.Windows.Forms.TextBox();
            this.splitterLeftRight_MSE = new System.Windows.Forms.Splitter();
            this.panelRight_MSE = new System.Windows.Forms.Panel();
            this.groupBoxResult_MSE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MSE = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MSE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MSE = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_MSE.SuspendLayout();
            this.groupBoxTask_MSE.SuspendLayout();
            this.panelTopButtons_MSE.SuspendLayout();
            this.panelLeft_MSE.SuspendLayout();
            this.groupBoxEnter_MSE.SuspendLayout();
            this.panelRight_MSE.SuspendLayout();
            this.groupBoxResult_MSE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_MSE
            // 
            this.panelTop_MSE.Controls.Add(this.groupBoxTask_MSE);
            this.panelTop_MSE.Controls.Add(this.panelTopButtons_MSE);
            this.panelTop_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MSE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop_MSE.Name = "panelTop_MSE";
            this.panelTop_MSE.Size = new System.Drawing.Size(638, 151);
            this.panelTop_MSE.TabIndex = 0;
            // 
            // groupBoxTask_MSE
            // 
            this.groupBoxTask_MSE.Controls.Add(this.textBoxTask_MSE);
            this.groupBoxTask_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_MSE.Location = new System.Drawing.Point(0, 78);
            this.groupBoxTask_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_MSE.Name = "groupBoxTask_MSE";
            this.groupBoxTask_MSE.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTask_MSE.Size = new System.Drawing.Size(638, 73);
            this.groupBoxTask_MSE.TabIndex = 2;
            this.groupBoxTask_MSE.TabStop = false;
            this.groupBoxTask_MSE.Text = "Условие:";
            // 
            // textBoxTask_MSE
            // 
            this.textBoxTask_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_MSE.Location = new System.Drawing.Point(4, 17);
            this.textBoxTask_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_MSE.Multiline = true;
            this.textBoxTask_MSE.Name = "textBoxTask_MSE";
            this.textBoxTask_MSE.ReadOnly = true;
            this.textBoxTask_MSE.Size = new System.Drawing.Size(630, 52);
            this.textBoxTask_MSE.TabIndex = 0;
            this.textBoxTask_MSE.Text = resources.GetString("textBoxTask_MSE.Text");
            // 
            // panelTopButtons_MSE
            // 
            this.panelTopButtons_MSE.Controls.Add(this.buttonHelp_MSE);
            this.panelTopButtons_MSE.Controls.Add(this.buttonDone_MSE);
            this.panelTopButtons_MSE.Controls.Add(this.buttonOpenFile_MSE);
            this.panelTopButtons_MSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButtons_MSE.Location = new System.Drawing.Point(0, 0);
            this.panelTopButtons_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelTopButtons_MSE.Name = "panelTopButtons_MSE";
            this.panelTopButtons_MSE.Size = new System.Drawing.Size(638, 78);
            this.panelTopButtons_MSE.TabIndex = 1;
            // 
            // buttonHelp_MSE
            // 
            this.buttonHelp_MSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MSE.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_MSE.Location = new System.Drawing.Point(558, 3);
            this.buttonHelp_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_MSE.Name = "buttonHelp_MSE";
            this.buttonHelp_MSE.Size = new System.Drawing.Size(76, 72);
            this.buttonHelp_MSE.TabIndex = 2;
            this.buttonHelp_MSE.Text = "Справка";
            this.toolTip_MSE.SetToolTip(this.buttonHelp_MSE, "Сведение о программе");
            this.buttonHelp_MSE.UseVisualStyleBackColor = false;
            this.buttonHelp_MSE.Click += new System.EventHandler(this.buttonHelp_MSE_Click);
            // 
            // buttonDone_MSE
            // 
            this.buttonDone_MSE.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonDone_MSE.Enabled = false;
            this.buttonDone_MSE.Location = new System.Drawing.Point(83, 3);
            this.buttonDone_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_MSE.Name = "buttonDone_MSE";
            this.buttonDone_MSE.Size = new System.Drawing.Size(76, 72);
            this.buttonDone_MSE.TabIndex = 1;
            this.buttonDone_MSE.Text = "Выполнить";
            this.toolTip_MSE.SetToolTip(this.buttonDone_MSE, "Выводит первое слово каждой строки в результирующую строку");
            this.buttonDone_MSE.UseVisualStyleBackColor = false;
            this.buttonDone_MSE.Click += new System.EventHandler(this.buttonDone_MSE_Click);
            // 
            // buttonOpenFile_MSE
            // 
            this.buttonOpenFile_MSE.BackColor = System.Drawing.Color.Gold;
            this.buttonOpenFile_MSE.Location = new System.Drawing.Point(2, 3);
            this.buttonOpenFile_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile_MSE.Name = "buttonOpenFile_MSE";
            this.buttonOpenFile_MSE.Size = new System.Drawing.Size(76, 72);
            this.buttonOpenFile_MSE.TabIndex = 0;
            this.buttonOpenFile_MSE.Text = "Выбрать файл";
            this.toolTip_MSE.SetToolTip(this.buttonOpenFile_MSE, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_MSE.UseVisualStyleBackColor = false;
            this.buttonOpenFile_MSE.Click += new System.EventHandler(this.buttonOpenFile_MSE_Click);
            // 
            // panelLeft_MSE
            // 
            this.panelLeft_MSE.Controls.Add(this.groupBoxEnter_MSE);
            this.panelLeft_MSE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MSE.Location = new System.Drawing.Point(0, 151);
            this.panelLeft_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft_MSE.Name = "panelLeft_MSE";
            this.panelLeft_MSE.Padding = new System.Windows.Forms.Padding(4);
            this.panelLeft_MSE.Size = new System.Drawing.Size(304, 250);
            this.panelLeft_MSE.TabIndex = 1;
            // 
            // groupBoxEnter_MSE
            // 
            this.groupBoxEnter_MSE.Controls.Add(this.textBoxEnter_MSE);
            this.groupBoxEnter_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEnter_MSE.Location = new System.Drawing.Point(4, 4);
            this.groupBoxEnter_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEnter_MSE.Name = "groupBoxEnter_MSE";
            this.groupBoxEnter_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEnter_MSE.Size = new System.Drawing.Size(296, 242);
            this.groupBoxEnter_MSE.TabIndex = 0;
            this.groupBoxEnter_MSE.TabStop = false;
            this.groupBoxEnter_MSE.Text = "Ввод:";
            // 
            // textBoxEnter_MSE
            // 
            this.textBoxEnter_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnter_MSE.Location = new System.Drawing.Point(2, 15);
            this.textBoxEnter_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEnter_MSE.Multiline = true;
            this.textBoxEnter_MSE.Name = "textBoxEnter_MSE";
            this.textBoxEnter_MSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnter_MSE.Size = new System.Drawing.Size(292, 225);
            this.textBoxEnter_MSE.TabIndex = 0;
            // 
            // splitterLeftRight_MSE
            // 
            this.splitterLeftRight_MSE.Location = new System.Drawing.Point(304, 151);
            this.splitterLeftRight_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.splitterLeftRight_MSE.Name = "splitterLeftRight_MSE";
            this.splitterLeftRight_MSE.Size = new System.Drawing.Size(2, 250);
            this.splitterLeftRight_MSE.TabIndex = 2;
            this.splitterLeftRight_MSE.TabStop = false;
            // 
            // panelRight_MSE
            // 
            this.panelRight_MSE.Controls.Add(this.groupBoxResult_MSE);
            this.panelRight_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_MSE.Location = new System.Drawing.Point(306, 151);
            this.panelRight_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight_MSE.Name = "panelRight_MSE";
            this.panelRight_MSE.Padding = new System.Windows.Forms.Padding(4);
            this.panelRight_MSE.Size = new System.Drawing.Size(332, 250);
            this.panelRight_MSE.TabIndex = 3;
            // 
            // groupBoxResult_MSE
            // 
            this.groupBoxResult_MSE.Controls.Add(this.textBoxResult_MSE);
            this.groupBoxResult_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_MSE.Location = new System.Drawing.Point(4, 4);
            this.groupBoxResult_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_MSE.Name = "groupBoxResult_MSE";
            this.groupBoxResult_MSE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_MSE.Size = new System.Drawing.Size(324, 242);
            this.groupBoxResult_MSE.TabIndex = 0;
            this.groupBoxResult_MSE.TabStop = false;
            this.groupBoxResult_MSE.Text = "Вывод:";
            // 
            // textBoxResult_MSE
            // 
            this.textBoxResult_MSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_MSE.Location = new System.Drawing.Point(2, 15);
            this.textBoxResult_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult_MSE.Multiline = true;
            this.textBoxResult_MSE.Name = "textBoxResult_MSE";
            this.textBoxResult_MSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MSE.Size = new System.Drawing.Size(320, 225);
            this.textBoxResult_MSE.TabIndex = 0;
            // 
            // openFileDialogTask_MSE
            // 
            this.openFileDialogTask_MSE.FileName = "openFileDialog1";
            // 
            // toolTip_MSE
            // 
            this.toolTip_MSE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MSE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 401);
            this.Controls.Add(this.panelRight_MSE);
            this.Controls.Add(this.splitterLeftRight_MSE);
            this.Controls.Add(this.panelLeft_MSE);
            this.Controls.Add(this.panelTop_MSE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Мезенцев С.Е.";
            this.panelTop_MSE.ResumeLayout(false);
            this.groupBoxTask_MSE.ResumeLayout(false);
            this.groupBoxTask_MSE.PerformLayout();
            this.panelTopButtons_MSE.ResumeLayout(false);
            this.panelLeft_MSE.ResumeLayout(false);
            this.groupBoxEnter_MSE.ResumeLayout(false);
            this.groupBoxEnter_MSE.PerformLayout();
            this.panelRight_MSE.ResumeLayout(false);
            this.groupBoxResult_MSE.ResumeLayout(false);
            this.groupBoxResult_MSE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MSE;
        private System.Windows.Forms.Panel panelLeft_MSE;
        private System.Windows.Forms.Splitter splitterLeftRight_MSE;
        private System.Windows.Forms.Panel panelRight_MSE;
        private System.Windows.Forms.Button buttonOpenFile_MSE;
        private System.Windows.Forms.GroupBox groupBoxTask_MSE;
        private System.Windows.Forms.Panel panelTopButtons_MSE;
        private System.Windows.Forms.TextBox textBoxTask_MSE;
        private System.Windows.Forms.GroupBox groupBoxEnter_MSE;
        private System.Windows.Forms.GroupBox groupBoxResult_MSE;
        private System.Windows.Forms.TextBox textBoxEnter_MSE;
        private System.Windows.Forms.TextBox textBoxResult_MSE;
        private System.Windows.Forms.Button buttonDone_MSE;
        private System.Windows.Forms.Button buttonHelp_MSE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MSE;
        private System.Windows.Forms.ToolTip toolTip_MSE;
    }
}

