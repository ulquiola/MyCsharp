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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.equal = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.LightGray;
            this.equal.Location = new System.Drawing.Point(167, 140);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(31, 68);
            this.equal.TabIndex = 37;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.button18_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.LightGray;
            this.C.Location = new System.Drawing.Point(167, 103);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(31, 31);
            this.C.TabIndex = 36;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.button17_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.LightGray;
            this.CE.Location = new System.Drawing.Point(167, 66);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(31, 31);
            this.CE.TabIndex = 35;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.button16_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.LightGray;
            this.div.Location = new System.Drawing.Point(130, 177);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(31, 31);
            this.div.TabIndex = 34;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.operation_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.LightGray;
            this.mul.Location = new System.Drawing.Point(130, 140);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(31, 31);
            this.mul.TabIndex = 33;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.operation_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.LightGray;
            this.sub.Location = new System.Drawing.Point(130, 103);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(31, 31);
            this.sub.TabIndex = 32;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.operation_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightGray;
            this.add.Location = new System.Drawing.Point(130, 66);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(31, 31);
            this.add.TabIndex = 31;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.operation_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.LightGray;
            this.point.Location = new System.Drawing.Point(93, 177);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(31, 31);
            this.point.TabIndex = 30;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.LightGray;
            this.zero.Location = new System.Drawing.Point(19, 177);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(68, 31);
            this.zero.TabIndex = 29;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.LightGray;
            this.three.Location = new System.Drawing.Point(93, 140);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(31, 31);
            this.three.TabIndex = 28;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.LightGray;
            this.two.Location = new System.Drawing.Point(56, 140);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(31, 31);
            this.two.TabIndex = 27;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.LightGray;
            this.one.Location = new System.Drawing.Point(19, 140);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(31, 31);
            this.one.TabIndex = 26;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.LightGray;
            this.six.Location = new System.Drawing.Point(93, 103);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(31, 31);
            this.six.TabIndex = 25;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.LightGray;
            this.five.Location = new System.Drawing.Point(56, 103);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(31, 31);
            this.five.TabIndex = 24;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.LightGray;
            this.four.Location = new System.Drawing.Point(19, 103);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(31, 31);
            this.four.TabIndex = 23;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.LightGray;
            this.nine.Location = new System.Drawing.Point(93, 66);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(31, 31);
            this.nine.TabIndex = 22;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.LightGray;
            this.eight.Location = new System.Drawing.Point(56, 66);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(31, 31);
            this.eight.TabIndex = 21;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.LightGray;
            this.seven.Location = new System.Drawing.Point(19, 66);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(31, 31);
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(19, 23);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(179, 21);
            this.result.TabIndex = 19;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.Location = new System.Drawing.Point(24, 27);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 12);
            this.equation.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(217, 218);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.result);
            this.MaximumSize = new System.Drawing.Size(233, 257);
            this.MinimumSize = new System.Drawing.Size(233, 257);
            this.Name = "Form1";
            this.Text = "Form1";
          //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equation;
    }
}

