using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//添加selenium的引用
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
//添加引用-在程序集中添加System.Drawing
using System.Drawing.Imaging;



namespace selenium
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //指定IEdriver server的位置
            var  driver = new InternetExplorerDriver(@"C:\Users\bonree\Desktop\selenium\selenium\packages\Selenium.WebDriver.3.7.0\");

            //进入指定的网页
            driver.Navigate().GoToUrl(@"http://www.baidu.com");

            //截图
            driver.GetScreenshot().SaveAsFile(@"c:\Users\bonree\Desktop\test.jpeg", ScreenshotImageFormat.Jpeg);


            //设置页面大小 w h
            driver.Manage().Window.Size = new System.Drawing.Size(100, 200);

            //设置窗体最大化
            driver.Manage().Window.Maximize();

            //页面前进，后退
            driver.Navigate().Forward();
            driver.Navigate().Back();



            //处理弹出框
            driver.SwitchTo().Alert().Accept();//简单讲就是点击yes
            driver.SwitchTo().Alert().Dismiss();//点击No



            //退出
            driver.Quit();
           

            
        }
    }
}

