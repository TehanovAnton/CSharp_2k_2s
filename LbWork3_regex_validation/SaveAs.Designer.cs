
namespace OOP_4SEM_3
{
    partial class SaveAs
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
            this.label1 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Введите имя файла";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(42, 64);
            this.FileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(167, 26);
            this.FileName.TabIndex = 1;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(42, 115);
            this.Ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(168, 35);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 174);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SaveAs";
            this.Text = "SaveAs";
            this.Load += new System.EventHandler(this.SaveAs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button Ok;
    }
}