using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class Urun
    {
        //ürünün ürün olabilmesi için bazı özelliklerinin olması lazım. birden fazla elemanı tutabilir olması lazım. 
        //Propoerty : Özellik demek  

        public int Id { get; set; }     //Id bir datayı diğer datadan ayırt etmek için kullanılan eşsiz değer.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }        // gelir buraya eklersin stokadedini sadece buraya   buna encapsualtion deniliyor. [kapsülleme demek] 
                                                 //kapsulleme sen ayrı ayrı ve düzensiz olacak bir yapıyı bir yapının içine sokuyorsun demek. bir kapsule sokuyorsun demek.



    }
}
