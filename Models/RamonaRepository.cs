using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class RamonaRepository
    {
        private static readonly List<Odalar> _Odalar = new();
        static RamonaRepository()
        {
            _Odalar = new List<Odalar>(){

                new Odalar() { Id = 1, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/552712f722049260d6fdee3cc7306227.jpg?ci_seal=8f1994c4ce&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 2, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/78b1576f4e0daaba735a0bf7c828c07e.jpg?ci_seal=aa7934b3a5&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 4, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/8c0c26412a664b24efa2a2d1b88ef56c.jpg?ci_seal=a8f848c13d&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 3, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/c4e905bab3292e26abf66686e7426586.jpg?ci_seal=a86498e482&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 5, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/e9b8baf7ab3b0cfcf2431703044d8988.jpg?ci_seal=7222925306&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 6, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/9f8731f1cee268b97d3ad913e2017468.jpg?ci_seal=14358ff9d7&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 7, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/b92240579191a50c1ce4b3cfb4ac40dc.jpg?ci_seal=fdc83170d5&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 8, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/5715e577198fb3751ac903d62d0d3118.jpg?ci_seal=43731153e1&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 9, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/ce6fa99ac259ca69834ea308540bf3e6.jpg?ci_seal=95423446e2&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 10, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/3078e006e2672732cd8ae4c2f7355b7b.jpg?ci_seal=ef39dcf5d2&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 11, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/73482e5e1ce856e03f76f60d68177bb5.jpg?ci_seal=319ce79117&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 12, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/68937f0c75efa6a07da0eaeba8452d28.jpg?ci_seal=994430dd57&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 13, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/827d347accd44d0a0b04daf0dd0a2d63.jpg?ci_seal=d794c12074&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 14, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/69a4409b6d96d9be0d8c7fc1e7acf23c.jpg?ci_seal=7aa51881d5&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 15, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/01b100a6830808f5a3fc15990f2ae1f0.jpg?ci_seal=1757781619&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 16, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/b5aba6733065b2ee6d6c368c2ca35686.jpg?ci_seal=78c4ee9d23&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 17, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/843253f2764d4fa236bde015c670cf33.jpg?ci_seal=39d5934edc&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 18, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/77544285705a73546c25f2b0592fc8a3.jpg?ci_seal=3b808983e6&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},

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