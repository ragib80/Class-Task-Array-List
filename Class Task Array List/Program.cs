using System;

namespace Class_Task_Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty("Tanvir Ahmed", "0025");
            Faculty f2 = new Faculty("Sajib Hasan", "20022");
            Department d1 = new Department("CS", "001");
            d1.ShowInfo();
            d1.AddFaculty(f1, f2);
            d1.ShowAllFaculties();
           
            var faculty = d1.SearchFaculty("0025");
            if(faculty != null)
            {
                d1.DelateFaculty(faculty);
            }
            Console.WriteLine("--------------delating---------------");
                d1.ShowAllFaculties();
        }

    }
}
