using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace main_page
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
<<<<<<< HEAD

        private void Button_Holding_1(object sender, Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
        {
        	// 在此处添加事件处理程序实现。
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_PointerMoved_1(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
			// 在此处添加事件处理程序实现。
        }


        private void search(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            main_page.App.key = s.Text;
            if (localSettings.Containers.ContainsKey(s.Text))
            {
                var rootFrame = new Frame();
                if (!rootFrame.Navigate(typeof(BlankPage3)))
                {
                    throw new Exception("Failed to create initial page");
                } // Place the frame in the current Window and ensure that it is active 
                Window.Current.Content = rootFrame;
                Window.Current.Activate();
            }
            else
            {
                var rootFrame = new Frame();
                if (!rootFrame.Navigate(typeof(BlankPage1)))
                {
                    throw new Exception("Failed to create initial page");
                } // Place the frame in the current Window and ensure that it is active 
                Window.Current.Content = rootFrame;
                Window.Current.Activate();
            }

        }
=======
>>>>>>> s
    }
}
