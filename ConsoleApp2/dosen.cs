using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class dosen
    {
        public int id;
        public string nama;
        public int Nik;
        public string gender;
        public string course;
        public void Dosen()
        {
            Console.WriteLine("Nik : " + Nik);
            Console.WriteLine("Gender : " + gender);
        }

        public void attDosen(string nama, int id)
        {
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("ID : " + id);
        }

        public void addCourse(string course)
        {
            Console.WriteLine("Course : " + course);
        }


    }
}
