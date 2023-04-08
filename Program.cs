using System;


namespace INTERFACES
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartTimeEmployee obj = new PartTimeEmployee();
            //obj.Show();
            //obj.Show1();
            //obj.Show2();

            IEmployee2 obj1 = new PartTimeEmployee();



            //explicit
            //Employees e1 = new Employees();
            //((i1)e1).Print();
            //((i2)e1).Print();

            i1 obj2 = new Employees();
            obj2.Print();
            i1 obj3 = new Employees();
            obj3.Print();

            //object of Example class
            Example obj4 = new Example();
            obj4.print1();
            obj4.print2();
        }
    }
    interface IEmployee

    {
        // int Id;    //interfaces don't have fields
        void Show();
    }
    interface IEmployee1

    {
        void Show1();
    }
    interface IEmployee2 : IEmployee, IEmployee1

    {
        void Show2();
    }

    class PartTimeEmployee : IEmployee2
    {
        public void Show()
        {
            Console.WriteLine("This is the method of IEmployee Interface !!");
        }
        public void Show1()
        {
            Console.WriteLine("This is the method of IEmployee Interface1 !!");
        }
        public void Show2()
        {
            Console.WriteLine("This is the method of IEmployee Interface2 !!");
        }

    }
    //Explicit interface
    interface i1
    {
        void Print();
    }
    interface i2
    {
        void Print();
    }
    public class Employees : i1, i2
    {
        void i1.Print()
        {
            Console.WriteLine("This is the method of i1 interface !!");
        }
        void i2.Print()
        {
            Console.WriteLine("This is the method of i1 interface !!");
        }

    }

    //abstract class vs interfaces
    class Example2
    {

    }
    interface emp1
    {

    }
    interface emp2
    {

    }
    interface MyInterface : emp1,emp2  //can't inherit a class
    {
        void print1();
    }
    abstract class MyAbstract:Example2,emp1,emp2 //can inherit a class
    {
        public abstract void print2();
    }
    class Example: MyAbstract, MyInterface
    {
         public void print1()
        {
            Console.WriteLine("This is the method of interface !!");
        }

        public  override void print2()
        {
            Console.WriteLine("This is the method of abstract !!");
        }
    }

}



