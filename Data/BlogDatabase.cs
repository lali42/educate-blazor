using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class BlogDatabase
    {
        public static BlogDatabase Default { get; } = new();
        public List<BlogEntry> BlogEntries { get; } = new()
        {
            new()
            {
                ID = 0,
                Name = "MOUSE BUNGEE",
                Img1 = "images/mouse-bungee.png",
                Img2 = "images/mouse-bungee2.png",
                Descrip = "RAZER MOUSE BUNGEE V3 CHROMA",
                Price = 1390,
            },
            new()
            {
                ID = 1,
                Name = "MICROPHONE",
                Img1 = "images/microphoe.png",
                Img2 = "images/microphoe2.png",
                Descrip = "SIGNO MP-701 CONDENSER MICROPHONE (BLACK)",
                Price = 760,
            },
            new()
            {
                ID = 2,
                Name = "GAMING CHAIR",
                Img1 = "images/chair.png",
                Img2 = "images/chair2.png",
                Descrip = "VERTAGEAR GAMING SL 1000 BLACK-RED",
                Price = 9900,
            },
            new()
            {
                ID = 3,
                Name = "GAMING DESK",
                Img1 = "images/desk.png",
                Img2 = "images/desk01.png",
                Descrip = "COUGAR MARS 120 RGB (CGR-MARS-120)",
                Price = 7990,
            },
            new()
            {
                ID = 4,
                Name = "FLOOR MAT",
                Img1 = "images/floor-mat.png",
                Img2 = "images/floot-mat01.png",
                Descrip = "COUGAR COMMAND (GRAY-BLACK)",
                Price = 1490,
            },
            new()
            {
                ID = 5,
                Name = "T-SHIRT",
                Img1 = "images/t-shirt02.png",
                Img2 = "images/t-shirt03.png",
                Descrip = "ASUS ROG T-SHIRT ZAKU EDITION (SIZE M)",
                Price = 1190,
            },
        };
    }
}