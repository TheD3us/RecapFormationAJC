using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;



namespace TpSerialization
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void SerializeXml()
        {
            Article a1 = new Article("voiture", 1000);
            FileStream inStream = new FileStream(@"c:\tmp\Article.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter

        }
    }

}
