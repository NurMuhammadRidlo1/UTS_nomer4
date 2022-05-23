using ConsoleApp2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dosen obj = new dosen();
            obj.Nik = 12345;
            obj.gender = "laki-laki";
            obj.attDosen("Nur", 1212);
            obj.addCourse("Pemrograman");
            obj.Dosen();
        }
    }
}