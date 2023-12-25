using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class BospurusRepository
    {
          private static readonly List<Odalar> _Odalar = new();
        static BospurusRepository()
        {
            _Odalar = new List<Odalar>(){

                new Odalar() { Id = 1, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/ac099ab623eaf9c4d8acb50f96445b22.jpg?ci_seal=684ae49634&org_if_sml=1&q=100&w=300&h=400&org_if_sml=1"},
                new Odalar() { Id = 2, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/3cd70e17421cab3d6c781de5c9f3f81c.jpg?ci_seal=086ec542fe&org_if_sml=1&q=100&w=300&h=400&org_if_sml=1"},
                new Odalar() { Id = 4, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/ded1887d471e2a91ef33dd6c32e230e3.jpg?ci_seal=ac27ffb05b&org_if_sml=1&q=100&w=300&h=259&org_if_sml=1"},
                new Odalar() { Id = 3, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/81443a8fd5449b74b0606ee7f25aaaf1.jpg?ci_seal=aa75558d41&org_if_sml=1&q=100&w=300&h=225&org_if_sml=1"},
                new Odalar() { Id = 5, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/47c469a53b99666530a8c60b11ae2702.jpg?ci_seal=354433e8a7&org_if_sml=1&q=100&w=300&h=400&org_if_sml=1"},
                new Odalar() { Id = 6, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/88713c0d70882839baf516ab88375cd8.jpg?ci_seal=39374fdeab&org_if_sml=1&q=100&w=300&h=400&org_if_sml=1"},
                new Odalar() { Id = 7, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/7ff723d8af0d8614728b0796c9fea82d.jpg?ci_seal=ed2ac9fd3d&org_if_sml=1&q=100&w=300&h=400&org_if_sml=1"},
                new Odalar() { Id = 8, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/02a5f2fef89c942cbc3c81c4ea1fc228.jpg?ci_seal=bfed4f6b2e&org_if_sml=1&q=100&w=300&h=200&org_if_sml=1"},
                new Odalar() { Id = 9, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/fa71af3d5d5a6544ae744383024cc06f.jpg?ci_seal=ddf7e45d6e&org_if_sml=1&q=100&w=300&h=225&org_if_sml=1"},
                new Odalar() { Id = 10, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/7d9d61bb621c8bf1e44c443b19007989.jpg?ci_seal=b7c8947b06&org_if_sml=1&q=100&w=300&h=400&org_if_sml=1"},
                new Odalar() { Id = 11, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/d1bce4845b46405be26285a605936f69.jpg?ci_seal=1f921dcff6&org_if_sml=1&q=100&w=300&h=400&org_if_sml=1"},
                
                
                
                
                
                
                

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