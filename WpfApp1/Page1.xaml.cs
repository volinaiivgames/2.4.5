using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public MainWindow mainwindow;
        public Page1(MainWindow window)
        {
            InitializeComponent();
            mainwindow = window;
            Load_Buttons();
        }

        private void Load_Buttons()
        {
            if (File.Exists(MainWindow.savefile))
            {
                MainWindow.ListDataButtons = JsonConvert.DeserializeObject<List<Classes.DataButton>>(File.ReadAllText(MainWindow.savefile));
            }

            textBlock.Text = MainWindow.DateTimeNow.ToString("MMMM yyyy");
            for (int i = 0; i < DateTime.DaysInMonth(MainWindow.DateTimeNow.Year, MainWindow.DateTimeNow.Month); i++)
            {
                UserControl1 control = new UserControl1();
                DateTime datesukavotsuda = new DateTime(MainWindow.DateTimeNow.Year, MainWindow.DateTimeNow.Month, i + 1);
                Classes.DataButton item = MainWindow.ListDataButtons.FirstOrDefault(iteminlist => iteminlist.Date == datesukavotsuda);
                control.textBlock1.Text = (i + 1).ToString();
                if (item != null && item.Ids.Count > 0) control.image.Source = new BitmapImage(new Uri(MainWindow.ListDataButtonsType[item.Ids[0]].Image));
                else control.image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(MainWindow.projectDirectory, "images/free-icon-calendar-7865510.png")));
                control.button.Tag = (i + 1).ToString();
                control.button.Click += data_Click;

                wrapPanel.Children.Add(control);
            }
        }

        public void data_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Page2 page = new Page2(mainwindow, new DateTime(MainWindow.DateTimeNow.Year, MainWindow.DateTimeNow.Month, Convert.ToInt32(btn.Tag)));
            mainwindow.FramePage.Content = page;
        }

        private void left_Click(object sender, RoutedEventArgs e)
        {
            wrapPanel.Children.Clear();
            MainWindow.DateTimeNow = MainWindow.DateTimeNow.AddMonths(-1);
            Load_Buttons();
        }

        private void right_Click(object sender, RoutedEventArgs e)
        {
            wrapPanel.Children.Clear();
            MainWindow.DateTimeNow = MainWindow.DateTimeNow.AddMonths(1);
            Load_Buttons();
        }
    }
}
