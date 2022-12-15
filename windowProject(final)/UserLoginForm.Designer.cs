
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
            this.로그인 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LOGIN_button = new System.Windows.Forms.Button();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.로그인.SuspendLayout();
            this.SuspendLayout();
            // 
            // 로그인
            // 
            this.로그인.Controls.Add(this.button1);
            this.로그인.Controls.Add(this.LOGIN_button);
            this.로그인.Controls.Add(this.PwBox);
            this.로그인.Controls.Add(this.IdBox);
            this.로그인.Controls.Add(this.label2);
            this.로그인.Controls.Add(this.label1);
            this.로그인.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.로그인.Location = new System.Drawing.Point(42, 25);
            this.로그인.Name = "로그인";
            this.로그인.Size = new System.Drawing.Size(272, 241);
            this.로그인.TabIndex = 0;
            this.로그인.TabStop = false;
            this.로그인.Text = "로그인";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(152, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "처음으로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOGIN_button
            // 
            this.LOGIN_button.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LOGIN_button.Location = new System.Drawing.Point(38, 178);
            this.LOGIN_button.Name = "LOGIN_button";
            this.LOGIN_button.Size = new System.Drawing.Size(81, 31);
            this.LOGIN_button.TabIndex = 1;
            this.LOGIN_button.Text = "로그인";
            this.LOGIN_button.UseVisualStyleBackColor = true;
            this.LOGIN_button.Click += new System.EventHandler(this.LOGIN_button_Click);
            // 
            // PwBox
            // 
            this.PwBox.Location = new System.Drawing.Point(102, 107);
            this.PwBox.Name = "PwBox";
            this.PwBox.PasswordChar = '*';
            this.PwBox.Size = new System.Drawing.Size(131, 24);
            this.PwBox.TabIndex = 3;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(102, 54);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(131, 24);
            this.IdBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 303);
            this.Controls.Add(this.로그인);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.로그인.ResumeLayout(false);
            this.로그인.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 로그인;
        private System.Windows.Forms.Button LOGIN_button;
        private System.Windows.Forms.TextBox PwBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}