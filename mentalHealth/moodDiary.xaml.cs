using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace mentalHealth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class moodDiary : Page
    {
        public moodDiary()
        {
            this.InitializeComponent();
            readList();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        public void readList()
        {
            if (mentalHealth.MainPage.timeStamps.Count > 0)
            {
                for (int i = 0; i < mentalHealth.MainPage.timeStamps.Count; i++)
                {
                    yuckTxtBlock.Text += mentalHealth.MainPage.timeStamps[i] + "\n";
                }
            }

            if (mentalHealth.MainPage.timeStampsMeh.Count > 0)
            {
                for (int i = 0; i < mentalHealth.MainPage.timeStampsMeh.Count; i++)
                {
                    mehTxtBlock.Text += mentalHealth.MainPage.timeStamps[i] + "\n";
                }
            }

            if (mentalHealth.MainPage.timeStampsGood.Count > 0)
            {
                for (int i = 0; i < mentalHealth.MainPage.timeStampsGood.Count; i++)
                {
                    goodTxtBlock.Text += mentalHealth.MainPage.timeStamps[i] + "\n";
                }
            }

            if (mentalHealth.MainPage.timeStampsAwesome.Count > 0)
            {
                for (int i = 0; i < mentalHealth.MainPage.timeStampsAwesome.Count; i++)
                {
                    awesomeTxtBlock.Text += mentalHealth.MainPage.timeStamps[i] + "\n";
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mentalHealth.MainPage.timeStamps.Clear();
            mentalHealth.MainPage.timeStampsMeh.Clear();
            mentalHealth.MainPage.timeStampsGood.Clear();
            mentalHealth.MainPage.timeStampsAwesome.Clear();

            awesomeTxtBlock.Text = "";
            mehTxtBlock.Text = "";
            goodTxtBlock.Text = "";
            yuckTxtBlock.Text = "";
        }

       
    }
}
