namespace ExceptionDemo300924.finally_block
{
    class ArithmeticOperations
    {
        public void DBMethod()
        {
            //SqlConnection con = new SqlConnection("Data Source=Desktop-ABKHEEV;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //try
            //{
            //    con.Open();
            //    jkkkdf
            //        insert
            //    update
            //    delte
            //    }
            //catch (Exception ex)
            //{
            //}
            //finally
            //{
            //    con.Close();
            //}


        }
        public int sum(int x, int y)
        {
            try
            {
                Exception ex = new Exception("this is my exception");
                throw (ex);
                return x + y;

            }
            catch (Exception e)
            {
                return 100;
            }
            finally
            {
                Console.WriteLine("this is finally from sum");
            }


        }
        public void div(int a, int b)
        {
            try
            {
                int ans = a / b;
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {


            }
            finally
            {
                Console.WriteLine("this is finally block");
            }
        }
    }
}
