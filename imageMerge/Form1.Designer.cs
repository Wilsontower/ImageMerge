namespace imageMerge
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileBtn1 = new System.Windows.Forms.Button();
            this.openFilebtn2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.jointBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LRmergeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(556, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(475, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // openFileBtn1
            // 
            this.openFileBtn1.Location = new System.Drawing.Point(226, 290);
            this.openFileBtn1.Name = "openFileBtn1";
            this.openFileBtn1.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn1.TabIndex = 2;
            this.openFileBtn1.Text = "打开图片";
            this.openFileBtn1.UseVisualStyleBackColor = true;
            this.openFileBtn1.Click += new System.EventHandler(this.openFileBtn1_Click);
            // 
            // openFilebtn2
            // 
            this.openFilebtn2.Location = new System.Drawing.Point(775, 290);
            this.openFilebtn2.Name = "openFilebtn2";
            this.openFilebtn2.Size = new System.Drawing.Size(75, 23);
            this.openFilebtn2.TabIndex = 3;
            this.openFilebtn2.Text = "打开图片";
            this.openFilebtn2.UseVisualStyleBackColor = true;
            this.openFilebtn2.Click += new System.EventHandler(this.openFilebtn2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(226, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(690, 361);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // mergeBtn
            // 
            this.mergeBtn.Location = new System.Drawing.Point(77, 370);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(75, 23);
            this.mergeBtn.TabIndex = 5;
            this.mergeBtn.Text = "上下拼接";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // jointBtn
            // 
            this.jointBtn.Location = new System.Drawing.Point(77, 489);
            this.jointBtn.Name = "jointBtn";
            this.jointBtn.Size = new System.Drawing.Size(75, 23);
            this.jointBtn.TabIndex = 6;
            this.jointBtn.Text = "图像合成";
            this.jointBtn.UseVisualStyleBackColor = true;
            this.jointBtn.Click += new System.EventHandler(this.jointBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(77, 560);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "另存为";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(40, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LRmergeBtn
            // 
            this.LRmergeBtn.Location = new System.Drawing.Point(77, 427);
            this.LRmergeBtn.Name = "LRmergeBtn";
            this.LRmergeBtn.Size = new System.Drawing.Size(75, 23);
            this.LRmergeBtn.TabIndex = 8;
            this.LRmergeBtn.Text = "左右拼接";
            this.LRmergeBtn.UseVisualStyleBackColor = true;
            this.LRmergeBtn.Click += new System.EventHandler(this.LRmergeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.LRmergeBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.jointBtn);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.openFilebtn2);
            this.Controls.Add(this.openFileBtn1);
            this.Name = "Form1";
            this.Text = "图像处理程序";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button openFileBtn1;
        private System.Windows.Forms.Button openFilebtn2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button mergeBtn;
        private System.Windows.Forms.Button jointBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LRmergeBtn;
    }
}

