namespace WindowsFormsApp1.win264
{
    partial class ControlForm264
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
            this.lb_no = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_birth = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_nation = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.rb_boy = new System.Windows.Forms.RadioButton();
            this.rb_girl = new System.Windows.Forms.RadioButton();
            this.cb_nation = new System.Windows.Forms.ComboBox();
            this.gb_pt = new System.Windows.Forms.GroupBox();
            this.rb_pt3 = new System.Windows.Forms.RadioButton();
            this.rb_pt2 = new System.Windows.Forms.RadioButton();
            this.rb_pt1 = new System.Windows.Forms.RadioButton();
            this.gb_jg = new System.Windows.Forms.GroupBox();
            this.cboShi = new System.Windows.Forms.ComboBox();
            this.cboSheng = new System.Windows.Forms.ComboBox();
            this.lb_shi = new System.Windows.Forms.Label();
            this.lb_sheng = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_no = new System.Windows.Forms.MaskedTextBox();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.lb_all = new System.Windows.Forms.ListBox();
            this.gb_pt.SuspendLayout();
            this.gb_jg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_no
            // 
            this.lb_no.AutoSize = true;
            this.lb_no.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_no.Location = new System.Drawing.Point(94, 64);
            this.lb_no.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_no.Name = "lb_no";
            this.lb_no.Size = new System.Drawing.Size(94, 24);
            this.lb_no.TabIndex = 1;
            this.lb_no.Text = "学号&X：";
            this.lb_no.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_name.Location = new System.Drawing.Point(94, 134);
            this.lb_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(94, 24);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "姓名&E：";
            // 
            // lb_birth
            // 
            this.lb_birth.AutoSize = true;
            this.lb_birth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_birth.Location = new System.Drawing.Point(94, 204);
            this.lb_birth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_birth.Name = "lb_birth";
            this.lb_birth.Size = new System.Drawing.Size(142, 24);
            this.lb_birth.TabIndex = 5;
            this.lb_birth.Text = "出生日期&D：";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_gender.Location = new System.Drawing.Point(94, 274);
            this.lb_gender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(82, 24);
            this.lb_gender.TabIndex = 7;
            this.lb_gender.Text = "性别：";
            // 
            // lb_nation
            // 
            this.lb_nation.AutoSize = true;
            this.lb_nation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_nation.Location = new System.Drawing.Point(98, 354);
            this.lb_nation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_nation.Name = "lb_nation";
            this.lb_nation.Size = new System.Drawing.Size(94, 24);
            this.lb_nation.TabIndex = 10;
            this.lb_nation.Text = "民族&M：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(234, 128);
            this.tb_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(196, 35);
            this.tb_name.TabIndex = 4;
            // 
            // rb_boy
            // 
            this.rb_boy.AutoSize = true;
            this.rb_boy.Location = new System.Drawing.Point(234, 274);
            this.rb_boy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_boy.Name = "rb_boy";
            this.rb_boy.Size = new System.Drawing.Size(64, 28);
            this.rb_boy.TabIndex = 8;
            this.rb_boy.TabStop = true;
            this.rb_boy.Text = "男&B";
            this.rb_boy.UseVisualStyleBackColor = true;
            // 
            // rb_girl
            // 
            this.rb_girl.AutoSize = true;
            this.rb_girl.Location = new System.Drawing.Point(370, 274);
            this.rb_girl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_girl.Name = "rb_girl";
            this.rb_girl.Size = new System.Drawing.Size(64, 28);
            this.rb_girl.TabIndex = 9;
            this.rb_girl.TabStop = true;
            this.rb_girl.Text = "女&G";
            this.rb_girl.UseVisualStyleBackColor = true;
            // 
            // cb_nation
            // 
            this.cb_nation.FormattingEnabled = true;
            this.cb_nation.Items.AddRange(new object[] {
            "汉族",
            "壮族",
            "回族",
            "满族",
            "维吾尔族",
            "苗族",
            "彝族",
            "土家族",
            "藏族",
            "蒙古族",
            "侗族",
            "布依族",
            "瑶族",
            "白族",
            "朝鲜族",
            "哈尼族",
            "黎族",
            "哈萨克族",
            "傣族",
            "畲族",
            "傈僳族",
            "东乡族",
            "仡佬族",
            "拉祜族",
            "佤族",
            "水族",
            "纳西族",
            "羌族",
            "土族",
            "仫佬族",
            "锡伯族",
            "柯尔克孜族",
            "景颇族",
            "达斡尔族",
            "撒拉族",
            "布朗族",
            "毛南族",
            "塔吉克族",
            "普米族",
            "阿昌族",
            "怒族",
            "鄂温克族",
            "京族",
            "基诺族",
            "德昂族",
            "保安族",
            "俄罗斯族",
            "裕固族",
            "乌孜别克族",
            "门巴族",
            "鄂伦春族",
            "独龙族",
            "赫哲族",
            "高山族",
            "珞巴族",
            "塔塔尔族"});
            this.cb_nation.Location = new System.Drawing.Point(210, 354);
            this.cb_nation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_nation.Name = "cb_nation";
            this.cb_nation.Size = new System.Drawing.Size(238, 32);
            this.cb_nation.TabIndex = 11;
            // 
            // gb_pt
            // 
            this.gb_pt.Controls.Add(this.rb_pt3);
            this.gb_pt.Controls.Add(this.rb_pt2);
            this.gb_pt.Controls.Add(this.rb_pt1);
            this.gb_pt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_pt.Location = new System.Drawing.Point(80, 478);
            this.gb_pt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_pt.Name = "gb_pt";
            this.gb_pt.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_pt.Size = new System.Drawing.Size(400, 200);
            this.gb_pt.TabIndex = 12;
            this.gb_pt.TabStop = false;
            this.gb_pt.Text = "政治面貌";
            // 
            // rb_pt3
            // 
            this.rb_pt3.AutoSize = true;
            this.rb_pt3.Location = new System.Drawing.Point(80, 130);
            this.rb_pt3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_pt3.Name = "rb_pt3";
            this.rb_pt3.Size = new System.Drawing.Size(64, 28);
            this.rb_pt3.TabIndex = 2;
            this.rb_pt3.TabStop = true;
            this.rb_pt3.Text = "无&W";
            this.rb_pt3.UseVisualStyleBackColor = true;
            // 
            // rb_pt2
            // 
            this.rb_pt2.AutoSize = true;
            this.rb_pt2.Location = new System.Drawing.Point(80, 84);
            this.rb_pt2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_pt2.Name = "rb_pt2";
            this.rb_pt2.Size = new System.Drawing.Size(88, 28);
            this.rb_pt2.TabIndex = 1;
            this.rb_pt2.TabStop = true;
            this.rb_pt2.Text = "团员&T";
            this.rb_pt2.UseVisualStyleBackColor = true;
            // 
            // rb_pt1
            // 
            this.rb_pt1.AutoSize = true;
            this.rb_pt1.Location = new System.Drawing.Point(80, 40);
            this.rb_pt1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_pt1.Name = "rb_pt1";
            this.rb_pt1.Size = new System.Drawing.Size(88, 28);
            this.rb_pt1.TabIndex = 0;
            this.rb_pt1.TabStop = true;
            this.rb_pt1.Text = "党员&D";
            this.rb_pt1.UseVisualStyleBackColor = true;
            // 
            // gb_jg
            // 
            this.gb_jg.Controls.Add(this.cboShi);
            this.gb_jg.Controls.Add(this.cboSheng);
            this.gb_jg.Controls.Add(this.lb_shi);
            this.gb_jg.Controls.Add(this.lb_sheng);
            this.gb_jg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_jg.Location = new System.Drawing.Point(552, 478);
            this.gb_jg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_jg.Name = "gb_jg";
            this.gb_jg.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_jg.Size = new System.Drawing.Size(400, 200);
            this.gb_jg.TabIndex = 13;
            this.gb_jg.TabStop = false;
            this.gb_jg.Text = "籍贯";
            // 
            // cboShi
            // 
            this.cboShi.FormattingEnabled = true;
            this.cboShi.Location = new System.Drawing.Point(130, 114);
            this.cboShi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboShi.Name = "cboShi";
            this.cboShi.Size = new System.Drawing.Size(238, 32);
            this.cboShi.TabIndex = 4;
            this.cboShi.SelectedIndexChanged += new System.EventHandler(this.cboShi_SelectedIndexChanged);
            // 
            // cboSheng
            // 
            this.cboSheng.FormattingEnabled = true;
            this.cboSheng.Items.AddRange(new object[] {
            "福建省",
            "江西省"});
            this.cboSheng.Location = new System.Drawing.Point(130, 42);
            this.cboSheng.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboSheng.Name = "cboSheng";
            this.cboSheng.Size = new System.Drawing.Size(238, 32);
            this.cboSheng.TabIndex = 1;
            this.cboSheng.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lb_shi
            // 
            this.lb_shi.AutoSize = true;
            this.lb_shi.Location = new System.Drawing.Point(36, 120);
            this.lb_shi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_shi.Name = "lb_shi";
            this.lb_shi.Size = new System.Drawing.Size(46, 24);
            this.lb_shi.TabIndex = 2;
            this.lb_shi.Text = "市&C";
            this.lb_shi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_sheng
            // 
            this.lb_sheng.AutoSize = true;
            this.lb_sheng.Location = new System.Drawing.Point(36, 48);
            this.lb_sheng.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_sheng.Name = "lb_sheng";
            this.lb_sheng.Size = new System.Drawing.Size(46, 24);
            this.lb_sheng.TabIndex = 0;
            this.lb_sheng.Text = "省&P";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1054, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "确定&Y";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1054, 594);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 17;
            this.button2.Text = "取消&N";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(752, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "输入的信息如下：";
            // 
            // mtb_no
            // 
            this.mtb_no.Location = new System.Drawing.Point(234, 56);
            this.mtb_no.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mtb_no.Mask = "999999";
            this.mtb_no.Name = "mtb_no";
            this.mtb_no.Size = new System.Drawing.Size(196, 35);
            this.mtb_no.TabIndex = 2;
            // 
            // dtp_birth
            // 
            this.dtp_birth.Location = new System.Drawing.Point(234, 192);
            this.dtp_birth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(264, 35);
            this.dtp_birth.TabIndex = 6;
            // 
            // lb_all
            // 
            this.lb_all.FormattingEnabled = true;
            this.lb_all.ItemHeight = 24;
            this.lb_all.Location = new System.Drawing.Point(756, 98);
            this.lb_all.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lb_all.Name = "lb_all";
            this.lb_all.Size = new System.Drawing.Size(380, 292);
            this.lb_all.TabIndex = 15;
            this.lb_all.SelectedIndexChanged += new System.EventHandler(this.lb_all_SelectedIndexChanged);
            // 
            // ControlForm264
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 794);
            this.Controls.Add(this.lb_all);
            this.Controls.Add(this.dtp_birth);
            this.Controls.Add(this.mtb_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_jg);
            this.Controls.Add(this.gb_pt);
            this.Controls.Add(this.cb_nation);
            this.Controls.Add(this.rb_girl);
            this.Controls.Add(this.rb_boy);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_nation);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_birth);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_no);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ControlForm264";
            this.Text = "ControlForm264";
            this.gb_pt.ResumeLayout(false);
            this.gb_pt.PerformLayout();
            this.gb_jg.ResumeLayout(false);
            this.gb_jg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_no;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_birth;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_nation;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RadioButton rb_boy;
        private System.Windows.Forms.RadioButton rb_girl;
        private System.Windows.Forms.ComboBox cb_nation;
        private System.Windows.Forms.GroupBox gb_pt;
        private System.Windows.Forms.RadioButton rb_pt3;
        private System.Windows.Forms.RadioButton rb_pt2;
        private System.Windows.Forms.RadioButton rb_pt1;
        private System.Windows.Forms.GroupBox gb_jg;
        private System.Windows.Forms.ComboBox cboShi;
        private System.Windows.Forms.ComboBox cboSheng;
        private System.Windows.Forms.Label lb_shi;
        private System.Windows.Forms.Label lb_sheng;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_no;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.ListBox lb_all;
    }
}