namespace RecapDemo1   //recap tekrarlamak demek. ge�mi� konular� tekrar eden dama tahtas� yapaca��z.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Forma �ift t�klay�nca Form1in load � a��l�yor. load y�kleme demek buradan y�kleyece�iz.
        //dama tahtas�n� kodlayarak yapaca��z. 8*8 yani 64 tane kutu koyaca��z. button bir classt�r. 
        private void Form1_Load(object sender, EventArgs e)   
        {
            //Button button = new Button();     
            //button.Width = 50;//width geni�lik demek.
            //button.Height=50;
            //button.Text = "My Button";
            //this.Controls.Add(button); //bu butonu ekrana koy demek.
            //yukar�daki gibi yazd���m�zda  bir tane buton olu�turur ancak bize 64 tane laz�m ki dama tahtas� yapabilelim. o y�zden
            //bu kodu ayr� ayr� 64 kere yazmak yerine 64 kere d�n diyece�iz.

            //--------------------------------------------------------------------------------------------------------//

            //for (int i = 1; i <= 64; i++)
            //{
            //    Button button = new Button();
            //    button.Width = 50;
            //    button.Height = 50;
            //    button.Text = "My Button";
            //    this.Controls.Add(button);// bu nutonu ekrana koy demek.
            //    //B�yle d�ng�de yapt���m�zda ekranda 64 tane �st �ste buton olmu� oluyor ama� bu b�t�n butonlar� yayabilmek.
            //    //ama benim o her butona ayr� ayr� eri�mem laz�m. �st �ste olmas�n� istemiyorum.
            //    //Ben ayn� i�lemden farkl� nesneler olu�turup onlar� kontrol alt�nda tutmak istiyorum.
            //    //Bu y�zden arrayden yararlanmak gerekiyor.
            //}

            //-------------------------------------------------------------------------------------------------------------------//

            Button[,] buttons = new Button[8, 8];  //1. sat�r�n sekiz butonu 2. sat�r�n 8 butonu 3. sat�r�n 8 butonu gibi d�ng� tasarlayaca��z.
            //8,8 yap�nca 2 boturlu yapm�� oluyoruz. getupper... da 0 yazmam�z�n sebebi s�f�r boyuttan ba�la toplamda 8 boyut olu�turacak.
            int top=0;    //y�kseklik de�eri  //de�i�ken tan�mlad�k.
            int left=0;   //sol de�eri   //de�i�ken tan�mlad�k.
            for (int i = 0; i < buttons.GetUpperBound(0); i++)    //get upper bound �st s�n�r� al demek. her bir sat�r i�in bir de�er olu�turduk.
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)//burada 1 yazd�k 2 botulu oldu�u i�in sa�daki 8 i kaps�yor.
                //Mant�k �u i =0 i�in j=0,  i=0 i�in j=1,......i=0 i�in j=7. 8 buton olmu� olacak. 8 e 8 yani 64 tane buton koyacam ama yine
                //ama yine �st �ste koymu� olacak. 
               
                {
                    buttons[i,j]=new Button(); // ilk buton benim i�in yeni butondur. 2. butonda yeni butondur. o y�zden s�rekli newlemeli.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;

                    buttons[i,j].Left = left;  //button [i,j]nin Left'i (yani formun ba�lan��� de�erine g�re soldan Uzakl���)=left left te 0. ilk buton
                    buttons[i, j].Top = top;
                    left += 50;    //Benim 2. botunu 50 birim uzak yapmam laz�m. bu y�zden 0 dan 50 karakter artt�r�yorum.  yan yana butonlar koymu� olduk.
                                   // sol kayd�rma i�lemi yapm�� olduk. Left 0 oldu�u i�in ilk butonu o noktadan koyuyor 2. buton i�in sola do�ru 50 art�yor.
                                   //�imdi y�kseklik (top i�inde ayn�s�n� yap�yorum.
                                   //Burada top 0 left 50 50 art�yor.  yukar�dan a�a�� dizmek i�inde left 0 olmal� top 50 50 artmal�.
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black; //button i,j nin arka plan rengi siyah 
                    }
                    else
                    {
                        buttons[i,j].BackColor=Color.White;
                    }
            
       

                    this.Controls.Add(buttons[i, j]);       //this den kas�t bu form a kar��l�k geliyor. ama yine �st �ste 64 tane oluyor.
                    // ilk butonun ba�lang�c de�eri forun en u� noktas�  yani ba�lan��� noktas� (sol en �st)
                    // Ben ilk butonu koyduktan sonra 2. butonu 50 sa�a kayd�rmam gerekiyor.
                    //ilk 8 buton i�in top 0 ikinci 8li i�in top 50

                }
                top += 50;
                left = 0;



            }





        }
    }
}