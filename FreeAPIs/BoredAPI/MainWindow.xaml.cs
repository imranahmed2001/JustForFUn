using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace BoredAPI
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //List<TheBoredAPI> information = new List<TheBoredAPI>();
            List<TheBoredAPI> apiInfo;

            string url = "http://www.boredapi.com/api/activity/";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                TheBoredAPI api = JsonConvert.DeserializeObject<TheBoredAPI>(json);

            }
        }
    }
}
