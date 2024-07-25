namespace Demo
{
    internal class Employee : IComparable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public int CompareTo(object? obj)
        {
            #region using is operator
            if (obj is Employee emp) // rtue if obj is employee or a child of employee or null
            {
                if (emp is null)
                    throw new NullReferenceException();
                if (ID > emp.ID)
                    return 1;
                else
                    return -1;
            }
            #endregion

            #region using as operator
            Employee? emp01 = obj as Employee; //true only if obj is employee
            if (emp01 is null)
                throw new NullReferenceException();
            if (ID > emp01.ID)
                return 1;
            else
                return -1;
            #endregion
        }
    }
}
