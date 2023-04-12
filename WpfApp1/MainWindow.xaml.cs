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
    public partial class MainWindow : Window
    {
        public static string savefile = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/" + "calendarsave.json";
        public static string projectDirectory = Directory.GetCurrentDirectory();
        public static DateTime DateTimeNow = DateTime.Now;
        public static List<Classes.DataButton> ListDataButtons = new List<Classes.DataButton>();
        public static List<Classes.DataButtonsType> ListDataButtonsType = new List<Classes.DataButtonsType>()
        {
            new Classes.DataButtonsType(0, "Бургер", System.IO.Path.Combine(projectDirectory, "images/free-icon-burger-4672172.png")),
            new Classes.DataButtonsType(1, "Куриный баскет", System.IO.Path.Combine(projectDirectory, "images/free-icon-chicken-bucket-4672179.png")),
            new Classes.DataButtonsType(2, "Кофе", System.IO.Path.Combine(projectDirectory, "images/free-icon-coffee-cup-4672190.png")),
            new Classes.DataButtonsType(3, "Прохладительный напиток", System.IO.Path.Combine(projectDirectory, "images/free-icon-cold-drink-4672210.png")),
            new Classes.DataButtonsType(4, "Картошку фри", System.IO.Path.Combine(projectDirectory, "images/free-icon-french-fries-4672228.png")),
            new Classes.DataButtonsType(5, "Яичницу", System.IO.Path.Combine(projectDirectory, "images/free-icon-fried-egg-4672220.png")),
            new Classes.DataButtonsType(6, "Шаурму", System.IO.Path.Combine(projectDirectory, "images/free-icon-kebab-4672238.png")),
            new Classes.DataButtonsType(7, "Начос", System.IO.Path.Combine(projectDirectory, "images/free-icon-nachos-4672242.png")),
            new Classes.DataButtonsType(8, "Суши", System.IO.Path.Combine(projectDirectory, "images/free-icon-nigiri-4672245.png")),
            new Classes.DataButtonsType(9, "Лапшу", System.IO.Path.Combine(projectDirectory, "images/free-icon-noodles-4672250.png")),
            new Classes.DataButtonsType(10, "Блины", System.IO.Path.Combine(projectDirectory, "images/free-icon-pancake-4672256.png")),
            new Classes.DataButtonsType(11, "Пиццу", System.IO.Path.Combine(projectDirectory, "images/free-icon-pizza-4672261.png")),
            new Classes.DataButtonsType(12, "Попкорн", System.IO.Path.Combine(projectDirectory, "images/free-icon-popcorn-4672264.png")),
            new Classes.DataButtonsType(13, "Мороженое", System.IO.Path.Combine(projectDirectory, "images/free-icon-popsicle-4672270.png")),
            new Classes.DataButtonsType(14, "Бутерброд", System.IO.Path.Combine(projectDirectory, "images/free-icon-sandwich-4672278.png")),
            new Classes.DataButtonsType(15, "Тако", System.IO.Path.Combine(projectDirectory, "images/free-icon-taco-4672296.png"))
        };

        public MainWindow()
        {
            InitializeComponent();
            Page1 page = new Page1(this);
            FramePage.Content = page;
        }
    }
}
