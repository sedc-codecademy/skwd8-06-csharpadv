using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class13.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //DownloadHtmlFromInternet("https://www.stackoverflow.com");
            //DownloadHtmlFromInternetAsync("https://www.stackoverflow.com");

            var html = await GetHtmlAsync("https://www.stackoverflow.com");
            MessageBox.Show(html.Substring(0, 5));
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task DownloadHtmlFromInternetAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWritter = new StreamWriter(@"C:\Async\result.html"))
            {
                await streamWritter.WriteAsync(html);
            }
        }

        public void DownloadHtmlFromInternet(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWritter = new StreamWriter(@"C:\Async\result.html"))
            {
                streamWritter.Write(html);
            }
        }

    }
}
