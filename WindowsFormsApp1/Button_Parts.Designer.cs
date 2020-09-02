namespace WindowsFormsApp1
{
    partial class Button_Parts
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
            this.hmlBtn = new System.Windows.Forms.Button();
            this.onclick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.TextBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.JSBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ボタン追加";
            // 
            // hmlBtn
            // 
            this.hmlBtn.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.hmlBtn.Location = new System.Drawing.Point(17, 116);
            this.hmlBtn.Name = "hmlBtn";
            this.hmlBtn.Size = new System.Drawing.Size(139, 30);
            this.hmlBtn.TabIndex = 1;
            this.hmlBtn.Text = "HTMLファイルを選択";
            this.hmlBtn.UseVisualStyleBackColor = true;
            this.hmlBtn.Click += new System.EventHandler(this.hmlBtn_Click);
            // 
            // onclick
            // 
            this.onclick.Enabled = false;
            this.onclick.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.onclick.Location = new System.Drawing.Point(17, 152);
            this.onclick.Name = "onclick";
            this.onclick.Size = new System.Drawing.Size(467, 25);
            this.onclick.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ボタンを押したときのアクション\r\n(URLまたはJavaScriptのメソッドを入力してください。)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label3.Location = new System.Drawing.Point(14, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "ボタンに表示する文字";
            // 
            // btnName
            // 
            this.btnName.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.btnName.Location = new System.Drawing.Point(17, 228);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(467, 25);
            this.btnName.TabIndex = 5;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(455, 12);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 6;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // JSBtn
            // 
            this.JSBtn.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.JSBtn.Location = new System.Drawing.Point(162, 116);
            this.JSBtn.Name = "JSBtn";
            this.JSBtn.Size = new System.Drawing.Size(82, 30);
            this.JSBtn.TabIndex = 2;
            this.JSBtn.Text = "URL入力";
            this.JSBtn.UseVisualStyleBackColor = true;
            this.JSBtn.Click += new System.EventHandler(this.JSBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(250, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "JavaScript入力";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JSBtn);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.onclick);
            this.Controls.Add(this.hmlBtn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Button_Parts";
            this.Text = "Button_Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hmlBtn;
        private System.Windows.Forms.TextBox onclick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btnName;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Button JSBtn;
        private System.Windows.Forms.Button button1;
    }
}