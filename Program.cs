using System;
namespace Test
{


    public delegate void calculator(int a, int b);
    public delegate void messageHandler(string message);

    class example1
    {

        public static void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void mult(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine(Math.Abs( a- b));
        }
        public static void div(int a ,int b)
        {
            int Result;
            try
            {
                if (a > b)
                    Result = a / b;
                else
                    Result = b / a;
                Console.WriteLine($"Result = {Result}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Some Error Occurred={e.Message}");
                //exception  handling
            }
            
        }

        public static void DoSomework(string message)
        {
            
            Console.WriteLine($"Hello: {message}, Good Morning");
        }


        public static void Main(string[] args)
        {
            calculator add_ob = new calculator(add);
            add_ob(4, 5);
            calculator mult_ob = new calculator(mult);
            mult_ob(3, 4);
            calculator sub_ob = new calculator(sub);
            sub_ob(3, 4);
            calculator divi = new calculator(div);
            divi(3, 0);
            messageHandler mess = new messageHandler(DoSomework);
            mess("karina");//delegate string
            Record1 r1 = new("kay","ggg" );
            Console.WriteLine(" calling static function");
            mult(5, 4);
            example1.add(4, 50);

            Console.WriteLine("array creation and exception handling");

            Class1 obj = new Class1("karina","gwalani");
            obj.insertion();//array
            Console.WriteLine("name and age using Records");
            Person person = new Person()//using records for creation of variables
            {
                Name = "John Doe",
                Age = 18
            };

            person.Name = "Jane Doe";

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        }
    }
    public record Record1(string F_name,string L_name);

    public class Class1
    {
       public int[] arr = new int[3];
        public static int val;
        public void insertion()
        {
            for (int i = 0; i <= 4; i++)
            {
                try { 
                Console.WriteLine("enter value to add");
                 val = int.Parse(Console.ReadLine());
                arr[i] = val;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);break;
                }
            }
        }

        public string F_name { get; init; }
        public string L_name { get; init; }
        public Class1(string f_n,string l_n)
        {
            F_name = f_n;
            L_name = l_n;
        }

    }
    record Person
    {
       
        public string Name { get; set; }
        public int Age { get; set; }
    }

}