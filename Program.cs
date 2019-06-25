using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList2
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Welly";

            // membuat objek mhs3
            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nim = "1236";
            mhs3.NamaMahasiswa = "Joko";

            // membuat objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            // membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambahkan elemen list
            // tidak ada proses boxing
            list.Add(mhs1);
            list.Add(mhs2);
            list.Add(mhs3);

            // coba tambahkan objek dosen ke list
            //list.Add(dosen);

            // akses elemen list
            // tidak ada proses unboxing
            Mahasiswa mhs = list[1];
            Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
            Console.WriteLine();
            

            Console.WriteLine("Nim\tNama");
            Console.WriteLine("================");

            foreach(Mahasiswa maha in list)
            {
                Console.WriteLine("{0}, \t{1}", maha.Nim, maha.NamaMahasiswa);
            }
            Console.WriteLine();

            // cari data berdasarkan nim 
            mhs = list.SingleOrDefault(f => f.Nim == "1234");

            // cari data mahasiswa yang namanya mirip
            List<Mahasiswa> hasilCari = list.Where(f => f.NamaMahasiswa.Contains("Joko")).ToList();

            Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);

            Console.ReadKey();
        }
    }
}
