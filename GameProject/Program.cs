using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class MainClass
    {
        static void Main(string[] args)                      //yeni e devlet sistemine geçince UserValidationManager ı silip NewEdevletSistemi yazıyorsun bu sayede yeni sisteme geçmiş oluyorsun.
        {                                                    //new NewEdevletSistemi 
            GamerManager gamerManager = new GamerManager(new UserValidationManager());  //diyor ki ben çalışabilmek için başka bir servise ihtiyaç duyuyorum diyor. o yüzden doğrulama sınıfının kim olduğunu söyler misin diyor.
            gamerManager.Add(new Gamer
            { 
                Id = 1,
                BirthYear = 1985,
                FirstName = "Engin",
                LastName = "Demiroğ",
                IdentityNumber = 12345 
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 2, CampaignName = "karne hediyesi", DiscountRate = 25 });


            GameManager gameManager = new GameManager();
            gameManager.Sale(new Game { Id = 1, GameName = "Yesil Oda", GamePrice = 100 },new Campaign{Id=3,CampaignName="yarı yıl hediyesi",DiscountRate=15 });
        }

    }
}


