using RickMemeProject;

//PlaySong.Mario();
LeituraFile.ExibirTitulo();
Console.ReadLine();
var thread1 = new Thread(LeituraFile.ExibirGiftRick);
var thread2 = new Thread(PlaySong.RickSong);

thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();



