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
using Windows.Storage;
// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace main_page
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            this.Loaded += BlankPage1_Loaded; 
        }

        void BlankPage1_Loaded(object sender, RoutedEventArgs e)
        {
             Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
             if (localSettings.Containers.ContainsKey(main_page.App.key))
             {
                 fz.Text = (string)localSettings.Containers[main_page.App.key].Values["fz"];
                 dc.Text = (string)localSettings.Containers[main_page.App.key].Values["dc"];
                 sy.Text = (string)localSettings.Containers[main_page.App.key].Values["sy"];
                 sx.Text = (string)localSettings.Containers[main_page.App.key].Values["sx"];

             }
             else
             {
                 dc.Text = main_page.App.key;
             }
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        private void shittt(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            if (localSettings.Containers.ContainsKey(main_page.App.key))
            {
                fz.Text = (string)localSettings.Containers[main_page.App.key].Values["fz"];
                dc.Text = (string)localSettings.Containers[main_page.App.key].Values["dc"];
                sy.Text = (string)localSettings.Containers[main_page.App.key].Values["sy"];
                sx.Text = (string)localSettings.Containers[main_page.App.key].Values["sx"];
               
            }
        }

        private void add(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            ApplicationDataContainer container = localSettings.CreateContainer(dc.Text, ApplicationDataCreateDisposition.Always);
            if (localSettings.Containers.ContainsKey(dc.Text))
            {
                localSettings.Containers[dc.Text].Values["fz"] = fz.Text;
                localSettings.Containers[dc.Text].Values["dc"] = dc.Text;
                localSettings.Containers[dc.Text].Values["sy"] = sy.Text;
                localSettings.Containers[dc.Text].Values["sx"] = sx.Text;
            }
        }


    }
}
