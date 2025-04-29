using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Funcionario
    {
        //atributos
        protected int codigo;
        protected string? nome;
        protected double salario;
       
       //get e set
        public int Codigo{get;set;}
        public string? Nome{get;set;}
        public double Salario{get;set;}
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual double CalcularBonificacao() //base virtual
        {
            return Salario * 0.1;
        }
    }
}