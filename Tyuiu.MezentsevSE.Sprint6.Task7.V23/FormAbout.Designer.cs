
namespace Tyuiu.MezentsevSE.Sprint6.Task7.V23
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOk_MSE = new System.Windows.Forms.Button();
            this.labelInfo_VMV = new System.Windows.Forms.Label();
            this.labelInfo_MSE = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_MSE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MSE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_MSE
            // 
            this.buttonOk_MSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk_MSE.Location = new System.Drawing.Point(340, 146);
            this.buttonOk_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk_MSE.Name = "buttonOk_MSE";
            this.buttonOk_MSE.Size = new System.Drawing.Size(67, 25);
            this.buttonOk_MSE.TabIndex = 0;
            this.buttonOk_MSE.Text = "Ок";
            this.buttonOk_MSE.UseVisualStyleBackColor = true;
            this.buttonOk_MSE.Click += new System.EventHandler(this.buttonOk_MSE_Click);
            // 
            // labelInfo_VMV
            // 
            this.labelInfo_VMV.AutoSize = true;
            this.labelInfo_VMV.Location = new System.Drawing.Point(134, 7);
            this.labelInfo_VMV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo_VMV.Name = "labelInfo_VMV";
            this.labelInfo_VMV.Size = new System.Drawing.Size(0, 13);
            this.labelInfo_VMV.TabIndex = 2;
            // 
            // labelInfo_MSE
            // 
            this.labelInfo_MSE.AutoSize = true;
            this.labelInfo_MSE.Location = new System.Drawing.Point(139, 9);
            this.labelInfo_MSE.Name = "labelInfo_MSE";
            this.labelInfo_MSE.Size = new System.Drawing.Size(287, 104);
            this.labelInfo_MSE.TabIndex = 3;
            this.labelInfo_MSE.Text = resources.GetString("labelInfo_MSE.Text");
            // 
            // pictureBoxAvatar_MSE
            // 
            this.pictureBoxAvatar_MSE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_MSE.Image")));
            this.pictureBoxAvatar_MSE.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxAvatar_MSE.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAvatar_MSE.Name = "pictureBoxAvatar_MSE";
            this.pictureBoxAvatar_MSE.Size = new System.Drawing.Size(122, 164);
            this.pictureBoxAvatar_MSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_MSE.TabIndex = 1;
            this.pictureBoxAvatar_MSE.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 181);
            this.Controls.Add(this.labelInfo_MSE);
            this.Controls.Add(this.labelInfo_VMV);
            this.Controls.Add(this.pictureBoxAvatar_MSE);
            this.Controls.Add(this.buttonOk_MSE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MSE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_MSE;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_MSE;
        private System.Windows.Forms.Label labelInfo_VMV;
        private System.Windows.Forms.Label labelInfo_MSE;
    }
}
