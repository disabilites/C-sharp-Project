namespace Sanke
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.txt_die = new System.Windows.Forms.Label();
            this.btn_keep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "分数：";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("宋体", 15F);
            this.count.Location = new System.Drawing.Point(101, 40);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(25, 25);
            this.count.TabIndex = 1;
            this.count.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_start.Location = new System.Drawing.Point(367, 245);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(141, 62);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_out
            // 
            this.btn_out.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_out.Location = new System.Drawing.Point(367, 415);
            this.btn_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(141, 62);
            this.btn_out.TabIndex = 2;
            this.btn_out.Text = "退出";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // txt_die
            // 
            this.txt_die.AutoSize = true;
            this.txt_die.Enabled = false;
            this.txt_die.Font = new System.Drawing.Font("宋体", 40F);
            this.txt_die.Location = new System.Drawing.Point(309, 245);
            this.txt_die.Name = "txt_die";
            this.txt_die.Size = new System.Drawing.Size(267, 67);
            this.txt_die.TabIndex = 0;
            this.txt_die.Text = "YOU DIE";
            this.txt_die.Visible = false;
            // 
            // btn_keep
            // 
            this.btn_keep.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_keep.Location = new System.Drawing.Point(344, 361);
            this.btn_keep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_keep.Name = "btn_keep";
            this.btn_keep.Size = new System.Drawing.Size(192, 72);
            this.btn_keep.TabIndex = 3;
            this.btn_keep.Text = "再来一盘";
            this.btn_keep.UseVisualStyleBackColor = true;
            this.btn_keep.Visible = false;
            this.btn_keep.Click += new System.EventHandler(this.btn_keep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 852);
            this.Controls.Add(this.btn_keep);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.count);
            this.Controls.Add(this.txt_die);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label txt_die;
        private System.Windows.Forms.Button btn_keep;
    }
}

