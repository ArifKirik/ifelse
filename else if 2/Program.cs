namespace else_if_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sınav1, sınav2, proje, ortalama;
            //Console.WriteLine("sınav1 giriniz:");
            //sınav1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sınav2 giriniz:");
            //sınav2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("projeyi giriniz:");
            //proje = Convert.ToInt32(Console.ReadLine());
            //ortalama = (sınav1 + sınav2 + proje) / 3;
            //Console.WriteLine("ortalama=" + ortalama);

            //if (ortalama > 0 && ortalama < 30)
            //{
            //    Console.WriteLine("Durum:çok kötü");
            //}
            //else if (ortalama >= 30 && ortalama < 50)
            //{
            //    Console.WriteLine("Durum:biraz kötü");
            //}
            //else if (ortalama >= 50 && ortalama < 60)
            //{
            //    Console.WriteLine("Durum:orta");
            //}
            //else if (ortalama >= 60 && ortalama < 80)
            //{
            //    Console.WriteLine("Durum:iyi");
            //}
            //else if (ortalama >= 80 && ortalama < 100)
            //{
            //    Console.WriteLine("Durum:çok iyi");
            //}
            //Console.ReadLine();

            //int sayı;
            //Console.WriteLine("sayı giriniz:");
            //sayı = Convert.ToInt32(Console.ReadLine());

            //if(sayı%2==0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            {
                int sayı;
                Console.WriteLine("sayı giriniz:");
                sayı = Convert.ToInt32(Console.ReadLine());

                if (sayı % 5 == 0)
                {
                    Console.WriteLine("sayı 5 e tam bölünür");
                }
                else
                {
                    Console.WriteLine("sayı 5 e tam bölünmez");
                }
            } 
        } 
    }
}
