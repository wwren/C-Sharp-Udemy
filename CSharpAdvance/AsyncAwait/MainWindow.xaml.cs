using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           /* DownloadHtmlAsync( "http://msdn.microsoft.com");*/
          /* var html = await GetHtmlAsync("http://msdn.microsoft.com"); // to put await here to get the actual string*/

           var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com"); //Task object 'getHtmlTask' that represents the state of that asynchronous operation
           var html = await getHtmlTask; // the rest will not be executed until await operation is completed & the control returns to the UI, so UI is responsive
           MessageBox.Show(html.Substring(0, 10));

        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url); // tell runtime not to wait until the return of this method but continue executing
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url); 
            // await doesn't mean to wait. await is a marker that tells compiler that this operation is more costly & will take more time
            // instead of blocking the thread, it will return the control immediately to the caller of this method 'DownloadHtmlAsync'
            // DownloadHtml is called in the Button_Click -> so UI immediately becomes responsive
            // when the DownloadStringTaskAsync is completed, runtime will return here & execute the rest of the method
            // the using streamWriter is like a callback function that runs after the await function
            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
/*        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                streamWriter.Write(html);
            }
        }*/
    }
}
