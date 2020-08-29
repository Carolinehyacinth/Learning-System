namespace WindowsFormsApplication
{
    partial class courinfor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.精确查询 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncancel01 = new System.Windows.Forms.Button();
            this.btnsubmit01 = new System.Windows.Forms.Button();
            this.txtteanum01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcournum01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.模糊查询 = new System.Windows.Forms.TabPage();
            this.txttime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btncancel02 = new System.Windows.Forms.Button();
            this.btnsubmit02 = new System.Windows.Forms.Button();
            this.txtteaname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtteanum02 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcourname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcournum02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.精确查询.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.模糊查询.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.精确查询);
            this.tabControl1.Controls.Add(this.模糊查询);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // 精确查询
            // 
            this.精确查询.Controls.Add(this.dataGridView1);
            this.精确查询.Controls.Add(this.btncancel01);
            this.精确查询.Controls.Add(this.btnsubmit01);
            this.精确查询.Controls.Add(this.txtteanum01);
            this.精确查询.Controls.Add(this.label2);
            this.精确查询.Controls.Add(this.txtcournum01);
            this.精确查询.Controls.Add(this.label1);
            this.精确查询.Location = new System.Drawing.Point(4, 22);
            this.精确查询.Name = "精确查询";
            this.精确查询.Padding = new System.Windows.Forms.Padding(3);
            this.精确查询.Size = new System.Drawing.Size(752, 489);
            this.精确查询.TabIndex = 0;
            this.精确查询.Text = "精确查询";
            this.精确查询.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(692, 295);
            this.dataGridView1.TabIndex = 11;
            // 
            // btncancel01
            // 
            this.btncancel01.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel01.Location = new System.Drawing.Point(645, 58);
            this.btncancel01.Name = "btncancel01";
            this.btncancel01.Size = new System.Drawing.Size(75, 23);
            this.btncancel01.TabIndex = 5;
            this.btncancel01.Text = "取  消";
            this.btncancel01.UseVisualStyleBackColor = true;
            this.btncancel01.Click += new System.EventHandler(this.btncancel01_Click);
            // 
            // btnsubmit01
            // 
            this.btnsubmit01.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsubmit01.Location = new System.Drawing.Point(534, 58);
            this.btnsubmit01.Name = "btnsubmit01";
            this.btnsubmit01.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit01.TabIndex = 4;
            this.btnsubmit01.Text = "查  询";
            this.btnsubmit01.UseVisualStyleBackColor = true;
            this.btnsubmit01.Click += new System.EventHandler(this.btnsubmit01_Click);
            // 
            // txtteanum01
            // 
            this.txtteanum01.Location = new System.Drawing.Point(350, 20);
            this.txtteanum01.Name = "txtteanum01";
            this.txtteanum01.Size = new System.Drawing.Size(100, 21);
            this.txtteanum01.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(275, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "教师号";
            // 
            // txtcournum01
            // 
            this.txtcournum01.Location = new System.Drawing.Point(125, 20);
            this.txtcournum01.Name = "txtcournum01";
            this.txtcournum01.Size = new System.Drawing.Size(100, 21);
            this.txtcournum01.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            // 
            // 模糊查询
            // 
            this.模糊查询.Controls.Add(this.txttime);
            this.模糊查询.Controls.Add(this.label8);
            this.模糊查询.Controls.Add(this.txtcredit);
            this.模糊查询.Controls.Add(this.label7);
            this.模糊查询.Controls.Add(this.dataGridView2);
            this.模糊查询.Controls.Add(this.btncancel02);
            this.模糊查询.Controls.Add(this.btnsubmit02);
            this.模糊查询.Controls.Add(this.txtteaname);
            this.模糊查询.Controls.Add(this.label6);
            this.模糊查询.Controls.Add(this.txtteanum02);
            this.模糊查询.Controls.Add(this.label5);
            this.模糊查询.Controls.Add(this.txtcourname);
            this.模糊查询.Controls.Add(this.label4);
            this.模糊查询.Controls.Add(this.txtcournum02);
            this.模糊查询.Controls.Add(this.label3);
            this.模糊查询.Location = new System.Drawing.Point(4, 22);
            this.模糊查询.Name = "模糊查询";
            this.模糊查询.Padding = new System.Windows.Forms.Padding(3);
            this.模糊查询.Size = new System.Drawing.Size(752, 489);
            this.模糊查询.TabIndex = 1;
            this.模糊查询.Text = "模糊查询";
            this.模糊查询.UseVisualStyleBackColor = true;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(575, 55);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(100, 21);
            this.txttime.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(500, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "时  间";
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(575, 20);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(100, 21);
            this.txtcredit.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(500, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "学  分";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(28, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(692, 295);
            this.dataGridView2.TabIndex = 10;
            // 
            // btncancel02
            // 
            this.btncancel02.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel02.Location = new System.Drawing.Point(645, 93);
            this.btncancel02.Name = "btncancel02";
            this.btncancel02.Size = new System.Drawing.Size(75, 23);
            this.btncancel02.TabIndex = 9;
            this.btncancel02.Text = "取  消";
            this.btncancel02.UseVisualStyleBackColor = true;
            this.btncancel02.Click += new System.EventHandler(this.btncancel02_Click);
            // 
            // btnsubmit02
            // 
            this.btnsubmit02.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsubmit02.Location = new System.Drawing.Point(534, 93);
            this.btnsubmit02.Name = "btnsubmit02";
            this.btnsubmit02.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit02.TabIndex = 8;
            this.btnsubmit02.Text = "查  询";
            this.btnsubmit02.UseVisualStyleBackColor = true;
            this.btnsubmit02.Click += new System.EventHandler(this.btnsubmit02_Click);
            // 
            // txtteaname
            // 
            this.txtteaname.Location = new System.Drawing.Point(350, 55);
            this.txtteaname.Name = "txtteaname";
            this.txtteaname.Size = new System.Drawing.Size(100, 21);
            this.txtteaname.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(275, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "教师名";
            // 
            // txtteanum02
            // 
            this.txtteanum02.Location = new System.Drawing.Point(125, 55);
            this.txtteanum02.Name = "txtteanum02";
            this.txtteanum02.Size = new System.Drawing.Size(100, 21);
            this.txtteanum02.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(50, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "教师号";
            // 
            // txtcourname
            // 
            this.txtcourname.Location = new System.Drawing.Point(350, 20);
            this.txtcourname.Name = "txtcourname";
            this.txtcourname.Size = new System.Drawing.Size(100, 21);
            this.txtcourname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(275, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "课程名";
            // 
            // txtcournum02
            // 
            this.txtcournum02.Location = new System.Drawing.Point(125, 20);
            this.txtcournum02.Name = "txtcournum02";
            this.txtcournum02.Size = new System.Drawing.Size(100, 21);
            this.txtcournum02.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "课程号";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnback.Location = new System.Drawing.Point(690, 530);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 23);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "返  回";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // courinfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.tabControl1);
            this.Name = "courinfor";
            this.Text = "课程查询界面";
            this.tabControl1.ResumeLayout(false);
            this.精确查询.ResumeLayout(false);
            this.精确查询.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.模糊查询.ResumeLayout(false);
            this.模糊查询.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 精确查询;
        private System.Windows.Forms.TabPage 模糊查询;
        private System.Windows.Forms.TextBox txtteanum01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcournum01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel01;
        private System.Windows.Forms.Button btnsubmit01;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncancel02;
        private System.Windows.Forms.Button btnsubmit02;
        private System.Windows.Forms.TextBox txtteaname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtteanum02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcourname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcournum02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}