using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraPOO.metodo
{
    public class Calculos
    {
        public int Calcular(int n1, int n2, string op)
        {
        if(op.Equals("+")) return n1 + n2;
        if(op.Equals("-")) return n1 - n2;
        if(op.Equals("*")) return n1 * n2;
        if(op.Equals("/")) return n1 / n2;
        return 0;
        }
    }
}
