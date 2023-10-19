using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{//içerisinde operasyon içerenlere Service ismini ver
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);   //validate doğrula demek.
    }
}
