using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Classes
    {
        public class DataButton
        {
            public DateTime Date { get; set; }
            public List<int> Ids { get; set; }
            public DataButton(DateTime date, List<int> ids)
            {
                Date = date;
                Ids = ids;
            }
        }

        public class DataButtonsType
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public DataButtonsType(int id, string name, string image)
            {
                Id = id;
                Name = name;
                Image = image;
            }
        }

        public class CheckboxItem
        {
            public string Name { get; set; }
            public string ImagePath { get; set; }
            public bool IsSelected { get; set; }
        }
    }
}
