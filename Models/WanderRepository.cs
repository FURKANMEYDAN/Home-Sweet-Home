using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class WanderRepository
    {
          private static readonly List<Odalar> _Odalar = new();
        static WanderRepository()
        {
            _Odalar = new List<Odalar>(){

                new Odalar() { Id = 1, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/ae89f38f3c498b5eafbce3304b8d2ea0.jpeg?ci_seal=82d3126ddb&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 2, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/0cba2e1e68060d9b1554e7bd421638d5.jpeg?ci_seal=e43b065abb&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 4, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/e34509551dc6471058fec310419053d6.jpeg?ci_seal=96fea04c11&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 3, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/9b1fc7c5d148a04ae982804c7c069afb.jpeg?ci_seal=a7bddcb908&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 5, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/59e755139a98373f5ea6c1cfe4e50b1a.jpeg?ci_seal=875faa007c&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 6, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/7365e3c3f0d1734ab4a4068b4338cdec.jpeg?ci_seal=c476adf31f&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 7, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/784283f7af638a30504a2a6d4ae93c4a.jpeg?ci_seal=b0611628c7&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 8, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/0c169bd5e79f2bf1ef1780f297402d7f.jpeg?ci_seal=479be7b153&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 9, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/8678df6031b54c1c6713744834d6c430.jpeg?ci_seal=83927b5c43&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 10, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/c7fcbf0b7160fdb06020c3dd8c9085fd.jpeg?ci_seal=c714f6cbf2&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 11, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/9f5ff4df8fcd484d1435443f4517cd12.jpeg?ci_seal=5cc60862dc&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 12, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/70ded0a6ca3c1452446574c8e270696b.jpeg?ci_seal=867a174307&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 13, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/fb9fb8844958e2e6cf636b07dac2a73c.jpeg?ci_seal=0d1f183b0d&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 14, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/15823cada377a3ac6692744f1f09fc58.jpeg?ci_seal=1320933635&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 15, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/9e649984e601be76f94436fd22863b4c.jpeg?ci_seal=fb040cc47c&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 16, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/feef0ebb7888b71a9d84629d62d605f6.jpeg?ci_seal=a148a733c0&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 17, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/718844c8e66ee42719f7610be8d589d9.jpeg?ci_seal=f1c14e8876&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 19, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/1a44378ba61203c13e2c0cb88ba0f69a.jpeg?ci_seal=03fdfa81dc&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 20, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/962d809e65846c0555b3f7bc1c4ce2d3.jpeg?ci_seal=93089deb27&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 21, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/37a66a7fa196808d35482b7293290f9e.jpeg?ci_seal=d8c0c9be51&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 22, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/477b2a7745f62e3c618fa1a77690a7df.jpeg?ci_seal=17aba4b708&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 23, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/1a0581e1c814d219d3f17bf5b1925c3b.jpeg?ci_seal=e6656feff2&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 24, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/b1ba370195b321eb084b28051c99c55a.jpeg?ci_seal=3d5f02bdd1&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 25, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/c00e6af7e75f865752799bf60e25b149.jpeg?ci_seal=95a17f3be4&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                new Odalar() { Id = 26, Image = "https://images.robinpro.gallery/v7/_robin-pro_/uploads/5cb69b95d433193627248cad5c90c439.jpeg?ci_seal=72fa5315a0&org_if_sml=1&q=85&w=300&h=300&org_if_sml=1"},
                

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