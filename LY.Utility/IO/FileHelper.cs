using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Text;
using LY.Models;
using LY.Models.Message;

namespace LY.Utility.IO
{
    /// <summary>
    /// 文件操作辅助类
    /// </summary>
    public class FileHelper
    {
        #region 常量定义
        /// <summary>
        /// 读取文件的缓存区大小
        /// </summary>
        private const int BUFFER_SIZE = 4096;
        #endregion

        #region 文件读写

        public static byte[] ReadAllBytes(string path, ErrorMsg msg)
        {
            if (string.IsNullOrEmpty(path))
            {
                msg.ErrorContent = "文件路径为空.";
                msg.ErrorFrom = "IO.FileHelper";
                return null;
            }
            return File.ReadAllBytes(path);
        }

        /// <summary>
        /// 打开一个文件，向其中追加指定的字符串，然后关闭该文件。如果文件不存在，此方法将创建一个文件，将指定的字符串写入文件，然后关闭该文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="contents">追加内容</param>
        public static void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path,contents);
        }

        /// <summary>
        /// 按照指定格式进行文件写入
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        public static void AppendAllText(string path, string contents, Encoding encoding)
        {
            encoding = encoding ?? Encoding.UTF8;
            File.AppendAllText(path, contents, encoding);
        }
        #endregion
    }
}
