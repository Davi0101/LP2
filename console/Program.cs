using System;
using mylib.Entitles;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            EduPlatform.GetInfo();
            
            int answer = 42;
            string s = answer.ToString();
            Console.WriteLine(s);

            DateTime now = DateTime.Now;

            Console.WriteLine(now.Year.ToString());


            var p =  new Pessoa();
            p.nome = "Davi";
            Console.WriteLine(p.nome);


        
        }
    }

}

