using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Secretaria : Funcionario
    {
        public Secretaria(int codigo, string nome, double salario) : base(codigo, nome, salario) { }
        public override double CalcularBonificacao()
        {
            return base:CalcularBonificacao();
        }
    }
}