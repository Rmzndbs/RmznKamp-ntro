namespace OOP3
{//Veri tabanına loglama yapacak servis //classın üzerine tıkladığında çıkan fırçadan move Types... seçince yeni bir dosyaya aktarıyor.
    internal class FilebaseLoggerService : ILoggerService       //File: dosya yani metin dosyasınayazmak istiyruz. 2 alternatif veri T. ve dosya
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}




