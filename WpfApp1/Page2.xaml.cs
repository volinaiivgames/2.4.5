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
    public partial class Page2 : Page
    {
        public MainWindow mainwindow;
        public DateTime Date;
        public Page2(MainWindow window, DateTime date)
        {
            InitializeComponent();
            Date = date;
            textBlock.Text = date.ToString("dd MMMM yyyy");
            foreach (var item in MainWindow.ListDataButtonsType)
            {
                bool active = false;
                Classes.DataButton ListDataButtons = MainWindow.ListDataButtons.FirstOrDefault(iteminlist => iteminlist.Date == Date);
                if (ListDataButtons != null) if (ListDataButtons.Ids.FindIndex(iteminlist => iteminlist == item.Id) != -1) active = true;

                listBox.Items.Add(new Classes.CheckboxItem { Name = item.Name, ImagePath = item.Image, IsSelected = active });
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            List<int> Ids = new List<int>();
            Classes.DataButton ListDataButtons = MainWindow.ListDataButtons.FirstOrDefault(iteminlist => iteminlist.Date == Date);

            for (int i = 0; i < listBox.Items.Count; i++) if ((listBox.Items[i] as Classes.CheckboxItem).IsSelected) Ids.Add(i);

            if (ListDataButtons != null) ListDataButtons.Ids = Ids;
            else MainWindow.ListDataButtons.Add(new Classes.DataButton(Date, Ids));

            using (StreamWriter sw = new StreamWriter(MainWindow.savefile))
            {
                sw.Write(JsonConvert.SerializeObject(MainWindow.ListDataButtons));
            }
        }
    }
}
