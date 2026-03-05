namespace APIPractice2.Models
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public int EmpID { get; set; }  
        public Employee Employee { get; set; }
    }
}
