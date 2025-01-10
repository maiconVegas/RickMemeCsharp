using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMemeProject;
public static class LeituraFile
{
    public static void ExibirTitulo()
    {
        var enderecoDoArquivoTitulo = Path.Combine(Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net8.0", ""), "Frames\\titulo.txt");
        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivoTitulo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }
    }

    public static void ExibirGiftRick()
    {
        ExibirContagemRegressiva();
        int time = 0;
        while (time <= 32)
        {
            var enderecoFrames = Path.Combine(Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net8.0", ""), "Frames"); ;

            for (int i = 0; i < 28; i++)
            {
                Console.Clear();
                var caminhoArquivo = Path.Combine(enderecoFrames, $"rick{i}.txt");
                if (File.Exists(caminhoArquivo))
                {
                    using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Open))
                    using (var leitor = new StreamReader(fluxoDeArquivo))
                    {
                        while (!leitor.EndOfStream)
                        {
                            var linha = leitor.ReadLine();
                            Console.WriteLine(linha);
                        }
                    }
                }
                Thread.Sleep(100);
            }
            time += 1;
        }
    }

    public static void ExibirContagemRegressiva()
    {
        Console.Clear();
        var enderecoFrames = Path.Combine(Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net8.0", ""), "Frames"); ;

        for (int i = 1; i <= 3; i++)
        {
            Console.Clear();
            var caminhoArquivo = Path.Combine(enderecoFrames, $"{i}.txt");
            if (File.Exists(caminhoArquivo))
            {
                using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Open))
                using (var leitor = new StreamReader(fluxoDeArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            }
            Thread.Sleep(833);
        }
    }
}
