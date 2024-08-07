//Projeção de Ganhos, o usuario deverá definir o ganho mensal, dias a trabalhar no mes, 
//horas a trabalhar, gastos como combustivel e alimentação.


using GestaoDeGastoDefinido;
using System;
using System.Globalization;
namespace GestorDeGanhos;

class Program
{
    static void Main(string[] args)
    {

        GestaoDeGastoDefinido.GestaoDeGastoDefinido usuario = new GestaoDeGastoDefinido.GestaoDeGastoDefinido();

        Console.WriteLine("Programa que auxilia nas gestão de ganhos");
        Console.WriteLine("Definição de dias a trabalhar no mês");
        Console.Write("Quandos dias você deseja trabalhar no mês: ");
        usuario.Dias = double.Parse(Console.ReadLine());
        Console.Write("Quantas horas por dia você tem disponivel: ");
        usuario.Horas = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Valor que deseja obter mensal: R$");
        usuario.GanhosDefinido = double.Parse(Console.ReadLine());
        Console.Write("Valor diario de alimentação: R$");
        usuario.Alimentacao = double.Parse(Console.ReadLine());
        Console.Write("Valor previsto gasto em combustivel: R$");
        usuario.Combustivel = double.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine(usuario);
    }
}


