/*Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
    Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês,
    com duas casas decimais.

Entrada
O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais,
representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

Saída
Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.*/
using System;
using System.Globalization;

string nome;
double salariofixo, totalvendas, salariototal;

Console.WriteLine("Digite o nome do vendedor: ");
nome = Console.ReadLine();
Console.WriteLine("Digite o Salário Fixo: ");
salariofixo = double.Parse(Console.ReadLine()/*, CultureInfo.InvariantCulture)*/);
Console.WriteLine("Digite o Total da Venda: ");
totalvendas = double.Parse(Console.ReadLine()/*, CultureInfo.InvariantCulture)*/);

salariototal = totalvendas * 15.0 / 100 + salariofixo;

Console.WriteLine("Total = R$ " + salariototal.ToString("F2"));

