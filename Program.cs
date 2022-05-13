using System;

namespace Factorypattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            Console.WriteLine("Enter your Obj Type");
            string type = Console.ReadLine();
            I1 obj1 = FactoryObj.GetObj(type);

            Console.WriteLine(obj1.GetName() + ' ' + obj1.GetFName());
            Console.ReadLine();
        }
    }


// Factory Design Patterns ---> Creational Design patterns

// Defn : A Factory is an Object which is used for Creating another Object .
    /*
     *  1. Creating objects without exposing the instantiation logic to the client.
     *  
     *  2. Referring to the newly Created objects through a Common Interface .
     *  
     *  RULES :
     *  =======
     *  
     *  1) Declare an Interface 
     *  2) Inherit from that interface 
     *  3) Create a Factory class 
     *  4) Create a Static Method in that Factory Class
     */


    class FactoryObj
    {
        public static I1 GetObj(string objtype)
        {
            I1 obj = null;
            if(objtype.ToLower() == "student")
            {
                obj = new Student();
            }

           else
            {
                obj = new Teacher();
            }

            return obj;
        }
    }


    // 1. Declare an Interface
    interface I1
    {
        string GetName();
        string GetFName();
    }



    class Teacher : I1
    {
        public string GetName()
        {
            return " Teacher Name";
        }
        public string GetFName()
        {
            return " Teacher --->  Father Name";
        }
    }

    class Student : I1
    {
        public string GetName()
        {
            return " Student Name";
        }
        public string GetFName()
        {
            return " Student ==> Father Name";
        }
    }

}
