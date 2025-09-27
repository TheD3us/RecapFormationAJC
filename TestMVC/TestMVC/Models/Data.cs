using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class Data
    {
        private string str;

        public Data(string str)
        {
            this.str = str;
        }

        public string Str
        {
            get { return this.str; }
            set { this.str = value; }
        }


    }
}