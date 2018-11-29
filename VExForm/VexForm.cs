using System;
using System.Windows.Forms;

/**
 *  作者： 煜哥
 *  邮箱： for-start@qq.com
 *  交流群： 801557091
 *  编写时间： 2018-11-29 13:11 —— 2018-11-29 13:36
 *  
 *  如只是作为使用者：  using VExForm.dll 使用即可
 *  如需要自行修改原代码： 请尊重作者 留下此话 并下面有模板
 * */

    /**
     *  二次开发：
     *  时间：
     *  修改内容/功能：
     * */

namespace VExForm
{
    public partial class VexForm : Form
    {
        public VexForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;  //开启界面双缓冲模式 （有效解决界面闪烁）
            this.Opacity = 0;
        }

        //窗体load事件
        private void VexForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //timer控件 实现渐显动画效果
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.2;
            else
                timer1.Stop();
        }
    }
}
