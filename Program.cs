using System;

using System.Collections.Generic;


public class Livro

{

    public string Titulo;

    public string Autor;

    public string ISBN;

    public int QuantidadeEmEstoque;


    public Livro(string titulo, string autor, string iSBN)

    {

        Titulo = titulo;

        Autor = autor;

        ISBN = iSBN;

        QuantidadeEmEstoque = 0;

    }


    public void AdicionarEstoque(int quantidade)

    {

        QuantidadeEmEstoque += quantidade;

    }


    public bool Vender(int quantidade)

    {

        if (QuantidadeEmEstoque >= quantidade)

        {

            QuantidadeEmEstoque -= quantidade;

            return true;

        }

        else

        {

            return false;

        }

    }

}


public class LivroDigital : Livro

{

    public string FormatoArquivo;


    public LivroDigital(string titulo, string autor, string iSBN, string formatoArquivo) : base(titulo, autor, iSBN)

    {

        FormatoArquivo = formatoArquivo;

        QuantidadeEmEstoque = 0;

    }

}


class Program

{

    static void Main(string[] args)

    {

        List<Livro> livros = new List<Livro>()

        {

            new Livro("O Grande Gatsby", "F. Scott Fitzgerald", "9780743273565"),

            new LivroDigital("Para Atirar Para Alvo Móvel", "Harper Lee", "9780060935467", "ePub")

        };


        livros[0].AdicionarEstoque(10);

        livros[1].AdicionarEstoque(20);


        foreach (var livro in livros)

        {

            Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Quantidade em estoque: {livro.QuantidadeEmEstoque}");


            if (livro is LivroDigital livroDigital)

            {

                Console.WriteLine($"Formato de arquivo: {livroDigital.FormatoArquivo}");

            }


            Console.WriteLine();

        }


        livros[0].Vender(3);

        livros[1].Vender(5);


        foreach (var livro in livros)

        {

            Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Quantidade em estoque: {livro.QuantidadeEmEstoque}");


            if (livro is LivroDigital livroDigital)

            {

                Console.WriteLine($"Formato de arquivo: {livroDigital.FormatoArquivo}");

            }


            Console.WriteLine();

        }

    }

}