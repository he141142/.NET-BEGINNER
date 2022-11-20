

using System;
using ConsoleApp2.entity;
using ConsoleApp2.builderImpl;
using ConsoleApp2.builderInterface;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacherBuilder builder = new teacherbuilder();
            Teacher teacher = builder.setName("Nguyễn Tiến Sơn").setShortName().build();
            Console.WriteLine(teacher.FullName);
            Console.WriteLine(teacher.ShortName);


            Console.WriteLine("Hello World!");
        }
    }
}
