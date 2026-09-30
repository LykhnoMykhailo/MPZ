using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_1609
{
    public class DBItem<T> where T : IEntity
    {
        public int counter = 1;
        public List<T> Items = new List<T>();

        public void AddItem(T item)
        {
            item.Id = counter++;
            Items.Add(item);
        }
    }
}
