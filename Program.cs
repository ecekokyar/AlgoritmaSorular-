using System;
using System.Collections.Generic;

namespace algoritma_soruları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****SORU 1*****");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int number=Convert.ToInt32(Console.ReadLine());

            if(number>0)
            {
                Console.WriteLine($"{number} adet pozitif sayı giriniz: ");
                List<int> evenNumbers = new List<int>();
                for (int i = 0; i < number; i++)
                {
                    
                    int posNumbers=Convert.ToInt32(Console.ReadLine());
                    if (posNumbers%2==0)
                    {
                        evenNumbers.Add(posNumbers);
                        
                    }
                    
                }
                Console.WriteLine("Girilen çift sayılar: ");
                foreach (var item1 in evenNumbers)
                {
                    Console.WriteLine(item1+" ");
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı pozitif değil.");
            }
            
            Console.WriteLine("*****SORU 2*****");
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("2 adet pozitif sayı giriniz: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());
       
            if(n>0 && m>0)
            {
                Console.WriteLine($"{n} adet pozitif sayı giriniz: ");
                List<int> result = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    int num=Convert.ToInt32(Console.ReadLine());
                    
                    if (num==m || m%num==0)
                    {
                        result.Add(num);
                    }
                }
                Console.WriteLine($"Girmiş olduğunuz 2.sayıya({m}) eşit ya da tam bölünen sayılar: ");
                foreach (var item2 in result)
                {
                    Console.WriteLine(item2+" ");
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı pozitif değil.");
            }

            Console.WriteLine("*****SORU 3*****");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int number1=Convert.ToInt32(Console.ReadLine());

            if(number1>0)
            {
                Console.WriteLine($"{number1} adet kelime giriniz: ");
                List<string> words1 = new List<string>();
                for (int i = 0; i <number1; i++)
                {
                    string word=Console.ReadLine();
                    words1.Add(word);
                }
                words1.Reverse();
                Console.WriteLine("Girilen kelimelerin sondan başa sıralanışı: ");
                foreach (string item in words1)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı pozitif değil.");
            }

            Console.WriteLine("*****SORU 4*****");
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("Bir cümle yazınız: ");
            string sentence =Console.ReadLine();
           
            //harf sayısı bulma
            int c=0;
            string newSentence=sentence.Replace(" ","");
            foreach (char character in newSentence.ToCharArray())
            {    
               c++;
            }
            Console.WriteLine($"Cümledeki toplam harf sayısı:{c} ");
           
            //kelime sayısı bulma
            string[] words = sentence.Split(' ');
            int w=0;
            foreach (var item in words)
            {
               w++;
            }
            Console.WriteLine($"Cümledeki toplam kelime sayısı:{w}");
        }
    }
}
