namespace _2.Models
{
    public class Repository
    {
        private static readonly List<AnaSayfa> _AnaSayfa = new();
        static Repository(){
                _AnaSayfa = new List<AnaSayfa>(){
                new AnaSayfa(){Id=1,Ad="Ramona Drive Mansion, California",Title="Ramona Drive Mansion, California",Image="//lazzoni.com/cdn/shop/articles/11_720x.jpg?v=1698675257",Tags=new string[] {"oturma odasi","mobilya","koltuk"}},
                new AnaSayfa(){Id=2,Ad="Wander Yosemite Falls, California",Title="Wander Yosemite Falls, California",Image="//lazzoni.com/cdn/shop/articles/fullres_720x.jpg?v=1696416542",Tags=new string[] {"mutfak","masa","sandalye"}},
                new AnaSayfa(){Id=3,Ad="Bosphorus Apartment, Istanbul",Title="Bosphorus Apartment, Istanbul",Image="//lazzoni.com/cdn/shop/articles/New_Project_-_2023-04-28T124436.124_2_165495bb-90e6-4767-94cb-fba97f889b7b_720x.jpg?v=1683546808",Tags=new string[] {"banyo","duşakabin","ayna"}},
            };  
        }
        public static List<AnaSayfa> AnaSayfas{
            get{
                return _AnaSayfa;
            }
        }
        public static AnaSayfa? GetById(int? id){
            return _AnaSayfa.FirstOrDefault(m=>m.Id==id);
        }
              
    }
}