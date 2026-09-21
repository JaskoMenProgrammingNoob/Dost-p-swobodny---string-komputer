using System.IO;
class Program
{
    FileStream F;
    string zdanie = "Komputer";
    int znak;
    public void zapisz()
    {
        StreamWriter zapis = new StreamWriter("komputer.txt");
        zapis.Write(zdanie);
        zapis.Close();
        F = new FileStream("komputer.txt", FileMode.Open);
        while ((znak = F.ReadByte()) != -1)
        {
            Console.Write((char)znak);
        }
        Console.WriteLine();
        F.Seek(2, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(4, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(7, SeekOrigin.Begin);
        Console.Write((char)F.ReadByte());
        F.Seek(-2, SeekOrigin.End);
        Console.Write((char)F.ReadByte());
        F.Seek(-8, SeekOrigin.End);
        Console.Write((char)F.ReadByte());

    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.zapisz();


    }
}