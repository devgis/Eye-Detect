using GTCommons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace GazeTrackerUI
{
    /// <summary>
    /// RandomSpotWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RandomSpotWindow : Window, INotifyPropertyChanged
    {
        private double windowwith;//窗口宽
        private double windowheight;//窗口高

        private double left;//控件离窗口左边的大小

        private double top;//控件离窗口上面的大小

        private string textpoint;//控件坐标

        int pauseindex=0;

        private Thread thread;//线程防止窗口卡死

        public RandomSpotWindow()
        {
            Windowwith = 800;
            Windowheight = 500;  //初始化窗口长宽
            InitializeComponent();
            this.DataContext = this;   //DataContext设置为本身

        }



        public double Left1
        {
            get => left; set
            {
                left = value;
                NotifyPropertyChanged("Left1");
            }
        }
        public double Top1
        {
            get => top; set
            {
                top = value;
                NotifyPropertyChanged("Top1");
            }
        }

        public string Textpoint
        {
            get => textpoint;
            set
            {
                textpoint = value;
                NotifyPropertyChanged("Textpoint");
            }
        }

        public double Windowwith
        {
            get => windowwith; set
            {
                windowwith = value;
                NotifyPropertyChanged("Windowwith");
            }
        }
        public double Windowheight
        {
            get => windowheight; set
            {
                windowheight = value;
                NotifyPropertyChanged("Windowheight");
            }
        }

        public int Pauseindex { get => pauseindex; set => pauseindex = value; }

        public event PropertyChangedEventHandler PropertyChanged;//属性改变时触发
        private void NotifyPropertyChanged(string name)//属性改变时通知方法
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        /// <summary>
        /// 线程中循环
        /// </summary>
        private void setlight()
        {
            thread = new Thread(new ThreadStart(() =>
            {
                while (thread.IsAlive)//线程存在时触发
                {
                    setpoint();   //随机坐标
                    Thread.Sleep(2000);  //线程睡眠2秒钟
                }
            }));
            thread.Start();
        }



        /// <summary>
        /// 随机设置坐标
        /// </summary>
        private void setpoint()
        {
            Random random = new Random();
            if (Windowwith > Windowheight)
            {
                random = new Random(random.Next((int)Windowheight)-10);
            }  //加强随机性
            else
            {
                random = new Random(random.Next((int)Windowwith)-10);
            }

            Left1 = random.NextDouble() * (Windowwith - 10);  //产生随机坐标x
            Top1 = random.NextDouble() * (Windowheight - 10);  //产生随机坐标y

            StaticData.WhitePointPosition = new GTCommons.MyPosition(Left1, Top1); //update the postion  liyafei add
            Textpoint = Textpoint + "{" + Math.Round(Left1, 2).ToString() + "," + (Windowheight - Math.Round(Top1, 2)).ToString() + "}";//文本表示坐标
        }
        /// <summary>
        /// 窗口关闭时停止线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            thread.Abort();
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content.ToString() == "start")
            {
                StaticData.IsWhitePointEnabled = true; //liyafei add
                ellipse.Visibility = Visibility.Visible;
                setlight();        //调用发亮函数
            }
            else
            {
                StaticData.IsWhitePointEnabled = false; //liyafei add
                if (thread == null) return;
                ellipse.Visibility = Visibility.Hidden;
                Pauseindex++;    //暂停时Pauseindex+1
                SaveTXT(Textpoint);
                Textpoint = "";
                thread.Abort();//终止线程
            }
        }
        /// <summary>
        /// 保持记录
        /// </summary>
        /// <param name="str"></param>
        private void SaveTXT(string str)
        {
            try
            {
                StreamWriter fs = System.IO.File.AppendText(@"C:\Users\86155\Desktop\LightLog.txt");
                //开始写入
                fs.WriteLine(string.Format("{0:d}", System.DateTime.Now) + "第" + Pauseindex.ToString() + "次生成的坐标：" + Textpoint);
                fs.Close();
            }
            catch { }
        }


    }
}