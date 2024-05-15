using System.ComponentModel.Design;

namespace Area_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil Uygulamasına Hoşgeldiniz");

            while (true)
            {
                Console.WriteLine("İşlem Seçiniz");
                Console.WriteLine("1 - Dikdörtgen İşlemleri");
                Console.WriteLine("2 - Üçgen İşlemleri");
                Console.WriteLine("3 - Kare İşlemleri");
                Console.WriteLine("4 - Q'ya basarak çıkış yapınız ");

                string election = Console.ReadLine();

                if (election == "Q")
                {
                    break;
                }
                else if (election == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Dikdörtgen Alan");
                        Console.WriteLine("2-Dikdörtgen Bilgileri");
                        Console.WriteLine("3-Dikdörtgen Çıkış (q)");

                        string rectangleelection = Console.ReadLine();

                        if (rectangleelection == "1")
                        {
                            Console.WriteLine("Kısa Kenarı Giriniz");
                            int shorts = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun Kenarı Giriniz");
                            int longedge = Convert.ToInt32(Console.ReadLine());
                            rectangle rectangle = new rectangle("Dikdörtgen", shorts, longedge);
                            rectangle.shapeCalculate();
                        }
                        else if (rectangleelection == "2")
                        {
                            Console.WriteLine("Kısa Kenarı Giriniz");
                            int shorts = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun Kenarı Giriniz");
                            int longedge = Convert.ToInt32(Console.ReadLine());
                            rectangle rectangle = new rectangle("Dikdörtgen", shorts, longedge);
                            rectangle.shapeİnformation();
                        }
                        else if (rectangleelection == "q")
                        {
                            Console.WriteLine("Dikdörtgen İşlemlerinden Çıkılıyor");
                            break;
                        }
                    }
                }
                else if (election == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Üçgen Alan");
                        Console.WriteLine("2-Üçgen Bilgileri");
                        Console.WriteLine("3-Üçgen Çıkış (q)");

                        string triangleelection = Console.ReadLine();

                        if (triangleelection == "1")
                        {
                            Console.WriteLine("Taban Alanı Giriniz");
                            int floorarea = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yüksekliğini Giriniz");
                            int height = Convert.ToInt32(Console.ReadLine());
                            triangle trianglee = new triangle("Üçgen", floorarea, height);
                            trianglee.shapeCalculate();
                        }
                        else if (triangleelection == "2")
                        {
                            Console.WriteLine("Taban Alanı Giriniz");
                            int floorarea = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yüksekliğini Giriniz");
                            int height = Convert.ToInt32(Console.ReadLine());
                            triangle trianglee = new triangle("Üçgen", floorarea, height);
                            trianglee.shapeİnformation();
                        }
                        else if (triangleelection == "q")
                        {
                            Console.WriteLine("Üçgen İşlemlerinden Çıkılıyor");
                            break;
                        }
                    }
                }
                else if (election == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Kare Alan");
                        Console.WriteLine("2-Kare Bilgileri");
                        Console.WriteLine("3-Kare Çıkış (q)");

                        string squareelection = Console.ReadLine();

                        if (squareelection == "1")
                        {
                            Console.WriteLine("Kenar Giriniz");
                            int edge = Convert.ToInt32(Console.ReadLine());
                            square square = new square("Kare", edge);
                            square.shapeCalculate();
                        }
                        else if (squareelection == "2")
                        {
                            Console.WriteLine("Kenar Giriniz");
                            int edge = Convert.ToInt32(Console.ReadLine());
                            square square = new square("Kare", edge);
                            square.shapeİnformation();
                        }
                        else if (squareelection == "q")
                        {
                            Console.WriteLine("Kare İşlemlerinden Çıkılıyor");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir İşlem Yapınız");
                }
            }
        }
    }
    public class shape
    {
        public string name { get; set; }
        public shape(string isim)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public virtual void shapeCalculate()
        {
            Console.WriteLine("Şeklin Alanı Hesaplanıyor");
        }
        public virtual void shapeİnformation()
        {
            Console.WriteLine(getname() + "nin bilgiler");
        }
    }
    public class rectangle : shape
    {
        public int shorts { get; set; }
        public int longedge { get; set; }
        public rectangle(string name, int shorts, int longedge) : base(name)
        {
            this.longedge = longedge;
            this.shorts = shorts;
        }
        public override void shapeCalculate()
        {
            base.shapeCalculate();
            Console.WriteLine(getname() + "nin alanı: " + (shorts * longedge));
        }
        public override void shapeİnformation()
        {
            base.shapeİnformation();
            Console.WriteLine(getname() + "nin kısa kenarı: " + this.shorts);
            Console.WriteLine(getname() + "nin uzun kenarı: " + this.longedge);
        }
    }
    public class triangle : shape
    {
        public int height { get; set; }
        public int floorarea { get; set; }
        public triangle(string name, int height, int floorarea) : base(name)
        {
            this.floorarea = floorarea;
            this.height = height;
        }
        public override void shapeCalculate()
        {
            base.shapeCalculate();
            Console.WriteLine(getname() + "nin alanı:" + (height * floorarea / 2));
        }
        public override void shapeİnformation()
        {
            base.shapeİnformation();
            Console.WriteLine(getname() + "nin taban alanı: " + this.floorarea);
            Console.WriteLine(getname() + "nin yuksekliği" + this.height);
        }
    }
    public class square : shape
    {
        public int edge { get; set; }
        public square(string name, int edge) : base(name)
        {
            this.edge = edge;
        }
        public override void shapeCalculate()
        {
            base.shapeCalculate();
            Console.WriteLine(getname() + "nin alanı: " + (edge * edge));
        }
        public override void shapeİnformation()
        {
            base.shapeİnformation();
            Console.WriteLine(getname() + "nin kenarı: " + this.edge);
        }
    }
}
