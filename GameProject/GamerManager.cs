using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{//biz bunları e devlet sistemlerinde doğrulama yapmak için  MicroService yazacağız yani ben GamerManagerın içerisinde
 //başka bir service kullanacağım. IUserValidationService
 //Ben GamerManager'ın içerisine IUserValidationService 'i kullanmak istiyorum.
 //ÖNEMLİ NOT: Eğer bir Manager sınıfının içinde başka bir manager sınıfını kullanacaksan asla onu newleme!!
 //onun yerine aşağıdaki kodu yap

    

    internal class GamerManager : IGamerService
    {
       IUserValidationService _userValidationService;    //diye bir tane constracturs oluştur!!! ampulden generate constructor

        public GamerManager(IUserValidationService userValidationService)// bu GamerManagerın aslında bir bağımlılığı var demek.
        {                                                                  //GamerManagerin içinde ben bi doğrulama servisini kullanacağım demek.
            _userValidationService = userValidationService;       //bu doğrulama sistemi asla kimlik paylaşım sisteminin kendisi değil onun soyutu??
        }
                                                 //yarın birgün mernis değişir başka sisteme geçeriz vs geçince problem yaşamayalım diye bu sistemi yazıyoruz.
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");

            }
            else
            {
                Console.WriteLine("Doğrulama başarısız kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(" Kayıt güncellendi");
        }
    }
}
