using ExceptionDemo300924.finally_block;
using ExceptionDemo300924.How_to_Handle_Exception_in_Program;
using ExceptionDemo300924.UserDefineException1;

namespace ExceptionDemo300924
{
    class class2
    {
        public void method2()
        {
            Console.WriteLine("******** method2 started..");
            int x, y;
            Console.WriteLine("enter x and y");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int z = 0;

            z = x / y;// write exception handling logic here**********


            Console.WriteLine("result =" + z);
            Console.WriteLine("************ method2 last line..");
        }
    }
    class classTemp
    {
        public void method1()
        {
            Console.WriteLine("########## method1 started..");
            class2 obj = new class2();

            obj.method2();

            Console.WriteLine("########## method1 last line..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 300924_code
            //Console.WriteLine("this is first statement in main method!");
            //classTemp ct = new classTemp();
            //int[] x = new int[5];
            ////try
            ////{
            ////    x[8] = 777;
            ////}
            ////catch(IndexOutOfRangeException a1)
            ////{
            ////    Console.WriteLine("please select index between 0 to 4 only");
            ////}
            ////try
            ////{ 
            ////ct.method1();
            ////}

            ////catch (DivideByZeroException ab)
            ////{
            ////    Console.WriteLine(ab.Message);
            ////}
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    x[2] = 777;//indexoutofRange
            //    ct.method1();//dividebyzero
            //}
            //catch 
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("exception occured... please check it");
            //}
            ////catch (DivideByZeroException de)
            ////{
            ////    Console.WriteLine(de.Message);
            ////}



            //Console.WriteLine("this is last line in main method");
            #endregion
            //Employee[] emps = new Employee[5];
            //int id = 0;
            //string name = null;
            //int salary1 = 0;
            //for (int i = 0; i <= emps.Length; i++)
            //{
            //    Console.WriteLine("Enter ID, Name and salary of employee");
            //    try
            //    {
            //        id = int.Parse(Console.ReadLine());
            //        name = Console.ReadLine();
            //        salary1 = int.Parse(Console.ReadLine());
            //        emps[i] = new Employee();
            //        emps[i].SetInfo(id, name, salary1);
            //    }

            //    catch (ArgumentNullException ane)
            //    {
            //        Console.WriteLine(ane.Message);
            //    }

            //    catch (FormatException fe)
            //    {
            //        Console.WriteLine(fe.Message);
            //    }
            //    catch (OverflowException ofe)
            //    {
            //        Console.WriteLine(ofe.Message);
            //    }



            //}

            //Console.WriteLine("All Employee information is ;");
            //for (int i = 0; i < emps.Length; i++)
            //{
            //    try
            //    {
            //        emps[i].showEmp();
            //    }
            //      catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

            //ArithmeticOperations aoObj = new ArithmeticOperations();
            //aoObj.div(100, 0);
            //aoObj.sum(100, 200);
            Console.WriteLine("enter number");

            try
            {
                int no = int.Parse(Console.ReadLine());
                if (no%2!=0)
                {
                    //MyException me = new MyException("Odd number not allowed!!!!");
                    //throw (me);
                    // throw (new MyException("odd not allowed!!!"));
                    throw (new IndexOutOfRangeException("Odd number not allowed. please enter even number"));
                }
            }
            

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadKey();
        }
    }
}
