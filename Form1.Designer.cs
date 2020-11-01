namespace collegesystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar3 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(883, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "College Managment System";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(547, 12);
            this.bunifuProgressBar1.TabIndex = 0;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(1, 326);
            this.bunifuProgressBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.White;
            this.bunifuProgressBar2.Size = new System.Drawing.Size(935, 12);
            this.bunifuProgressBar2.TabIndex = 1;
            this.bunifuProgressBar2.Value = 0;
            // 
            // bunifuProgressBar3
            // 
            this.bunifuProgressBar3.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuProgressBar3.BorderRadius = 5;
            this.bunifuProgressBar3.Location = new System.Drawing.Point(1, 326);
            this.bunifuProgressBar3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar3.MaximumValue = 100;
            this.bunifuProgressBar3.Name = "bunifuProgressBar3";
            this.bunifuProgressBar3.ProgressColor = System.Drawing.Color.White;
            this.bunifuProgressBar3.Size = new System.Drawing.Size(1218, 12);
            this.bunifuProgressBar3.TabIndex = 2;
            this.bunifuProgressBar3.Value = 0;
            this.bunifuProgressBar3.progressChanged += new System.EventHandler(this.bunifuProgressBar3_progressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1218, 336);
            this.Controls.Add(this.bunifuProgressBar3);
            this.Controls.Add(this.bunifuProgressBar2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar3;
    }
}

