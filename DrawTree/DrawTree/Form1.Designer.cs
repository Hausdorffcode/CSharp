namespace DrawTree
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
            this.lstth1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstth2 = new System.Windows.Forms.ListBox();
            this.lstper1 = new System.Windows.Forms.ListBox();
            this.lstper2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGoldrate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstth1
            // 
            this.lstth1.FormattingEnabled = true;
            this.lstth1.ItemHeight = 12;
            this.lstth1.Items.AddRange(new object[] {
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70"});
            this.lstth1.Location = new System.Drawing.Point(454, 323);
            this.lstth1.Name = "lstth1";
            this.lstth1.ScrollAlwaysVisible = true;
            this.lstth1.Size = new System.Drawing.Size(120, 64);
            this.lstth1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "角度右";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "角度左";
            // 
            // lstth2
            // 
            this.lstth2.FormattingEnabled = true;
            this.lstth2.ItemHeight = 12;
            this.lstth2.Items.AddRange(new object[] {
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70"});
            this.lstth2.Location = new System.Drawing.Point(454, 416);
            this.lstth2.Name = "lstth2";
            this.lstth2.ScrollAlwaysVisible = true;
            this.lstth2.Size = new System.Drawing.Size(120, 64);
            this.lstth2.TabIndex = 0;
            // 
            // lstper1
            // 
            this.lstper1.FormattingEnabled = true;
            this.lstper1.ItemHeight = 12;
            this.lstper1.Items.AddRange(new object[] {
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7"});
            this.lstper1.Location = new System.Drawing.Point(12, 323);
            this.lstper1.Name = "lstper1";
            this.lstper1.ScrollAlwaysVisible = true;
            this.lstper1.Size = new System.Drawing.Size(120, 64);
            this.lstper1.TabIndex = 0;
            // 
            // lstper2
            // 
            this.lstper2.FormattingEnabled = true;
            this.lstper2.ItemHeight = 12;
            this.lstper2.Items.AddRange(new object[] {
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7"});
            this.lstper2.Location = new System.Drawing.Point(12, 416);
            this.lstper2.Name = "lstper2";
            this.lstper2.ScrollAlwaysVisible = true;
            this.lstper2.Size = new System.Drawing.Size(120, 64);
            this.lstper2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "长度比例系数1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "长度比例系数2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "位置系数";
            // 
            // txtGoldrate
            // 
            this.txtGoldrate.Location = new System.Drawing.Point(12, 273);
            this.txtGoldrate.Name = "txtGoldrate";
            this.txtGoldrate.Size = new System.Drawing.Size(100, 21);
            this.txtGoldrate.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 492);
            this.Controls.Add(this.txtGoldrate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstper2);
            this.Controls.Add(this.lstth2);
            this.Controls.Add(this.lstper1);
            this.Controls.Add(this.lstth1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstth1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstth2;
        private System.Windows.Forms.ListBox lstper1;
        private System.Windows.Forms.ListBox lstper2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGoldrate;
    }
}

