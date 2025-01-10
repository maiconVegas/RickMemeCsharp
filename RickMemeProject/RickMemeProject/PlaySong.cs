using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace RickMemeProject;
public static class PlaySong
{
    public static void Mario()
    {
        Console.Beep(659, 125);
        Console.Beep(659, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(167);
        Console.Beep(523, 125);
        Console.Beep(659, 125);
        Thread.Sleep(125);
        Console.Beep(784, 125);
        Thread.Sleep(375);
        Console.Beep(392, 125);
        Thread.Sleep(375);
        Console.Beep(523, 125);
        Thread.Sleep(250);
        Console.Beep(392, 125);
        Thread.Sleep(250);
        Console.Beep(330, 125);
        Thread.Sleep(250);
        Console.Beep(440, 125);
        Thread.Sleep(125);
        Console.Beep(494, 125);
        Thread.Sleep(125);
        Console.Beep(466, 125);
        Thread.Sleep(42);
        Console.Beep(440, 125);
        Thread.Sleep(125);
        Console.Beep(392, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(125);
        Console.Beep(784, 125);
        Thread.Sleep(125);
        Console.Beep(880, 125);
        Thread.Sleep(125);
        Console.Beep(698, 125);
        Console.Beep(784, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(125);
        Console.Beep(523, 125);
        Thread.Sleep(125);
        Console.Beep(587, 125);
        Console.Beep(494, 125);
        Thread.Sleep(125);
        Console.Beep(523, 125);
        Thread.Sleep(250);
        Console.Beep(392, 125);
        Thread.Sleep(250);
        Console.Beep(330, 125);
        Thread.Sleep(250);
        Console.Beep(440, 125);
        Thread.Sleep(125);
        Console.Beep(494, 125);
        Thread.Sleep(125);
        Console.Beep(466, 125);
        Thread.Sleep(42);
        Console.Beep(440, 125);
        Thread.Sleep(125);
        Console.Beep(392, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(125);
        Console.Beep(784, 125);
        Thread.Sleep(125);
        Console.Beep(880, 125);
        Thread.Sleep(125);
        Console.Beep(698, 125);
        Console.Beep(784, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(125);
        Console.Beep(523, 125);
        Thread.Sleep(125);
        Console.Beep(587, 125);
        Console.Beep(494, 125);
        Thread.Sleep(375);
        Console.Beep(784, 125);
        Console.Beep(740, 125);
        Console.Beep(698, 125);
        Thread.Sleep(42);
        Console.Beep(622, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(167);
        Console.Beep(415, 125);
        Console.Beep(440, 125);
        Console.Beep(523, 125);
        Thread.Sleep(125);
        Console.Beep(440, 125);
        Console.Beep(523, 125);
        Console.Beep(587, 125);
        Thread.Sleep(250);
        Console.Beep(784, 125);
        Console.Beep(740, 125);
        Console.Beep(698, 125);
        Thread.Sleep(42);
        Console.Beep(622, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(167);
        Console.Beep(698, 125);
        Thread.Sleep(125);
        Console.Beep(698, 125);
        Console.Beep(698, 125);
        Thread.Sleep(625);
        Console.Beep(784, 125);
        Console.Beep(740, 125);
        Console.Beep(698, 125);
        Thread.Sleep(42);
        Console.Beep(622, 125);
        Thread.Sleep(125);
        Console.Beep(659, 125);
        Thread.Sleep(167);
        Console.Beep(415, 125);
        Console.Beep(440, 125);
        Console.Beep(523, 125);
        Thread.Sleep(125);
        Console.Beep(440, 125);
        Console.Beep(523, 125);
        Console.Beep(587, 125);
        Thread.Sleep(250);
        Console.Beep(622, 125);
        Thread.Sleep(250);
        Console.Beep(587, 125);
        Thread.Sleep(250);
        Console.Beep(523, 125);

    }

    public static void RickSong()
    {
        var mp3FilePath = Path.Combine(Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net8.0", ""), "Song\\Beep_Box_Never_Gonna_Give_You_Up.mp3");
        
        try
        {
            using (var audioFile = new AudioFileReader(mp3FilePath))
            {
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    Console.ReadKey();
                    outputDevice.Stop();
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }

    }


}
