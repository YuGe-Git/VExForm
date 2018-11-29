namespace VExForm
{
    partial class Top_Border
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_Min = new System.Windows.Forms.PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(34, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(56, 14);
            this.lbl_Title.TabIndex = 31;
            this.lbl_Title.Text = "VexForm";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // pic_Min
            // 
            this.pic_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Min.BackColor = System.Drawing.Color.Transparent;
            this.pic_Min.BackgroundImage = global::VExForm.files.min;
            this.pic_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Min.Location = new System.Drawing.Point(272, 0);
            this.pic_Min.Name = "pic_Min";
            this.pic_Min.Size = new System.Drawing.Size(30, 30);
            this.pic_Min.TabIndex = 33;
            this.pic_Min.TabStop = false;
            this.pic_Min.Click += new System.EventHandler(this.pic_Min_Click);
            this.pic_Min.MouseEnter += new System.EventHandler(this.pic_Min_MouseEnter);
            this.pic_Min.MouseLeave += new System.EventHandler(this.pic_Min_MouseLeave);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pic_Exit.BackgroundImage = global::VExForm.files.exit;
            this.pic_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Exit.Location = new System.Drawing.Point(300, 0);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(30, 30);
            this.pic_Exit.TabIndex = 32;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            this.pic_Exit.MouseEnter += new System.EventHandler(this.pic_Min_MouseEnter);
            this.pic_Exit.MouseLeave += new System.EventHandler(this.pic_Min_MouseLeave);
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_Logo.BackgroundImage = global::VExForm.files.VC_Logo_F;
            this.pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_Logo.Location = new System.Drawing.Point(3, 3);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(25, 25);
            this.pic_Logo.TabIndex = 30;
            this.pic_Logo.TabStop = false;
            // 
            // Top_Border
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.pic_Min);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pic_Logo);
            this.Name = "Top_Border";
            this.Size = new System.Drawing.Size(330, 30);
            this.Load += new System.EventHandler(this.Top_Border_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_Border_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_Border_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Min;
        private System.Windows.Forms.PictureBox pic_Exit;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
