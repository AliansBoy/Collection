﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new CustomList<Notebook>();

            var NoteBoook_1 = new Notebook(1, "Lenovo");
            var NoteBoook_2 = new Notebook(2, "Acer");
            var NoteBoook_3 = new Notebook(3, "Samsung");
            var NoteBoook_4 = new Notebook(4, "Asus");
            var NoteBoook_5 = new Notebook(5, "HP");
            var NoteBoook_6 = new Notebook(6, "Dell");

            List.Add(NoteBoook_1);
            List.Add(NoteBoook_2);
            List.Add(NoteBoook_3);
            List.Add(NoteBoook_4);
            List.Add(NoteBoook_5);
            List.Add(NoteBoook_6);

            foreach (var x in List)
            {
                Console.WriteLine($"Serial Number: {x.SerialNumber}; Name: {x.Name}");
            }

            List.Delete(NoteBoook_4);
            List.Delete(NoteBoook_2);

            Console.WriteLine("=============================");

            foreach (var x in List)
            {
                Console.WriteLine($"Serial Number: {x.SerialNumber}; Name: {x.Name}");
            }

            Console.ReadKey();
        }
    }
}