namespace ExceptionDemo300924.How_to_Handle_Exception_in_Program
{
    internal class Employee
    {
        private int id;
        //private string name;
        public string Name { get; set; }
        public int Salary { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public void SetInfo(int id,string nm,int sal)
        {            
            this.id = id;
            Name= nm;
            Salary = sal;
        }
        public void showEmp()
        {
            Console.Write("Employee ID= "+id);
            Console.Write(" Name= " + Name);
            Console.WriteLine(" Salary= " +Salary);
        }
    }
}

