using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{

    public class Calculator
    {
        public static void Main()
        {
        }

        public List<int> CollectSummation(List<Item> itemList, string propertyName, int stride)
        {
            var collection = new List<int> {};
            var sum = 0;
            var query = itemList.Select(item => item.GetPropertyByName(propertyName)).ToList();

            for (int i = 0; i < query.Count; i++)
            {
                if (i != 0 && (i % stride == 0))
                {
                    collection.Add(sum);
                    sum = query[i];
                }
                else
                {
                    sum += query[i];
                }
            }

            collection.Add(sum);

            return collection;
        }
    }

    public class Item
    {
        public int Id { get; set; }

        public int Cost { get; set; }

        public int Revenue { get; set; }

        public int SellPrice { get; set; }

        public int GetPropertyByName(string name)
        {
            return (int)this.GetType().GetProperty(name).GetValue(this, null);
        }
    }

}
