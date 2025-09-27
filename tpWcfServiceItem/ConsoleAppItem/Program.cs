using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppItem.NSItem;

namespace ConsoleAppItem
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceItemClient s = new ServiceItemClient();
            Item i = s.GetItemByParameter("Nintendo64", 164);
            Console.WriteLine(i.Marque + " " + i.Prix);
            i = s.UpdateItem(i);
            Console.WriteLine(i.Marque + " " + i.Prix);
            Item[] l = s.SelectAll(); ;
            foreach(Item i1 in l)
                Console.WriteLine(i1.Marque + " " + i1.Prix);
            s.Insert("Polo", 20);

        }
    }
}
