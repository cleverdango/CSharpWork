namespace WindowsFormsApp1.OOP264
{
    partial class ComplexForm264
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cmnum1 = new System.Windows.Forms.TextBox();
            this.tb_cmnum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_equal = new System.Windows.Forms.Button();
            this.bt_less = new System.Windows.Forms.Button();
            this.bt_minus = new System.Windows.Forms.Button();
            this.bt_noequal = new System.Windows.Forms.Button();
            this.bt_more = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一个复数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "第二个复数";
            // 
            // tb_cmnum1
            // 
            this.tb_cmnum1.Location = new System.Drawing.Point(85, 92);
            this.tb_cmnum1.Name = "tb_cmnum1";
            this.tb_cmnum1.Size = new System.Drawing.Size(100, 21);
            this.tb_cmnum1.TabIndex = 2;
            this.tb_cmnum1.TextChanged += new System.EventHandler(this.tb_cmnum1_TextChanged);
            // 
            // tb_cmnum2
            // 
            this.tb_cmnum2.Location = new System.Drawing.Point(85, 183);
            this.tb_cmnum2.Name = "tb_cmnum2";
            this.tb_cmnum2.Size = new System.Drawing.Size(100, 21);
            this.tb_cmnum2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "请选择运算符";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(262, 89);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "+";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_equal
            // 
            this.bt_equal.Location = new System.Drawing.Point(369, 89);
            this.bt_equal.Name = "bt_equal";
            this.bt_equal.Size = new System.Drawing.Size(75, 23);
            this.bt_equal.TabIndex = 6;
            this.bt_equal.Text = "==";
            this.bt_equal.UseVisualStyleBackColor = true;
            this.bt_equal.Click += new System.EventHandler(this.bt_equal_Click);
            // 
            // bt_less
            // 
            this.bt_less.Location = new System.Drawing.Point(494, 89);
            this.bt_less.Name = "bt_less";
            this.bt_less.Size = new System.Drawing.Size(75, 23);
            this.bt_less.TabIndex = 7;
            this.bt_less.Text = "<";
            this.bt_less.UseVisualStyleBackColor = true;
            this.bt_less.Click += new System.EventHandler(this.bt_less_Click);
            // 
            // bt_minus
            // 
            this.bt_minus.Location = new System.Drawing.Point(262, 181);
            this.bt_minus.Name = "bt_minus";
            this.bt_minus.Size = new System.Drawing.Size(75, 23);
            this.bt_minus.TabIndex = 8;
            this.bt_minus.Text = "-";
            this.bt_minus.UseVisualStyleBackColor = true;
            this.bt_minus.Click += new System.EventHandler(this.bt_minus_Click);
            // 
            // bt_noequal
            // 
            this.bt_noequal.Location = new System.Drawing.Point(369, 181);
            this.bt_noequal.Name = "bt_noequal";
            this.bt_noequal.Size = new System.Drawing.Size(75, 23);
            this.bt_noequal.TabIndex = 9;
            this.bt_noequal.Text = "!=";
            this.bt_noequal.UseVisualStyleBackColor = true;
            this.bt_noequal.Click += new System.EventHandler(this.bt_noequal_Click);
            // 
            // bt_more
            // 
            this.bt_more.Location = new System.Drawing.Point(494, 181);
            this.bt_more.Name = "bt_more";
            this.bt_more.Size = new System.Drawing.Size(75, 23);
            this.bt_more.TabIndex = 10;
            this.bt_more.Text = ">";
            this.bt_more.UseVisualStyleBackColor = true;
            this.bt_more.Click += new System.EventHandler(this.bt_more_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Location = new System.Drawing.Point(83, 259);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(0, 12);
            this.lb_output.TabIndex = 11;
            // 
            // ComplexForm264
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 384);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.bt_more);
            this.Controls.Add(this.bt_noequal);
            this.Controls.Add(this.bt_minus);
            this.Controls.Add(this.bt_less);
            this.Controls.Add(this.bt_equal);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cmnum2);
            this.Controls.Add(this.tb_cmnum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ComplexForm264";
            this.Text = "ComplexForm264";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cmnum1;
        private System.Windows.Forms.TextBox tb_cmnum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_equal;
        private System.Windows.Forms.Button bt_less;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.Button bt_noequal;
        private System.Windows.Forms.Button bt_more;
        private System.Windows.Forms.Label lb_output;
    }
}