using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class EşyaRepository
    {
        private static readonly List<Eşyalar> _Eşyalar = new();
        static EşyaRepository()
        {
            _Eşyalar = new List<Eşyalar>(){
                new Eşyalar(){Id=1,Ad="nordik-armchair",Image=" https://lazzoni.com/cdn/shop/files/nordik-armchair-2_413x.jpg?v=1690265708"},
                new Eşyalar(){Id=2,Ad="mira-coffetable",Image=" https://lazzoni.com/cdn/shop/products/mira-coffetable-4_413x.jpg?v=1634044329"},
                new Eşyalar(){Id=3,Ad="mira-coffetable",Image=" https://lazzoni.com/cdn/shop/products/mira-coffetable-4_413x.jpg?v=1634044329"},
                new Eşyalar(){Id=4,Ad="split hinged wardrobe",Image=" https://lazzoni.com/cdn/shop/products/split-hinged-wardrobe-1-1_413x.jpg?v=1683644522"},
                new Eşyalar(){Id=5,Ad="double bed",Image=" https://lazzoni.com/cdn/shop/products/double-bed-25-yat008-160x200-cm-upholstered-01_72ac21b0-d6c5-418c-b973-dbf6222d6734_413x.jpg?v=1637819052"},
                new Eşyalar(){Id=6,Ad="ocean-nightstand",Image=" https://lazzoni.com/cdn/shop/products/ocean-nightstand-4_413x.jpg?v=1634107953"},
                new Eşyalar(){Id=7,Ad="manhattan-concept",Image=" https://lazzoni.com/cdn/shop/files/manhattan-concept3-2_413x.jpg?v=1699011961"},
                new Eşyalar(){Id=8,Ad="lorton-armchair",Image=" https://lazzoni.com/cdn/shop/files/lorton-armchair-2_413x.jpg?v=1692787434"},
                new Eşyalar(){Id=9,Ad="rocco-coffetable",Image=" https://lazzoni.com/cdn/shop/products/rocco-coffetable-16_413x.jpg?v=1662920524"},
                new Eşyalar(){Id=10,Ad="Milda",Image=" https://lazzoni.com/cdn/shop/products/Milda_MLDL14-MLDL18-MLDL23-MLDL37-KSH106_Z72--_3_413x.jpg?v=1675058354"},
                new Eşyalar(){Id=11,Ad="Lego Book case",Image=" https://lazzoni.com/cdn/shop/products/lego-bookcases-25-10_413x.jpg?v=1634028187"},
                new Eşyalar(){Id=12,Ad="Modern chester",Image=" https://lazzoni.com/cdn/shop/products/modern-chester-sofa-1_2_413x.jpg?v=1680594725"},
                new Eşyalar(){Id=13,Ad="modern chester ottoman",Image=" https://lazzoni.com/cdn/shop/products/modern-chester-ottoman-2_413x.jpg?v=1680597963"},
                new Eşyalar(){Id=14,Ad="pietra",Image=" https://lazzoni.com/cdn/shop/products/pietra-2_42dfb3ea-3282-4f9b-a38a-df0e0f7cbafc_413x.jpg?v=1640341593"},
                new Eşyalar(){Id=15,Ad="ena chair",Image=" https://lazzoni.com/cdn/shop/files/ena-chair-2_1_413x.jpg?v=1692880978"},
                new Eşyalar(){Id=16,Ad="mons table",Image=" https://lazzoni.com/cdn/shop/products/mons-table-12_413x.jpg?v=1634050209"},
                new Eşyalar(){Id=17,Ad="fly table",Image=" https://lazzoni.com/cdn/shop/products/fly-table-1_413x.jpg?v=1634042430"},
                new Eşyalar(){Id=18,Ad="neva sideboard",Image=" https://lazzoni.com/cdn/shop/products/neva-sideboard-1_413x.jpg?v=1637825060"},
                new Eşyalar(){Id=19,Ad="slim chair",Image=" https://lazzoni.com/cdn/shop/products/slim-chair-3_413x.jpg?v=1634116681"},
                new Eşyalar(){Id=20,Ad="ocean nigthstand",Image=" https://lazzoni.com/cdn/shop/products/ocean-nightstand-4_413x.jpg?v=1634107953"},
                new Eşyalar(){Id=21,Ad="istanbul bed",Image=" https://lazzoni.com/cdn/shop/products/istanbul-bed-m78-4_6cc936dc-2d59-4047-849e-5c85078d0795_413x.jpg?v=1641214009"},
                new Eşyalar(){Id=22,Ad="ena",Image=" https://lazzoni.com/cdn/shop/products/ena--p44-2_413x.jpg?v=1637819451"},
                new Eşyalar(){Id=23,Ad="Neba",Image=" https://lazzoni.com/cdn/shop/products/t63-p74--m56-4_413x.jpg?v=1633588820"},
                new Eşyalar(){Id=24,Ad="amorf coffe table",Image=" https://cdn.shopify.com/s/files/1/0568/6362/1297/files/amorf-coffee-table-1622811077718_1600x_68f6304e-7273-4ffa-8eeb-fce86f422fa1_480x480.jpg?v=1632147438"},
                new Eşyalar(){Id=25,Ad="ington bed",Image=" https://lazzoni.com/cdn/shop/files/ington-bed-8_413x.jpg?v=1695308354"},
                new Eşyalar(){Id=26,Ad="hudson nightstand",Image=" https://lazzoni.com/cdn/shop/products/hudson-nightstand-8_413x.jpg?v=1678889862"},
                new Eşyalar(){Id=27,Ad="amorf mirror",Image=" https://lazzoni.com/cdn/shop/products/amorf-mirror-4_fa7c049c-9341-4823-9fe2-4e73d4b43b0e_413x.jpg?v=1643003788"},
                new Eşyalar(){Id=28,Ad="mons table",Image=" https://lazzoni.com/cdn/shop/products/mons-table-marquina-2_413x.jpg?v=1663840774"},
                new Eşyalar(){Id=29,Ad="mons table",Image=" https://lazzoni.com/cdn/shop/products/mons-table-12_413x.jpg?v=1634050209"},
                new Eşyalar(){Id=30,Ad="tolina chair",Image=" https://lazzoni.com/cdn/shop/products/tolina-chair-4_413x.jpg?v=1634131802"},
                new Eşyalar(){Id=31,Ad="hexa ayna",Image=" https://lazzoni.com/cdn/shop/files/hexa-ayna-2_413x.jpg?v=1691486876"},
                new Eşyalar(){Id=32,Ad="AmberConsole",Image=" https://lazzoni.com/cdn/shop/products/AmberConsole_1_413x.jpg?v=1650865575"},
                new Eşyalar(){Id=33,Ad="hexa bed",Image=" https://lazzoni.com/cdn/shop/products/hexa-bed-m78-m72-1_8c1bdddc-9d55-4f5d-8845-bdfb0e4b95cc_413x.jpg?v=1637819950"},
                new Eşyalar(){Id=34,Ad="livio nigthstand",Image=" https://lazzoni.com/cdn/shop/products/livio-nightstand-2_e409aaba-5c51-4aa1-a7b9-b5dc72aaf04f_413x.jpg?v=1653457234"},
                new Eşyalar(){Id=35,Ad="mix corner",Image=" https://lazzoni.com/cdn/shop/products/mix-corner-table-sofa-26_413x.jpg?v=1675058267"},
                new Eşyalar(){Id=36,Ad="eva armchair",Image=" https://lazzoni.com/cdn/shop/products/eva-armchair-p56-1_413x.jpg?v=1637819310"},
                new Eşyalar(){Id=37,Ad="mira coffetable",Image=" https://lazzoni.com/cdn/shop/products/mira-coffetable-4_413x.jpg?v=1634044329"},
                new Eşyalar(){Id=38,Ad="gema bed",Image=" https://lazzoni.com/cdn/shop/products/gema-bed-2_413x.jpg?v=1663747900"},
                new Eşyalar(){Id=39,Ad="pia pouf",Image=" https://lazzoni.com/cdn/shop/products/pia-pouf-3_413x.jpg?v=1634112307"},
                new Eşyalar(){Id=40,Ad="flatiron",Image=" https://lazzoni.com/cdn/shop/files/flatiron-2_413x.jpg?v=1682695501"},
                new Eşyalar(){Id=41,Ad="gema bed",Image=" https://lazzoni.com/cdn/shop/products/gema-bed-2_413x.jpg?v=1663747900"},
                new Eşyalar(){Id=42,Ad="berlin corner",Image=" https://lazzoni.com/cdn/shop/products/berlin-corner-2_413x.jpg?v=1674475416"},
                new Eşyalar(){Id=43,Ad="fibonacci coffe table",Image=" https://lazzoni.com/cdn/shop/files/fibonacci-coffee-table-1_28e3aad3-6390-431a-906e-1b6fa9a3f1a8_413x.jpg?v=1702470206"},
                new Eşyalar(){Id=44,Ad="fibonacci puf",Image=" https://lazzoni.com/cdn/shop/products/fibonacci-puf-2_413x.jpg?v=1676466054"},
                new Eşyalar(){Id=45,Ad="panaa",Image=" https://lazzoni.com/cdn/shop/products/panna-p75-1_413x.jpg?v=1676530042"},
                new Eşyalar(){Id=46,Ad="rocco coffe table",Image=" https://lazzoni.com/cdn/shop/products/rocco-coffetable-16_413x.jpg?v=1662920524"},
                new Eşyalar(){Id=47,Ad="pietra table",Image=" https://lazzoni.com/cdn/shop/products/pietra-table-6_8a3b5104-29b2-485d-91cc-596dc3221669_413x.jpg?v=1634114863"},
                };
        }
        public static List<Eşyalar> Eşyalars
        {
            get
            {
                return _Eşyalar;
            }
        }
        public void PopulateDatabase(DatabaseContext dbContext)
        {
            foreach (var item in _Eşyalar)
            {
              
                var itemEntity = new Eşyalar
                {
                    Id = item.Id,
                    Image = item.Image,
                    Price = item.Price
                };

                
                dbContext.Eşyalars.Add(itemEntity);
            }
      
           
        }
        public static Eşyalar? GetById(int? id)
        {

            return _Eşyalar.FirstOrDefault(m => m.Id == id);
        }

    }
}