using System;
using OOP.ContentContext;

namespace OOP.ContentContext.Enums
{
    class Program
    {
        public static void Main(string[] args)
        {
            var course = new Course();

            course.Level = ContentContext.Enums.EContentLevel.Begginer;
            
        }
    }
}