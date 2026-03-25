/*
StreamWriter sw = new StreamWriter("dados.txt");

string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

sw.WriteLine("IFSP");
sw.WriteLine("Barretos");
sw.WriteLine("ADS");
sw.WriteLine("2026");

sw.Close();

if (File.Exists("dados.txt"))
{
    StreamReader sr = new StreamReader("dados.txt");


    string instituicao = sr.ReadLine();
    string campus = sr.ReadLine();
    string curso = sr.ReadLine();
    string ano = sr.ReadLine();

    Console.WriteLine(instituicao);
    Console.WriteLine(campus);
    Console.WriteLine(curso);
    Console.WriteLine(ano);

}
else
{
    Console.WriteLine("arquivo não existe");
}

*/

string dados = File.ReadAllText("dados.txt");

Console.WriteLine(dados); 