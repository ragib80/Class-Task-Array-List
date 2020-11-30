using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task_Array_List
{
    class Faculty
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Faculty()
        {

        }
        public Faculty(string name,string id)
        {
            this.name = name;
            this.id = id;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Faculty Name : " + name);
            Console.WriteLine("Faculty ID : " + id);
            Console.WriteLine(" ");
        }
    }
}
