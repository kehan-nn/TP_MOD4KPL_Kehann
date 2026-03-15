using System;
using TP_MODUL4_103022400012;

class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.Write("Masukkan Kelurahan: ");
        string kelurahan = Console.ReadLine();

        Console.WriteLine("Kode Pos: " + kode.getKodePos(kelurahan));

        
    }

}