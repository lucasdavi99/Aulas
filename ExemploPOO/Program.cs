using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C://Trabalhando com Arquivos";

            FileHelper helper = new FileHelper();
            helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
            helper.CriarDiretorio(Path.Combine(caminho, "Pasta teste 3", "Subpasta Teste3"));
            
            
            
            
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));
            // System.Console.WriteLine(calc.Subtrair(60,20));
            // System.Console.WriteLine(calc.Mutiplicar(10,20));
            // System.Console.WriteLine(calc.Dividir(50,4));
            
            
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();
        
        //  Calculadora calc = new Calculadora();
        //  System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
        //  System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10,10));
        
        
        
        
        //  Aluno p1 = new Aluno();


        //      p1.Nome = "Lucas";
        //      p1.Idade = 22;
        //      p1.Documento = "123456";
        //      p1.Nota = 10;  
        //      p1.Apresentar();

        //      Professor p2 = new Professor();


        //      p2.Nome = "Márcio";
        //      p2.Idade = 35;
        //      p2.Documento = "123456";
        //      p2.Salario = 1000;  
        //      p2.Apresentar();
            
            
            
            
            // //Valores Válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");


            // //Valores Inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);

            // System.Console.WriteLine($"Área: {r2.ObterArea()}");
            
            
            
            
            // pessoa p1 = new pessoa();

            // p1.Nome = "Lucas";
            // p1.Idade = 22;

            // p1.Apresentar();
        }
    }
}
