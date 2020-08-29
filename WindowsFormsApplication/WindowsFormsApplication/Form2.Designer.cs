namespace WindowsFormsApplication
{
    partial class controller
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
            this.btncour = new System.Windows.Forms.Button();
            this.btnstu = new System.Windows.Forms.Button();
            this.btntea = new System.Windows.Forms.Button();
            this.btnnews = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncour
            // 
            this.btncour.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncour.Location = new System.Drawing.Point(265, 68);
            this.btncour.Name = "btncour";
            this.btncour.Size = new System.Drawing.Size(260, 35);
            this.btncour.TabIndex = 0;
            this.btncour.Text = "课程信息查询";
            this.btncour.UseVisualStyleBackColor = true;
            this.btncour.Click += new System.EventHandler(this.btncour_Click);
            // 
            // btnstu
            // 
            this.btnstu.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstu.Location = new System.Drawing.Point(265, 163);
            this.btnstu.Name = "btnstu";
            this.btnstu.Size = new System.Drawing.Size(260, 35);
            this.btnstu.TabIndex = 1;
            this.btnstu.Text = "学生信息查询";
            this.btnstu.UseVisualStyleBackColor = true;
            this.btnstu.Click += new System.EventHandler(this.btnstu_Click);
            // 
            // btntea
            // 
            this.btntea.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btntea.Location = new System.Drawing.Point(265, 258);
            this.btntea.Name = "btntea";
            this.btntea.Size = new System.Drawing.Size(260, 35);
            this.btntea.TabIndex = 2;
            this.btntea.Text = "教师信息查询";
            this.btntea.UseVisualStyleBackColor = true;
            this.btntea.Click += new System.EventHandler(this.btntea_Click);
            // 
            // btnnews
            // 
            this.btnnews.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnnews.Location = new System.Drawing.Point(265, 353);
            this.btnnews.Name = "btnnews";
            this.btnnews.Size = new System.Drawing.Size(260, 35);
            this.btnnews.TabIndex = 3;
            this.btnnews.Text = "信息发布";
            this.btnnews.UseVisualStyleBackColor = true;
            this.btnnews.Click += new System.EventHandler(this.btnnews_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnadd.Location = new System.Drawing.Point(265, 448);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(260, 35);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "信息添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnback.Location = new System.Drawing.Point(690, 530);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "退  出";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnnews);
            this.Controls.Add(this.btntea);
            this.Controls.Add(this.btnstu);
            this.Controls.Add(this.btncour);
            this.Name = "controller";
            this.Text = "教学管理系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncour;
        private System.Windows.Forms.Button btnstu;
        private System.Windows.Forms.Button btntea;
        private System.Windows.Forms.Button btnnews;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;

    }
}