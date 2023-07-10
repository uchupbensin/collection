using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";
            
            List<Mahasiswa> list = new List<Mahasiswa>();
            
            list.Add(mhs1);
            list.Add(mhs2);

            Console.WriteLine("Nim    Nama");
            Console.WriteLine("===========");
            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0},  {1}", mhs.Nim, mhs.NamaMahasiswa);
            }
            Console.ReadKey();
        }
    }
}