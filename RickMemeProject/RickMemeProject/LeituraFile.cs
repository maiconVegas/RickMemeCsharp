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
        var enderecoDoArquivo = "C:\\Users\\maico\\OneDrive\\Área de Trabalho\\MemeRick\\RickMemeProject\\RickMemeProject\\Frames\\titulo.txt";
        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
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

        for (int i = 0; i < length; i++)
        {
            
        }

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }
    }
}
