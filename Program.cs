/* 4 – Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a 
seguinte regra: Salário até 2300, reajuste de 50%; Salários maiores que 2300, reajuste de 30%. versão 1.0


Console.Write("Informe o salário do funcionário R$: ");
double salario = Convert.ToDouble(Console.ReadLine());
if (salario <= 2300)
{
    salario = (salario * 0.5) + salario;
}
else 
{
    salario = (salario * 0.3) + salario;
}

Console.WriteLine("O salário informado é de R$ " + salario.ToString("F2"));
*/

// Programa para aumento de salário - versão 1.1
/*
Criar menu de opções 
Informe o nome do funcionário, matricula, cargo, salário, reajuste
*/
string? acao = "";
string caminho = "funcionario.txt";
string? nome, cargo;
int matricula, idade;
double salario = 0, novoSalario = 0, porcentagem;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("##########- MENU -##########");
Console.WriteLine("N - Novo ###################");
Console.WriteLine("C - Consultar ##############");
Console.WriteLine("S - Sair ###################");
Console.WriteLine("############################");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Informe a operação desejada ");
Console.ResetColor();

acao = Console.ReadLine().ToUpper();
Console.WriteLine();

while (acao != "S") 
{
    if (acao == "N")
    {
        Console.WriteLine("Informe o nome do funcionário ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a idade do funcionário ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a matricula do funcionário ");
        matricula = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o cargo do funcionário ");
        cargo = Console.ReadLine();
        Console.WriteLine("Informe o salário do funcionário R$ ");
        salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a porcentagem de reajuste do salário ");
        porcentagem = Convert.ToDouble(Console.ReadLine());
        
        novoSalario = (salario * porcentagem) + salario;

        if (novoSalario > 0 && nome?.Trim().Length > 2 && idade > 0 && matricula > 0 && cargo?.Trim().Length > 2 
        && salario > 0 && porcentagem > 0) 
        {
            StreamWriter sw = new StreamWriter(caminho, true);
            sw.WriteLine(String.Format("Nome: {0}", nome));
            sw.WriteLine(String.Format("Idade: {0}", idade));
            sw.WriteLine(String.Format("Matricula: {0}", matricula));
            sw.WriteLine(String.Format("Cargo: {0}", cargo));
            sw.WriteLine(String.Format("Salario R$: {0}", salario.ToString("F2")));
            sw.WriteLine(String.Format("% de aumento: {0}", porcentagem));
            sw.WriteLine(String.Format("Novo salário R$: {0}", novoSalario.ToString("F2")));
            sw.WriteLine("------------------------------------------");
            sw.Close();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("-->Dados inválidos, operação cancelada!!!");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
    else if (acao == "C")
    {
        StreamReader sr = new StreamReader(caminho);
        while(!sr.EndOfStream)
        {
            Console.WriteLine(sr.ReadLine());
        }
        sr.Close();
    }
    Console.WriteLine();
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadKey();

    Console.Clear();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("##########- MENU -##########");
    Console.WriteLine("N - Novo ###################");
    Console.WriteLine("C - Consultar ##############");
    Console.WriteLine("S - Sair ###################");
    Console.WriteLine("############################");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Informe a operação desejada ");
    Console.ResetColor();

    acao = Console.ReadLine().ToUpper();
    Console.WriteLine();
}