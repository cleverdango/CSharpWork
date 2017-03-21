namespace WindowsFormsApp1.win264
{
    partial class DateTimeForm264
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
            this.tb_year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_day = new System.Windows.Forms.TextBox();
            this.calc_month = new System.Windows.Forms.Button();
            this.calc_span = new System.Windows.Forms.Button();
            this.tb_span = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_newday = new System.Windows.Forms.Label();
            this.lb_week = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入日期：";
            // 
            // tb_year
            // 
            this.tb_year.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_year.Location = new System.Drawing.Point(265, 90);
            this.tb_year.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(124, 41);
            this.tb_year.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(400, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "年";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(640, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "月";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(910, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "日";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_month
            // 
            this.tb_month.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_month.Location = new System.Drawing.Point(510, 90);
            this.tb_month.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(124, 41);
            this.tb_month.TabIndex = 5;
            this.tb_month.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_day
            // 
            this.tb_day.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_day.Location = new System.Drawing.Point(760, 91);
            this.tb_day.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(124, 41);
            this.tb_day.TabIndex = 6;
            this.tb_day.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // calc_month
            // 
            this.calc_month.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calc_month.Location = new System.Drawing.Point(245, 246);
            this.calc_month.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calc_month.Name = "calc_month";
            this.calc_month.Size = new System.Drawing.Size(210, 80);
            this.calc_month.TabIndex = 7;
            this.calc_month.Text = "计算星期";
            this.calc_month.UseVisualStyleBackColor = true;
            this.calc_month.Click += new System.EventHandler(this.button1_Click);
            // 
            // calc_span
            // 
            this.calc_span.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calc_span.Location = new System.Drawing.Point(230, 493);
            this.calc_span.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calc_span.Name = "calc_span";
            this.calc_span.Size = new System.Drawing.Size(225, 80);
            this.calc_span.TabIndex = 8;
            this.calc_span.Text = "计算";
            this.calc_span.UseVisualStyleBackColor = true;
            this.calc_span.Click += new System.EventHandler(this.calc_span_Click);
            // 
            // tb_span
            // 
            this.tb_span.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_span.Location = new System.Drawing.Point(510, 529);
            this.tb_span.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_span.Name = "tb_span";
            this.tb_span.Size = new System.Drawing.Size(124, 41);
            this.tb_span.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(657, 533);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "天之后的日期：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 11;
            // 
            // lb_newday
            // 
            this.lb_newday.AutoSize = true;
            this.lb_newday.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_newday.Location = new System.Drawing.Point(875, 529);
            this.lb_newday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_newday.Name = "lb_newday";
            this.lb_newday.Size = new System.Drawing.Size(220, 29);
            this.lb_newday.TabIndex = 12;
            this.lb_newday.Text = "xxxx年xx月xx日";
            // 
            // lb_week
            // 
            this.lb_week.AutoSize = true;
            this.lb_week.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_week.Location = new System.Drawing.Point(610, 301);
            this.lb_week.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_week.Name = "lb_week";
            this.lb_week.Size = new System.Drawing.Size(103, 29);
            this.lb_week.TabIndex = 13;
            this.lb_week.Text = "unknow";
            // 
            // DateTimeForm264
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 686);
            this.Controls.Add(this.lb_week);
            this.Controls.Add(this.lb_newday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_span);
            this.Controls.Add(this.calc_span);
            this.Controls.Add(this.calc_month);
            this.Controls.Add(this.tb_day);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DateTimeForm264";
            this.Text = "DateTimeForm264";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.Button calc_month;
        private System.Windows.Forms.Button calc_span;
        private System.Windows.Forms.TextBox tb_span;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_newday;
        private System.Windows.Forms.Label lb_week;
    }
}