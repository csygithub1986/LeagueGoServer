using ClientTest.WcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ClientTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Login");
            Task.Factory.StartNew(() =>
            {
                ServiceProxy.Instance.ClientOpen();
                ServiceProxy.Instance.Login("csy");
            });
            //Thread thread = new Thread(new ThreadStart(ServiceProxy.Instance.ClientOpen));
            //thread.IsBackground = true;
            //thread.Start();
            //(sender as Control).IsEnabled = false;
        }

        private void CreateNewGame_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("CreateNewGame");
            Player p1 = new Player() { Color = 2, ID = 1, Name = "Host", Type = PlayerType.Host };
            Player p2 = new Player() { Color = 1, ID = 2, Name = "Int", Type = PlayerType.Internet };
            GameSetting setting = new GameSetting() { BoardSize = 19, Name = "FirstGame" };
            ServiceProxy.Instance.CreateGame(new Player[] { p1, p2 }, setting);
        }

        private void ApplyGame_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ApplyGame");
            ServiceProxy.Instance.ApplyToJoinGame(Common.GameList[0].GameID, Common.GameList[0].Players.FirstOrDefault(p => p.Client == null).ID);
        }

        private void Move_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Move");
            ServiceProxy.Instance.ClientCommitMove(Common.StepNum, 1, 1);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Start");
            ServiceProxy.Instance.GameStart();
        }
    }
}
