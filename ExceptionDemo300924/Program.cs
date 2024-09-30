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
            int z=0;
           
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
            Console.WriteLine("this is first statement in main method!");
            classTemp ct = new classTemp();
            int[] x = new int[5];
            //try
            //{
            //    x[8] = 777;
            //}
            //catch(IndexOutOfRangeException a1)
            //{
            //    Console.WriteLine("please select index between 0 to 4 only");
            //}
            //try
            //{ 
            //ct.method1();
            //}

            //catch (DivideByZeroException ab)
            //{
            //    Console.WriteLine(ab.Message);
            //}
            try
            {
                int a = int.Parse(Console.ReadLine());
                x[2] = 777;//indexoutofRange
                ct.method1();//dividebyzero
            }
            catch 
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("exception occured... please check it");
            }
            //catch (DivideByZeroException de)
            //{
            //    Console.WriteLine(de.Message);
            //}



            Console.WriteLine("this is last line in main method");
            Console.ReadKey();
        }
    }
}
