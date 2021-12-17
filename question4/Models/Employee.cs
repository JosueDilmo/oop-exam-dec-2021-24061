namespace question4.Models
{
    public class Employee : Person
    {
        public string PPS { get; set; }
        public Employee(string pps)
        {
            PPS = pps;
        }

     
    }
}
