using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace BilingualSearch
{
    public partial class MainWindow : Window
    {
        List<string> urls = new List<string>();
        string giurl = "https://translate.google.com/translate?hl=en&sl=de&tl=en&u=https%3A%2F%2Fwww.google.de%2Fsearch%3Fq%3D{0}%26num%3D10%26hl%3Dhu%26tbo%3Dd%26site%3Dimghp%26tbm%3Disch%26sout%3D1%26biw%3D1075%26bih%3D696";
        string forurl = "http://www.forvo.com/word/{0}/#de";
        string dicturl = "https://de.pons.com/%C3%BCbersetzung?q={0}&l=deen&in=&lf=de";
        string g2gdicturl = "https://de.thefreedictionary.com/{0}";
        string chromepath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
        string firefoxpath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
        public MainWindow()
        {
            InitializeComponent();
            txtSearch.Text = "hund";
            urls.Add(giurl);
            urls.Add(forurl);
            urls.Add(dicturl);
            urls.Add(g2gdicturl);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateTabs(urls, txtSearch.Text);
        }

        private void CreateTabs(List<string> urls, string var1)
        {
            string param = string.Join(" ", urls.ToArray());
            param = string.Format(param, var1);
            
            Process.Start(firefoxpath, param);
        }
    }
}
