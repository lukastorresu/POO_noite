using PolimorfismoFuncionario;
internal class GerenciadorBonificacao
{
        protected double totalBonificacao;
        public double TotalizadorBonificacao(Diretor d){
            this.totalBonificacao += d.CalcularBonificacao();
        }
        public double TotalizadorBonificacao(Secretaria s){
            this.totalBonificacao += s.CalcularBonificacao();
        }
        public double TotalizadorBonificacao(Gerente g){
            this.totalBonificacao += g.CalcularBonificacao();
        }
        public double TotalizadorBonificacao(Funcionario f){
            this.totalBonificacao += f.CalcularBonificacao();
        }
    }

