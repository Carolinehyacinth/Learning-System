namespace WindowsFormsApplication
{
    partial class sendemail
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
            this.btnsend01 = new System.Windows.Forms.Button();
            this.btnsend02 = new System.Windows.Forms.Button();
            this.btnclr01 = new System.Windows.Forms.Button();
            this.rtxt正文 = new System.Windows.Forms.RichTextBox();
            this.btnclr02 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.rtxt主题 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt附件 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "附  件：";
            // 
            // btnsend01
            // 
            this.btnsend01.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsend01.Location = new System.Drawing.Point(60, 485);
            this.btnsend01.Name = "btnsend01";
            this.btnsend01.Size = new System.Drawing.Size(94, 23);
            this.btnsend01.TabIndex = 1;
            this.btnsend01.Text = "教  师";
            this.btnsend01.UseVisualStyleBackColor = true;
            this.btnsend01.Click += new System.EventHandler(this.btnsend01_Click);
            // 
            // btnsend02
            // 
            this.btnsend02.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsend02.Location = new System.Drawing.Point(240, 485);
            this.btnsend02.Name = "btnsend02";
            this.btnsend02.Size = new System.Drawing.Size(94, 23);
            this.btnsend02.TabIndex = 2;
            this.btnsend02.Text = "学  生";
            this.btnsend02.UseVisualStyleBackColor = true;
            this.btnsend02.Click += new System.EventHandler(this.btnsend02_Click);
            // 
            // btnclr01
            // 
            this.btnclr01.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclr01.Location = new System.Drawing.Point(420, 485);
            this.btnclr01.Name = "btnclr01";
            this.btnclr01.Size = new System.Drawing.Size(94, 23);
            this.btnclr01.TabIndex = 3;
            this.btnclr01.Text = "清空主题";
            this.btnclr01.UseVisualStyleBackColor = true;
            this.btnclr01.Click += new System.EventHandler(this.btnclr01_Click);
            // 
            // rtxt正文
            // 
            this.rtxt正文.Location = new System.Drawing.Point(47, 164);
            this.rtxt正文.Name = "rtxt正文";
            this.rtxt正文.Size = new System.Drawing.Size(693, 306);
            this.rtxt正文.TabIndex = 5;
            this.rtxt正文.Text = "";
            // 
            // btnclr02
            // 
            this.btnclr02.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclr02.Location = new System.Drawing.Point(600, 485);
            this.btnclr02.Name = "btnclr02";
            this.btnclr02.Size = new System.Drawing.Size(135, 23);
            this.btnclr02.TabIndex = 6;
            this.btnclr02.Text = "清空正文与附件";
            this.btnclr02.UseVisualStyleBackColor = true;
            this.btnclr02.Click += new System.EventHandler(this.btnclr02_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnback.Location = new System.Drawing.Point(690, 530);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 23);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "返  回";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // rtxt主题
            // 
            this.rtxt主题.Location = new System.Drawing.Point(47, 64);
            this.rtxt主题.Name = "rtxt主题";
            this.rtxt主题.Size = new System.Drawing.Size(693, 28);
            this.rtxt主题.TabIndex = 8;
            this.rtxt主题.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(54, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "主  题：";
            // 
            // rtxt附件
            // 
            this.rtxt附件.Location = new System.Drawing.Point(47, 114);
            this.rtxt附件.Name = "rtxt附件";
            this.rtxt附件.Size = new System.Drawing.Size(693, 28);
            this.rtxt附件.TabIndex = 10;
            this.rtxt附件.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(54, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "正  文：";
            // 
            // sendemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxt附件);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxt主题);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclr02);
            this.Controls.Add(this.rtxt正文);
            this.Controls.Add(this.btnclr01);
            this.Controls.Add(this.btnsend02);
            this.Controls.Add(this.btnsend01);
            this.Controls.Add(this.label1);
            this.Name = "sendemail";
            this.Text = "信息发布界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsend01;
        private System.Windows.Forms.Button btnsend02;
        private System.Windows.Forms.Button btnclr01;
        private System.Windows.Forms.RichTextBox rtxt正文;
        private System.Windows.Forms.Button btnclr02;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.RichTextBox rtxt主题;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt附件;
        private System.Windows.Forms.Label label3;
    }
}