﻿using ArrayFuncionario;

//declaração de variável vetor
Funcionario[] vetF = new Funcionario[3];
for(int i = 0; i < vetF.Length; i++)
{
    vetF[i] = new Funcionario();
    Console.Write("Digite o código: ");
    vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetF[i].nome = Console.ReadLine();
    Console.Write("Digite o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
}
foreach(Funcionario f in vetF)
    f.Mostrar();

for(int i = 0; i < vetF.Length; i++)
    vetF[i].Mostrar();    
    


