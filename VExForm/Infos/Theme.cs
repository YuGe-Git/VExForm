
namespace VExForm
{
    /// <summary>
    /// 主题颜色实体类
    /// </summary>
    public static class Theme
    {
        private static string color;

        /// <summary>
        /// VExForm主题色设置
        /// 提供Get 和 Set 方法
        /// 默认为： 5C6BC0
        /// 存放#颜色
        /// </summary>
        public static string Color
        {
            get
            {
                if (color == "" || color == null)
                    return "#5C6BC0";
                else
                    return color;
            }
            set
            {
                color = value;
            }
        }
       
    }
}
