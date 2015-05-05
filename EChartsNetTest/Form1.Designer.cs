namespace EChartsNetTest
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
            this.echarts1 = new EChartsNet.echarts();
            this.btn_static = new System.Windows.Forms.Button();
            this.btn_dynamic = new System.Windows.Forms.Button();
            this.btn_bar10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // echarts1
            // 
            this.echarts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.echarts1.Location = new System.Drawing.Point(0, 28);
            this.echarts1.Name = "echarts1";
            this.echarts1.option = null;
            this.echarts1.Size = new System.Drawing.Size(587, 252);
            this.echarts1.TabIndex = 0;
            this.echarts1.DbClickReturnParam += new EChartsNet.echarts.DbClickHandle(this.echarts1_DbClickReturnParam);
            // 
            // btn_static
            // 
            this.btn_static.Location = new System.Drawing.Point(6, 1);
            this.btn_static.Name = "btn_static";
            this.btn_static.Size = new System.Drawing.Size(75, 23);
            this.btn_static.TabIndex = 1;
            this.btn_static.Text = "static";
            this.btn_static.UseVisualStyleBackColor = true;
            this.btn_static.Click += new System.EventHandler(this.btn_static_Click);
            // 
            // btn_dynamic
            // 
            this.btn_dynamic.Location = new System.Drawing.Point(87, 1);
            this.btn_dynamic.Name = "btn_dynamic";
            this.btn_dynamic.Size = new System.Drawing.Size(75, 23);
            this.btn_dynamic.TabIndex = 2;
            this.btn_dynamic.Text = "dynamic";
            this.btn_dynamic.UseVisualStyleBackColor = true;
            this.btn_dynamic.Click += new System.EventHandler(this.btn_dynamic_Click);
            // 
            // btn_bar10
            // 
            this.btn_bar10.Location = new System.Drawing.Point(168, 1);
            this.btn_bar10.Name = "btn_bar10";
            this.btn_bar10.Size = new System.Drawing.Size(102, 23);
            this.btn_bar10.TabIndex = 3;
            this.btn_bar10.Text = " 温度计式图表";
            this.btn_bar10.UseVisualStyleBackColor = true;
            this.btn_bar10.Click += new System.EventHandler(this.btn_bar10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 280);
            this.Controls.Add(this.btn_bar10);
            this.Controls.Add(this.btn_dynamic);
            this.Controls.Add(this.btn_static);
            this.Controls.Add(this.echarts1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EChartsNet.echarts echarts1;
        private System.Windows.Forms.Button btn_static;
        private System.Windows.Forms.Button btn_dynamic;
        private System.Windows.Forms.Button btn_bar10;
    }
}

