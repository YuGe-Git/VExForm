using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace VExForm
{
    public partial class Top_Border : UserControl
    {
        #region 初始化
        public Top_Border()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(Theme.Color);

        }
        #endregion

        #region  字段/属性
        Form fm;
        int x;
        int y;
        #endregion

        #region 自定义控件属性
        [Description("标题栏文本")]
        public string Title
        {
            get
            {
                return lbl_Title.Text;
            }
            set
            {
                lbl_Title.Text = value;
            }
        }

        [Description("标题栏图标")]
        public Image TitleIcon
        {
            get
            {
                return pic_Logo.BackgroundImage;
            }
            set
            {
                pic_Logo.BackgroundImage = value;
            }
        }

        [Description("标题栏图标对齐方式")]
        public ImageLayout TitleIconLayOut
        {
            get
            {
                return pic_Logo.BackgroundImageLayout;
            }
            set
            {
                pic_Logo.BackgroundImageLayout = value;
            }
        }
        [Description("退出按钮的提示文字")]
        public string ExitText
        {
            set
            {
                toolTip1.SetToolTip(this.pic_Exit, value);
            }
            get
            {
                return toolTip1.GetToolTip(this.pic_Exit);
            }
        }
        [Description("最小化的提示文字")]
        public string MinText
        {
            set
            {
                toolTip1.SetToolTip(this.pic_Min, value);
            }
            get
            {
                return toolTip1.GetToolTip(this.pic_Min);
            }
        }
        [Description("是否禁止关闭按钮")]
        public bool disableExitButton
        {
            set
            {
                if (value)
                {
                    pic_Exit.Enabled = true;
                }
                else
                {
                    pic_Exit.Enabled = false;
                }
            }
            get
            {
                if (pic_Exit.Enabled == true)
                    return true;
                else
                    return false;
            }
        }
        [Description("是否显示关闭缩小按钮")]
        public bool exitIsShow
        {
            set
            {
                if (value)
                {
                    pic_Exit.Visible = true;
                    pic_Min.Visible = true;
                }
                else
                {
                    pic_Exit.Visible = false;
                    pic_Min.Visible = false;
                }
            }
            get
            {
                if (pic_Exit.Visible == true)
                    return true;
                else
                    return false;
            }
        }
        #endregion

        #region Exit / Min 按钮动画
        private void pic_Min_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;    //转换PictureBox对象
            //图像操作
            if (pic.Name == this.pic_Exit.Name)
                pic.BackgroundImage = files.exit2;
            else
                pic.BackgroundImage = files.min2;
        }

        private void pic_Min_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;    //转换PictureBox对象
            //图像操作
            if (pic.Name == this.pic_Exit.Name)
                pic.BackgroundImage = files.exit;
            else
                pic.BackgroundImage = files.min;
        }
        #endregion

        #region 窗体移动
        private void Top_Border_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }
        private void Top_Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fm.Left += e.X - x;
                fm.Top += e.Y - y;
            }
        }
        #endregion

        #region 加载事件
        private void Top_Border_Load(object sender, EventArgs e)
        {
            fm = (Form)this.Parent;
            if (fm == null)
            {
                /*
                 *  Logs.WriteLine(true, "{0}：{1}", "错误", "捕捉父级窗体异常，程序退出");
                 *  此代码为  本人开发的另一个WinForn调用cmd窗口 实现日志输出的 小项目
                 *  可以在我的GitHub查看
                 *  或者加入QQ群：801557091
                 */
            }
        }


        #endregion

        #region Min  / Exit 点击事件
        private void pic_Min_Click(object sender, EventArgs e)
        {
            if (fm != null)
                fm.WindowState = FormWindowState.Minimized;
        }

        private void pic_Exit_Click(object sender, EventArgs e)
        {
            if (fm == null)
                return;
            while (fm.Opacity > 0)
            {
                fm.Opacity -= 0.2;
                Thread.Sleep(100);
            }
            if ("FrmMain" == fm.Name)
                Application.Exit(); //经测试此方法退出会留下线程（如果有开启线程的话）
                                    //System.Environment.Exit(0);   彻底退出
            else
                fm.Close();
        }
        #endregion
    }
}
