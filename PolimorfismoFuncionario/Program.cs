using PolimorfismoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f = new Funcionario(1, "Ana", 1000);
        System.Console.WriteLine($"Bonificação F: {f.CalcularBonificacao():c}"); //.c R$

        Secretaria s = new Secretaria(2, "Bia", 1000);
        System.Console.WriteLine($"Bonificação S: {s.CalcularBonificacao():c}");

        Gerente g = new Gerente(3, "Teo", 1000);
        System.Console.WriteLine($"Bonificação G: {g.CalcularBonificacao():c}");

        Diretor d = new Diretor(4, "Lia", 1000);
        System.Console.WriteLine($"Bonificação D: {d.CalcularBonificacao():c}");

        Gerenciador gr = new Gerenciador(0);
        gr.totalBonificacao = TotalizadorBonificacao();
        System.Console.Writeline($"Total de Bonificação: {gr.totalBonificacao}");
    }
}