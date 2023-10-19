using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        public int Id { get; set; }                       // ıd bir nesneyi diğerinden ayırt edilebilmek için veritabanında kullanılan bir alandır. TC no gibi düşün 
        public int CategoryId { get; set; }               //for in key kodun okunulurluğu için yazılan sıramala demek. okunabilir olsun diye buradaki sıralama ile yazılıyor.
        public string ProductName { get; set; }          //Produt ürün demek
        public double UnitPrice { get; set; }            //unitprice ürünün fiyatı demek.
        public int UnitsInStock  { get; set; }           // unitınstock stok adedi demek.

        //CRUD  = ÜRÜN EKLEMEK SİLMEK GÜNCELLEMEK LİSTELEMEK GİBİ OEPRASYONLARA DENİLİYOR. AÇILIMI İSE CREATE(eklemek)-READ(okumak)-UPLATE(güncellemek)-DELETE)(silmek) DEMEK




    }
}


