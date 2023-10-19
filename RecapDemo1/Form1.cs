namespace RecapDemo1   //recap tekrarlamak demek. geçmiþ konularý tekrar eden dama tahtasý yapacaðýz.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Forma çift týklayýnca Form1in load ý açýlýyor. load yükleme demek buradan yükleyeceðiz.
        //dama tahtasýný kodlayarak yapacaðýz. 8*8 yani 64 tane kutu koyacaðýz. button bir classtýr. 
        private void Form1_Load(object sender, EventArgs e)   
        {
            //Button button = new Button();     
            //button.Width = 50;//width geniþlik demek.
            //button.Height=50;
            //button.Text = "My Button";
            //this.Controls.Add(button); //bu butonu ekrana koy demek.
            //yukarýdaki gibi yazdýðýmýzda  bir tane buton oluþturur ancak bize 64 tane lazým ki dama tahtasý yapabilelim. o yüzden
            //bu kodu ayrý ayrý 64 kere yazmak yerine 64 kere dön diyeceðiz.

            //--------------------------------------------------------------------------------------------------------//

            //for (int i = 1; i <= 64; i++)
            //{
            //    Button button = new Button();
            //    button.Width = 50;
            //    button.Height = 50;
            //    button.Text = "My Button";
            //    this.Controls.Add(button);// bu nutonu ekrana koy demek.
            //    //Böyle döngüde yaptýðýmýzda ekranda 64 tane üst üste buton olmuþ oluyor amaç bu bütün butonlarý yayabilmek.
            //    //ama benim o her butona ayrý ayrý eriþmem lazým. üst üste olmasýný istemiyorum.
            //    //Ben ayný iþlemden farklý nesneler oluþturup onlarý kontrol altýnda tutmak istiyorum.
            //    //Bu yüzden arrayden yararlanmak gerekiyor.
            //}

            //-------------------------------------------------------------------------------------------------------------------//

            Button[,] buttons = new Button[8, 8];  //1. satýrýn sekiz butonu 2. satýrýn 8 butonu 3. satýrýn 8 butonu gibi döngü tasarlayacaðýz.
            //8,8 yapýnca 2 boturlu yapmýþ oluyoruz. getupper... da 0 yazmamýzýn sebebi sýfýr boyuttan baþla toplamda 8 boyut oluþturacak.
            int top=0;    //yükseklik deðeri  //deðiþken tanýmladýk.
            int left=0;   //sol deðeri   //deðiþken tanýmladýk.
            for (int i = 0; i < buttons.GetUpperBound(0); i++)    //get upper bound üst sýnýrý al demek. her bir satýr için bir deðer oluþturduk.
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)//burada 1 yazdýk 2 botulu olduðu için saðdaki 8 i kapsýyor.
                //Mantýk þu i =0 için j=0,  i=0 için j=1,......i=0 için j=7. 8 buton olmuþ olacak. 8 e 8 yani 64 tane buton koyacam ama yine
                //ama yine üst üste koymuþ olacak. 
               
                {
                    buttons[i,j]=new Button(); // ilk buton benim için yeni butondur. 2. butonda yeni butondur. o yüzden sürekli newlemeli.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;

                    buttons[i,j].Left = left;  //button [i,j]nin Left'i (yani formun baþlanðýç deðerine göre soldan Uzaklýðý)=left left te 0. ilk buton
                    buttons[i, j].Top = top;
                    left += 50;    //Benim 2. botunu 50 birim uzak yapmam lazým. bu yüzden 0 dan 50 karakter arttýrýyorum.  yan yana butonlar koymuþ olduk.
                                   // sol kaydýrma iþlemi yapmýþ olduk. Left 0 olduðu için ilk butonu o noktadan koyuyor 2. buton için sola doðru 50 artýyor.
                                   //þimdi yükseklik (top içinde aynýsýný yapýyorum.
                                   //Burada top 0 left 50 50 artýyor.  yukarýdan aþaðý dizmek içinde left 0 olmalý top 50 50 artmalý.
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black; //button i,j nin arka plan rengi siyah 
                    }
                    else
                    {
                        buttons[i,j].BackColor=Color.White;
                    }
            
       

                    this.Controls.Add(buttons[i, j]);       //this den kasýt bu form a karþýlýk geliyor. ama yine üst üste 64 tane oluyor.
                    // ilk butonun baþlangýc deðeri forun en uç noktasý  yani baþlanðýç noktasý (sol en üst)
                    // Ben ilk butonu koyduktan sonra 2. butonu 50 saða kaydýrmam gerekiyor.
                    //ilk 8 buton için top 0 ikinci 8li için top 50

                }
                top += 50;
                left = 0;



            }





        }
    }
}