using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Class_Task_Array_List
{
    class Department
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
        ArrayList faculties;
        public Department()
        {
            faculties = new ArrayList();
        }
        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            faculties = new ArrayList();
        }
        public void AddFaculty(params Faculty[] faculties)
        {
            foreach(Faculty f in faculties)
            {
                this.faculties.Add(f);
            }
        }
        public void ShowAllFaculties()
        {
            foreach(Faculty f in this.faculties)
            {
                f.ShowInfo();
            }
        }
        public Faculty SearchFaculty(string id)
        {
            Faculty t = null;
            foreach(Faculty f in faculties)
            {
                if (f.Id.Equals(id))
                {
                    t = f;
                }
            }
            return t;
        }
        public void DelateFaculty(Faculty f)
        {
            faculties.Remove(f);
        }
        public void ShowInfo()
        {
            Console.WriteLine("Department Name : " + name);
            Console.WriteLine("Department ID : " + id);
            Console.WriteLine(" ");
        }
    }
}
