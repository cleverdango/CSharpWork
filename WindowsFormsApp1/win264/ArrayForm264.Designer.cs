namespace WindowsFormsApp1.win264
{
    partial class ArrayForm264
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
            this.lb_input = new System.Windows.Forms.Label();
            this.lb_output = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.bt_sort = new System.Windows.Forms.Button();
            this.bt_n_array = new System.Windows.Forms.Button();
            this.bt_find = new System.Windows.Forms.Button();
            this.lb_n_array = new System.Windows.Forms.Label();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.lb_find = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_input.Location = new System.Drawing.Point(173, 123);
            this.lb_input.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(150, 35);
            this.lb_input.TabIndex = 0;
            this.lb_input.Text = "请输入数组";
            this.lb_input.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_output.Location = new System.Drawing.Point(624, 123);
            this.lb_output.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(150, 35);
            this.lb_output.TabIndex = 1;
            this.lb_output.Text = "排序后数组";
            this.lb_output.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_input.Location = new System.Drawing.Point(179, 198);
            this.tb_input.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(209, 377);
            this.tb_input.TabIndex = 2;
            this.tb_input.TextChanged += new System.EventHandler(this.tb_input_TextChanged);
            // 
            // tb_output
            // 
            this.tb_output.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_output.Location = new System.Drawing.Point(629, 198);
            this.tb_output.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(191, 377);
            this.tb_output.TabIndex = 3;
            // 
            // bt_sort
            // 
            this.bt_sort.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_sort.Location = new System.Drawing.Point(421, 370);
            this.bt_sort.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_sort.Name = "bt_sort";
            this.bt_sort.Size = new System.Drawing.Size(173, 58);
            this.bt_sort.TabIndex = 4;
            this.bt_sort.Text = "数组排序";
            this.bt_sort.UseVisualStyleBackColor = true;
            this.bt_sort.Click += new System.EventHandler(this.bt_sort_Click);
            // 
            // bt_n_array
            // 
            this.bt_n_array.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_n_array.Location = new System.Drawing.Point(197, 648);
            this.bt_n_array.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_n_array.Name = "bt_n_array";
            this.bt_n_array.Size = new System.Drawing.Size(192, 53);
            this.bt_n_array.TabIndex = 5;
            this.bt_n_array.Text = "元素个数";
            this.bt_n_array.UseVisualStyleBackColor = true;
            this.bt_n_array.Click += new System.EventHandler(this.bt_n_array_Click);
            // 
            // bt_find
            // 
            this.bt_find.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_find.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_find.Location = new System.Drawing.Point(197, 776);
            this.bt_find.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(192, 62);
            this.bt_find.TabIndex = 6;
            this.bt_find.Text = "查找元素";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // lb_n_array
            // 
            this.lb_n_array.AutoSize = true;
            this.lb_n_array.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_n_array.Location = new System.Drawing.Point(528, 665);
            this.lb_n_array.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_n_array.Name = "lb_n_array";
            this.lb_n_array.Size = new System.Drawing.Size(248, 35);
            this.lb_n_array.TabIndex = 7;
            this.lb_n_array.Text = "数组中共有n个元素";
            this.lb_n_array.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_find
            // 
            this.tb_find.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_find.Location = new System.Drawing.Point(576, 776);
            this.tb_find.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(132, 43);
            this.tb_find.TabIndex = 8;
            this.tb_find.TextChanged += new System.EventHandler(this.tb_find_TextChanged);
            // 
            // lb_find
            // 
            this.lb_find.AutoSize = true;
            this.lb_find.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_find.Location = new System.Drawing.Point(773, 779);
            this.lb_find.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_find.Name = "lb_find";
            this.lb_find.Size = new System.Drawing.Size(96, 35);
            this.lb_find.TabIndex = 9;
            this.lb_find.Text = "未查询";
            // 
            // ArrayForm264
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 937);
            this.Controls.Add(this.lb_find);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.lb_n_array);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.bt_n_array);
            this.Controls.Add(this.bt_sort);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.lb_input);
            this.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ArrayForm264";
            this.Text = "ArrayForm264";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button bt_sort;
        private System.Windows.Forms.Button bt_n_array;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Label lb_n_array;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Label lb_find;
    }
}