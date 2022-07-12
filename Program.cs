using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable= "Emre Başpınar,Bursa";
            string variable2="Osmangazi";
            //Length;
            Console.WriteLine("***** Length *****");
            Console.WriteLine(variable.Length);

            //ToUpper-Lower
            Console.WriteLine("***** ToUpper-ToLower *****");
            Console.WriteLine(variable.ToUpper());
            Console.WriteLine(variable2.ToLower());

            //Concat
            Console.WriteLine("***** Concat *****");
            Console.WriteLine(string.Concat(variable," ",variable2));

            //Compare,CompareTo
            Console.WriteLine("***** Compare-CompareTo *****");
            Console.WriteLine(variable.CompareTo(variable2));
            Console.WriteLine(string.Compare(variable,variable2,true));
            Console.WriteLine(string.Compare(variable,variable2,false));
            
            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(variable.Contains(variable2));
            Console.WriteLine(variable.EndsWith("Emret Komutanım!!"));
            Console.WriteLine(variable.StartsWith("Günaydın"));

            //IndexOf
            Console.WriteLine("***** IndexOf *****");
            Console.WriteLine(variable.IndexOf(" "));
            Console.WriteLine(variable.IndexOf("Emre"));
            Console.WriteLine(variable.LastIndexOf("e"));

            //Insert
            Console.WriteLine("***** Insert *****");
            Console.WriteLine(variable.Insert(0,"Nasılsınız"));

            //PadLeft-PadRight
            Console.WriteLine("***** PadLeft-PadRight *****");
            Console.WriteLine(variable+variable2.PadLeft(30));
            Console.WriteLine(variable+variable2.PadLeft(30,'*'));
            Console.WriteLine(variable.PadRight(50)+variable2);
            Console.WriteLine(variable.PadRight(50,'-')+variable2);

            //Remove
            Console.WriteLine("***** Remove *****");
            Console.WriteLine(variable.Remove(10));
            Console.WriteLine(variable.Remove(5,3));
            Console.WriteLine(variable.Remove(0,1));
            
            //Replace
            Console.WriteLine("***** Replace *****");
            Console.WriteLine(variable.Replace("Komutanım"," Albayım"));
            Console.WriteLine(" ","/");

            //Split
            Console.WriteLine("***** Split *****");
            Console.WriteLine(variable.Split(' ')[1]);

            //Substring
            Console.WriteLine("***** Substring *****");
            Console.WriteLine(variable.Substring(4));
            Console.WriteLine(variable.Substring(4,6));

        }
    }
}