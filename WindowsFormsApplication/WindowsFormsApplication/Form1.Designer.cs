namespace WindowsFormsApplication
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtpswd = new System.Windows.Forms.TextBox();
            this.lblpswd = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.rbtnpower01 = new System.Windows.Forms.RadioButton();
            this.rbtnpower02 = new System.Windows.Forms.RadioButton();
            this.rbtnpower03 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsubmit.Location = new System.Drawing.Point(279, 370);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(81, 33);
            this.btnsubmit.TabIndex = 0;
            this.btnsubmit.Text = "登  录";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click_1);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbluser.Location = new System.Drawing.Point(275, 187);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(69, 20);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "用户名";
            // 
            // txtpswd
            // 
            this.txtpswd.Location = new System.Drawing.Point(397, 250);
            this.txtpswd.Name = "txtpswd";
            this.txtpswd.Size = new System.Drawing.Size(118, 21);
            this.txtpswd.TabIndex = 2;
            // 
            // lblpswd
            // 
            this.lblpswd.AutoSize = true;
            this.lblpswd.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpswd.Location = new System.Drawing.Point(274, 246);
            this.lblpswd.Name = "lblpswd";
            this.lblpswd.Size = new System.Drawing.Size(69, 20);
            this.lblpswd.TabIndex = 3;
            this.lblpswd.Text = "密  码";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblwelcome.Location = new System.Drawing.Point(193, 75);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(404, 48);
            this.lblwelcome.TabIndex = 4;
            this.lblwelcome.Text = "智慧教学管理系统";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(397, 186);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(118, 21);
            this.txtuser.TabIndex = 5;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel.Location = new System.Drawing.Point(434, 370);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 33);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "取  消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // rbtnpower01
            // 
            this.rbtnpower01.AutoSize = true;
            this.rbtnpower01.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnpower01.Location = new System.Drawing.Point(274, 309);
            this.rbtnpower01.Name = "rbtnpower01";
            this.rbtnpower01.Size = new System.Drawing.Size(74, 20);
            this.rbtnpower01.TabIndex = 7;
            this.rbtnpower01.TabStop = true;
            this.rbtnpower01.Text = "管理员";
            this.rbtnpower01.UseVisualStyleBackColor = true;
            this.rbtnpower01.CheckedChanged += new System.EventHandler(this.rbtnpower01_CheckedChanged);
            // 
            // rbtnpower02
            // 
            this.rbtnpower02.AutoSize = true;
            this.rbtnpower02.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnpower02.Location = new System.Drawing.Point(361, 309);
            this.rbtnpower02.Name = "rbtnpower02";
            this.rbtnpower02.Size = new System.Drawing.Size(74, 20);
            this.rbtnpower02.TabIndex = 8;
            this.rbtnpower02.TabStop = true;
            this.rbtnpower02.Text = "学  生";
            this.rbtnpower02.UseVisualStyleBackColor = true;
            this.rbtnpower02.CheckedChanged += new System.EventHandler(this.rbtnpower02_CheckedChanged);
            // 
            // rbtnpower03
            // 
            this.rbtnpower03.AutoSize = true;
            this.rbtnpower03.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnpower03.Location = new System.Drawing.Point(448, 309);
            this.rbtnpower03.Name = "rbtnpower03";
            this.rbtnpower03.Size = new System.Drawing.Size(74, 20);
            this.rbtnpower03.TabIndex = 9;
            this.rbtnpower03.TabStop = true;
            this.rbtnpower03.Text = "教  师";
            this.rbtnpower03.UseVisualStyleBackColor = true;
            this.rbtnpower03.CheckedChanged += new System.EventHandler(this.rbtnpower03_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rbtnpower03);
            this.Controls.Add(this.rbtnpower02);
            this.Controls.Add(this.rbtnpower01);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.lblpswd);
            this.Controls.Add(this.txtpswd);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnsubmit);
            this.Name = "Login";
            this.Text = "登录系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtpswd;
        private System.Windows.Forms.Label lblpswd;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.RadioButton rbtnpower01;
        private System.Windows.Forms.RadioButton rbtnpower02;
        private System.Windows.Forms.RadioButton rbtnpower03;
    }
}

