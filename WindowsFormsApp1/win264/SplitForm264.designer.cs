namespace WindowsFormsApp1.win264
{
    partial class SplitForm264
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSplitedList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入用逗号分隔的字符串";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(28, 114);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(512, 35);
            this.textBoxInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "转换成数组";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSplitedList
            // 
            this.textBoxSplitedList.Location = new System.Drawing.Point(24, 168);
            this.textBoxSplitedList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSplitedList.Multiline = true;
            this.textBoxSplitedList.Name = "textBoxSplitedList";
            this.textBoxSplitedList.Size = new System.Drawing.Size(516, 328);
            this.textBoxSplitedList.TabIndex = 1;
            this.textBoxSplitedList.TextChanged += new System.EventHandler(this.textBoxSplitedList_TextChanged);
            // 
            // SplitForm264
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSplitedList);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SplitForm264";
            this.Text = "SplitForm264";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSplitedList;
    }
}