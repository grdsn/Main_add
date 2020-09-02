namespace WindowsFormsApp1
{
    partial class CSS_Parts
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
            this.AddConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.choiseCSS = new System.Windows.Forms.Button();
            this.cssFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(380, 12);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 4;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSS参照の追加";
            // 
            // choiseCSS
            // 
            this.choiseCSS.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.choiseCSS.Location = new System.Drawing.Point(12, 80);
            this.choiseCSS.Name = "choiseCSS";
            this.choiseCSS.Size = new System.Drawing.Size(160, 30);
            this.choiseCSS.TabIndex = 2;
            this.choiseCSS.Text = "スタイルシートを選択";
            this.choiseCSS.UseVisualStyleBackColor = true;
            this.choiseCSS.Click += new System.EventHandler(this.choiseCSS_Click);
            // 
            // cssFile
            // 
            this.cssFile.Enabled = false;
            this.cssFile.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.cssFile.Location = new System.Drawing.Point(12, 125);
            this.cssFile.Name = "cssFile";
            this.cssFile.Size = new System.Drawing.Size(465, 28);
            this.cssFile.TabIndex = 3;
            // 
            // CSS_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 180);
            this.Controls.Add(this.cssFile);
            this.Controls.Add(this.choiseCSS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddConfirm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 219);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 219);
            this.Name = "CSS_Parts";
            this.Text = "CSS_Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choiseCSS;
        private System.Windows.Forms.TextBox cssFile;
    }
}