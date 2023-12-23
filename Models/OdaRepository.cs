using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _2.Models
{
    public class OdaRepository
    {
        private static readonly List<Odalar> _Odalar = new();

        static OdaRepository()
        {
            _Odalar = new List<Odalar>(){

                new Odalar() { Id = 1, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83584.jpg?v=1699946237",Styles="top: 515.997px; left: 490.269px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 2, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83543.jpg?v=1698991997",Styles="top: 425.169px; left: 476.064px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 4, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83542.jpg?v=1698991768",Styles="top: 363.312px; left: 464.654px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 3, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83307.jpg?v=1697179313",Styles="top: 458.055px; left: 499.106px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 5, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83133.jpg?v=1695986715",Styles="top: 411.858px; left: 335.907px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 6, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83134.jpg?v=1695986925",Styles="top: 523.827px; left: 512.082px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 7, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83225.jpg?v=1696587002",Styles="top: 534.789px; left: 268.121px;background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 8, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83041.jpg?v=1695291485",Styles="top: 642.843px; left: 470.583px;background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 9, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83131.jpg?v=1695985919",Styles="top: 491.724px; left: 674.274px;background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 10, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83130.jpg?v=1695985503",Styles="top: 598.212px; left: 621.702px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 11, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-82491.jpg?v=1689751979",Styles="top: 471.366px; left: 313.983px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 12, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-83132.jpg?v=1695986497",Styles="top: 382.887px; left: 560.628px;background: transparent;position: absolute;width: 26px;height: 26px; "},
                new Odalar() { Id = 13, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-82492.jpg?v=1689753651",Styles="top: 405.594px; left: 358.949px;background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 14, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-82490.jpg?v=1689751582",Styles="top: 472.149px; left: 309.62px;background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 15, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-82493.jpg?v=1689753738",Styles="top: 391.5px; left: 391.5px; background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 16, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-82494.jpg?v=1689758494",Styles="top: 410.292px; left: 484.677px; background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 17, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-82496.jpg?v=1689759154",Styles="top: 393.849px; left: 431.433px; background: transparent;position: absolute;width: 26px;height: 26px;"},
                new Odalar() { Id = 18, Image = "https://cdn.shopify.com/s/files/1/0568/6362/1297/t/33/assets/lookbook-modmedia-7649-page-82498.jpg?v=1689761129",Styles="top: 391.5px; left: 391.5px;background: transparent;position: absolute;width: 26px;height: 26px;"},
        
            };
        
        
        }
      

        public static List<Odalar> Odalars
        {
            get
            {
                return _Odalar;
            }
        }
        public static Odalar? GetById(int? id)
        {
            return _Odalar.FirstOrDefault(m => m.Id == id);
        }
        
      
    }
    

}


