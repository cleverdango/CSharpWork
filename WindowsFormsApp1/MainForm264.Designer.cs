namespace WindowsFormsApp1.win264
{
    partial class MainForm264
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm264));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exper2 = new System.Windows.Forms.Button();
            this.Exper3 = new System.Windows.Forms.Button();
            this.Exper4 = new System.Windows.Forms.Button();
            this.Exper5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 282);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Exper2
            // 
            this.Exper2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exper2.Location = new System.Drawing.Point(87, 372);
            this.Exper2.Name = "Exper2";
            this.Exper2.Size = new System.Drawing.Size(232, 70);
            this.Exper2.TabIndex = 2;
            this.Exper2.Text = "实验二";
            this.Exper2.UseVisualStyleBackColor = true;
            this.Exper2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exper3
            // 
            this.Exper3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exper3.Location = new System.Drawing.Point(412, 372);
            this.Exper3.Name = "Exper3";
            this.Exper3.Size = new System.Drawing.Size(232, 70);
            this.Exper3.TabIndex = 3;
            this.Exper3.Text = "实验三";
            this.Exper3.UseVisualStyleBackColor = true;
            this.Exper3.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exper4
            // 
            this.Exper4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exper4.Location = new System.Drawing.Point(87, 479);
            this.Exper4.Name = "Exper4";
            this.Exper4.Size = new System.Drawing.Size(232, 70);
            this.Exper4.TabIndex = 4;
            this.Exper4.Text = "实验四";
            this.Exper4.UseVisualStyleBackColor = true;
            this.Exper4.Click += new System.EventHandler(this.button3_Click);
            // 
            // Exper5
            // 
            this.Exper5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exper5.Location = new System.Drawing.Point(412, 479);
            this.Exper5.Name = "Exper5";
            this.Exper5.Size = new System.Drawing.Size(232, 70);
            this.Exper5.TabIndex = 5;
            this.Exper5.Text = "实验五";
            this.Exper5.UseVisualStyleBackColor = true;
            // 
            // MainForm264
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 609);
            this.Controls.Add(this.Exper5);
            this.Controls.Add(this.Exper4);
            this.Controls.Add(this.Exper3);
            this.Controls.Add(this.Exper2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm264";
            this.Text = "211406264成雯珺";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exper2;
        private System.Windows.Forms.Button Exper3;
        private System.Windows.Forms.Button Exper4;
        private System.Windows.Forms.Button Exper5;
    }
}