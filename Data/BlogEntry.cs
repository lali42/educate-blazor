using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class BlogEntry
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public int Price { get; set; }
        public string Img1 { get; set; }
        public string Img2 { get; set; }


    }
}