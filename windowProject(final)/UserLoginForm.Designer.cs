
namespace windowProject_final_
{
    partial class UserLoginForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.PhoneNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("타이포_쌍문동 B", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(133, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "로그인";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.logoutBtn.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 12F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.Location = new System.Drawing.Point(58, 344);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(112, 53);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "로그인";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(199, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "처음으로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PwBox
            // 
            this.PwBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PwBox.Location = new System.Drawing.Point(150, 231);
            this.PwBox.Name = "PwBox";
            this.PwBox.PasswordChar = '●';
            this.PwBox.Size = new System.Drawing.Size(190, 27);
            this.PwBox.TabIndex = 16;
            // 
            // PhoneNumBox
            // 
            this.PhoneNumBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneNumBox.Location = new System.Drawing.Point(150, 180);
            this.PhoneNumBox.Name = "PhoneNumBox";
            this.PhoneNumBox.Size = new System.Drawing.Size(190, 27);
            this.PhoneNumBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(32, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(32, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "휴대폰번호";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.PwBox);
            this.Controls.Add(this.PhoneNumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PwBox;
        private System.Windows.Forms.TextBox PhoneNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}