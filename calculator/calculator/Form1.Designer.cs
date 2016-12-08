namespace calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.bClr = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bEqu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_clk);
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(32, 23);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.ReadOnly = true;
            this.txtCalc.Size = new System.Drawing.Size(225, 21);
            this.txtCalc.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_clk);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_clk);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_clk);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(92, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_clk);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_clk);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(153, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_clk);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(153, 128);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 40);
            this.button8.TabIndex = 0;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_clk);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(153, 187);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_clk);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(218, 71);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(39, 40);
            this.bPlus.TabIndex = 0;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.btn_Oper);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(218, 115);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(39, 40);
            this.bSub.TabIndex = 0;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.btn_Oper);
            // 
            // bMul
            // 
            this.bMul.Location = new System.Drawing.Point(218, 159);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(39, 40);
            this.bMul.TabIndex = 0;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.btn_Oper);
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(32, 248);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(39, 40);
            this.bDot.TabIndex = 0;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.btn_clk);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(92, 248);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(39, 40);
            this.button14.TabIndex = 0;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btn_clk);
            // 
            // bClr
            // 
            this.bClr.Location = new System.Drawing.Point(153, 248);
            this.bClr.Name = "bClr";
            this.bClr.Size = new System.Drawing.Size(39, 40);
            this.bClr.TabIndex = 0;
            this.bClr.Text = "AC";
            this.bClr.UseVisualStyleBackColor = true;
            this.bClr.Click += new System.EventHandler(this.btn_clr);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(218, 203);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(39, 40);
            this.bDiv.TabIndex = 0;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.btn_Oper);
            // 
            // bEqu
            // 
            this.bEqu.Location = new System.Drawing.Point(218, 247);
            this.bEqu.Name = "bEqu";
            this.bEqu.Size = new System.Drawing.Size(39, 40);
            this.bEqu.TabIndex = 0;
            this.bEqu.Text = "=";
            this.bEqu.UseVisualStyleBackColor = true;
            this.bEqu.Click += new System.EventHandler(this.btn_equ);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 317);
            this.Controls.Add(this.txtCalc);
            this.Controls.Add(this.bEqu);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bClr);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button bClr;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bEqu;
    }
}

