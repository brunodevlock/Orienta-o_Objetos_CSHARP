using System;
using System.Collections.Generic;
using OO.ContentContext;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //novo curso
            var courseOOP = new Course("OOP", "C#");
            var courses = new List<Course>();
            courses.Add(courseOOP);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista .net");
            var careerItem1 = new CareerItem(1, "Aprenda .NET", "", courseOOP);
            careerDotnet.Items.Add(careerItem1);
            careers.Add(careerDotnet);


            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientação a objetos"));
            articles.Add(new Article("Artigo sobre C#", "C#"));
            articles.Add(new Article("Artigo sobre .NET", ".NET"));

            foreach(var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);

            }




        }
    }
}
