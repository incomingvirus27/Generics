using System;

namespace IntergenicLibrary
{
    class Program
    {
        static void Main(string[] args)
        {          
           
            Student student = new Student("Jack", 2018, "112B");
            Student student1 = new Student("Mark", 2017, "23E");
            Student student2= new Student("Mary", 2020, "34ME");
            Student student3 = new Student("Benson", 2018, "2CS");
            Student student4 = new Student("Thompson", 2016, "43C");

            Book book = new Book("Unbecoming", "16");
            Book book1 = new Book("The marriage plot", "18");
            Book book2 = new Book("Brief history of time", "78");
            Book book3 = new Book("Confessions", "98");
            Book book4 = new Book("Real time", "77");

            Library library = new Library(student,book,"2/25/2018", "3/1/2018");
            Library library1 = new Library(student1,book1,"12/25/2017", "3/1/2017");
            Library library2 = new Library(student2,book2,"8/2/2020", "8/20/2018");
            Library library3 = new Library(student3, book3, "2/7/2018", "11/7/2018");
            Library library4 = new Library(student4,book4,"11/5/2016", "11/15/2016");                      

            GenericDefaulterList<IDefaulterList> lib = new GenericDefaulterList<IDefaulterList>();

            lib.Add(library);
            lib.Add(library1);
            lib.Add(library2);
            lib.Add(library3);
            lib.Add(library4);

            foreach (IDefaulterList list in lib.GetAllDefaulters())
            {
                Console.WriteLine(list);
            }
        }
    }
}
