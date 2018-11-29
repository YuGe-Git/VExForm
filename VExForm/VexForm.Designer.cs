namespace VExForm
{
    partial class VexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VexForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.border3 = new VExForm.Controls.Border();
            this.border2 = new VExForm.Controls.Border();
            this.border1 = new VExForm.Controls.Border();
            this.top_Border1 = new VExForm.Top_Border();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // border3
            // 
            this.border3.alignType = System.Windows.Forms.DockStyle.Bottom;
            this.border3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.border3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border3.Location = new System.Drawing.Point(2, 315);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(410, 2);
            this.border3.TabIndex = 3;
            // 
            // border2
            // 
            this.border2.alignType = System.Windows.Forms.DockStyle.Right;
            this.border2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.border2.Dock = System.Windows.Forms.DockStyle.Right;
            this.border2.Location = new System.Drawing.Point(412, 30);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(2, 287);
            this.border2.TabIndex = 2;
            // 
            // border1
            // 
            this.border1.alignType = System.Windows.Forms.DockStyle.Left;
            this.border1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.border1.Dock = System.Windows.Forms.DockStyle.Left;
            this.border1.Location = new System.Drawing.Point(0, 30);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(2, 287);
            this.border1.TabIndex = 1;
            // 
            // top_Border1
            // 
            this.top_Border1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.top_Border1.disableExitButton = true;
            this.top_Border1.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Border1.exitIsShow = true;
            this.top_Border1.ExitText = "退出/关闭";
            this.top_Border1.Location = new System.Drawing.Point(0, 0);
            this.top_Border1.MinText = "最小化";
            this.top_Border1.Name = "top_Border1";
            this.top_Border1.Size = new System.Drawing.Size(414, 30);
            this.top_Border1.TabIndex = 0;
            this.top_Border1.Title = "VexForm";
            this.top_Border1.TitleIcon = ((System.Drawing.Image)(resources.GetObject("top_Border1.TitleIcon")));
            this.top_Border1.TitleIconLayOut = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // VexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 317);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border1);
            this.Controls.Add(this.top_Border1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VexForm";
            this.Load += new System.EventHandler(this.VexForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.Border border1;
        private Controls.Border border2;
        private Controls.Border border3;
        private System.Windows.Forms.Timer timer1;
        public Top_Border top_Border1;
    }
}