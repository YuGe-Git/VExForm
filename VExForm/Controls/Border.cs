using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VExForm.Controls
{
    public partial class Border : UserControl
    {
        public Border()
        {
            InitializeComponent();
        }
        #region 自定义属性
        [Description("对其方式")]
        public DockStyle alignType
        {
            get
            {
                return this.Dock;
            }
            set
            {
                if (value == DockStyle.Left || value == DockStyle.Right)
                    this.Width = 2;
                if (value == DockStyle.Top || value == DockStyle.Bottom)
                    this.Height = 2;
                this.Dock = value;
            }
        }
        #endregion
        private void Border_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(Theme.Color);
        }
    }
}
