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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace mentalHealth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static String timestamp;
        public static List<String> timeStamps = new List<string>();
        public static List<String> timeStampsMeh = new List<string>();
        public static List<String> timeStampsGood = new List<string>();
        public static List<String> timeStampsAwesome = new List<string>();

        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void sadButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(yuck));
            timestamp = DateTime.Now.ToString();
            timeStamps.Add(timestamp);

        }
        private void mehButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(meh));
            timestamp = DateTime.Now.ToString();
            timeStampsMeh.Add(timestamp);
        }
        private void goodButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(good));
            timestamp = DateTime.Now.ToString();
            timeStampsGood.Add(timestamp);
        }
        private void awesomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(awesome));
            timestamp = DateTime.Now.ToString();
            timeStampsAwesome.Add(timestamp);
        }

        private void diary_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(moodDiary));
        }

        private void tipsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(tips));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
