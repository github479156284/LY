using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LY.Utility;
using LY.Utility.IO;
using NUnit.Framework;
using LY.Models;
using LY.Models.Message;

namespace LY.Nunit
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Show()
        {
            string path = @"d:\111\111.txt";
            ErrorMsg msg=new ErrorMsg();
            byte[] bt = FileHelper.ReadAllBytes(path, msg);
            Console.WriteLine(bt.Length);
            Console.ReadKey();
        }
    }
}
