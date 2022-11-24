using FiapHelloWord.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloModelo modelo = new HelloModelo();

            Console.WriteLine(modelo.Mensagem);
            Console.Read();
        }
    }
}
