namespace Try_Catch_Error_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Bir sayi giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmis oldugunuz sayi:" + sayi);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata:"+ ex.Message.ToString());
            //    throw;
            //}
            //finally 
            //{
            //    Console.WriteLine("Islem tamamlandi");
            // }

            try { /*int a = int.Parse(null);*/
                //int a = int.Parse("test");
                int a = 1000000000000;
            }

            catch (ArgumentNullException ex) 
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Cok kucuk yada cok buyuk bir deger girdiniz.");
                Console.WriteLine(ex);
            }
            
        }
    }
}