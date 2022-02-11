Console.WriteLine("Diretórios removidos:");
Console.WriteLine();

foreach (var dir in Directory.GetDirectories(@"C:\Projetos\PagueVeloz"))
{
    foreach (var obj in Directory.GetDirectories(dir, "obj"))
    {
        Console.WriteLine(obj);
        Directory.Delete(obj, true);    
    }

    foreach (var bin in Directory.GetDirectories(dir, "bin"))
    {
        Console.WriteLine(bin);
        Directory.Delete(bin, true);
    }
}