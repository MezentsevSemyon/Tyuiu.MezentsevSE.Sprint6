
namespace Tyuiu.MezentsevSE.Sprint6.Task6.V24
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
            this.pictureBoxAvatar_MSE = new System.Windows.Forms.PictureBox();
            this.labelInfo_MSE = new System.Windows.Forms.Label();
            this.buttonOk_MSE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MSE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_MSE
            // 
            this.pictureBoxAvatar_MSE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_MSE.Image")));
            this.pictureBoxAvatar_MSE.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxAvatar_MSE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAvatar_MSE.Name = "pictureBoxAvatar_MSE";
            this.pictureBoxAvatar_MSE.Size = new System.Drawing.Size(133, 184);
            this.pictureBoxAvatar_MSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_MSE.TabIndex = 0;
            this.pictureBoxAvatar_MSE.TabStop = false;
            // 
            // labelInfo_MSE
            // 
            this.labelInfo_MSE.AutoSize = true;
            this.labelInfo_MSE.Location = new System.Drawing.Point(148, 11);
            this.labelInfo_MSE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo_MSE.Name = "labelInfo_MSE";
            this.labelInfo_MSE.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_MSE.TabIndex = 1;
            this.labelInfo_MSE.Text = resources.GetString("labelInfo_MSE.Text");
            // 
            // buttonOk_MSE
            // 
            this.buttonOk_MSE.Location = new System.Drawing.Point(341, 167);
            this.buttonOk_MSE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk_MSE.Name = "buttonOk_MSE";
            this.buttonOk_MSE.Size = new System.Drawing.Size(80, 27);
            this.buttonOk_MSE.TabIndex = 2;
            this.buttonOk_MSE.Text = "Ок";
            this.buttonOk_MSE.UseVisualStyleBackColor = true;
            this.buttonOk_MSE.Click += new System.EventHandler(this.buttonOk_MSE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 203);
            this.Controls.Add(this.buttonOk_MSE);
            this.Controls.Add(this.labelInfo_MSE);
            this.Controls.Add(this.pictureBoxAvatar_MSE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

        private System.Windows.Forms.PictureBox pictureBoxAvatar_MSE;
        private System.Windows.Forms.Label labelInfo_MSE;
        private System.Windows.Forms.Button buttonOk_MSE;
    }
}