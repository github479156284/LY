using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LY.Models.Message
{
    /// <summary>
    /// 错误信息类
    /// </summary>
    public class ErrorMsg
    {
        /// <summary>
        /// 错误消息代码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息内容
        /// </summary>
        public string ErrorContent { get; set; }

        /// <summary>
        /// 错误消息来源哪个模块
        /// </summary>
        public string ErrorFrom { get; set; }
    }
}
