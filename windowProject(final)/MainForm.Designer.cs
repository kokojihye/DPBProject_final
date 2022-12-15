
namespace windowProject_final_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.INOUT_button = new System.Windows.Forms.Button();
            this.PURCHASE_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(259, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "이용권 구매 후 좌석을 선택해주세요.";
            // 
            // INOUT_button
            // 
            this.INOUT_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.INOUT_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.INOUT_button.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Bold);
            this.INOUT_button.Location = new System.Drawing.Point(318, 118);
            this.INOUT_button.Name = "INOUT_button";
            this.INOUT_button.Size = new System.Drawing.Size(190, 155);
            this.INOUT_button.TabIndex = 3;
            this.INOUT_button.Text = "입실/퇴실";
            this.INOUT_button.UseVisualStyleBackColor = false;
            this.INOUT_button.Click += new System.EventHandler(this.INOUT_button_Click);
            // 
            // PURCHASE_button
            // 
            this.PURCHASE_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PURCHASE_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PURCHASE_button.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Bold);
            this.PURCHASE_button.Location = new System.Drawing.Point(318, 351);
            this.PURCHASE_button.Name = "PURCHASE_button";
            this.PURCHASE_button.Size = new System.Drawing.Size(190, 155);
            this.PURCHASE_button.TabIndex = 4;
            this.PURCHASE_button.Text = "이용권 구매";
            this.PURCHASE_button.UseVisualStyleBackColor = false;
            this.PURCHASE_button.Click += new System.EventHandler(this.PURCHASE_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 624);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "스터디카페";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier10 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "SYUniv.DBP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 17F);
            this.label6.Location = new System.Drawing.Point(0, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 40);
            this.label6.TabIndex = 8;
            this.label6.Text = "STUDY CAFE";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(617, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PURCHASE_button);
            this.Controls.Add(this.INOUT_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button INOUT_button;
        private System.Windows.Forms.Button PURCHASE_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}