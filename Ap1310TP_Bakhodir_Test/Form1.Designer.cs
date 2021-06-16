
namespace Ap1310TP_Bakhodir_Test
{
    partial class Form1
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
            this.btnTest1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(358, 155);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(123, 27);
            this.btnTest1.TabIndex = 0;
            this.btnTest1.Text = "Test1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ap1310TP_Bakhodir_Test.Properties.Resources.w1;
            this.pictureBox1.Location = new System.Drawing.Point(43, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 139);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTest1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AP1310 testing tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

