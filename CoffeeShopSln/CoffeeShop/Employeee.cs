using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Employeee : Person
    {
        private int e_Id;
        public int E_Id { get; set; }
        private DateTime dob;
        public DateTime Dob { get; set; }
        private double salary;
        public double Salary { get; set; }
        private DateTime joindate;
        public DateTime Joindate { get; set; }
        private Department dep;
        public Department Dep { get; set; }
    }
}