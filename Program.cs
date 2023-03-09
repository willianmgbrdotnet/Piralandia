using System;
using System.Text;

class URI
{

    static void Main(string[] args) 
    { 

            string n = Console.ReadLine();
            //continue a solução
            StringBuilder padraoBr = new StringBuilder();

            for(var i = n.Length-1; i >= 0; i--)
            {
                padraoBr.Append(n[i]);
            }

            var v = padraoBr;
            Console.WriteLine(v);
    }

}