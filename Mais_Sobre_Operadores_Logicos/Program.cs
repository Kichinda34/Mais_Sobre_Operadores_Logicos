using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mais_Sobre_Operadores_Logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true; 
            bool var2 = false;
            bool resultadoOU_1 = var1 | var2;
            bool resultadoOU_2 = var1 || var2;
            //Aprendido que o operador de || tem um pouco mais de velocidade que o operador |, então é comum ver as duas barras "||"

            bool resultadoE_1 = var1 & var2;
            bool resultadoE_2 = var1 && var2;
            //A mesma coisa se aplica aos operadores de E "&"

        }
    }
}
