using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_LAB2
{
    public class Salaried : Employee
    {
        private double salary { get; set; }

        public Salaried()
        {

        }

        public Salaried(string id, string name, string address, 
            string phone, long sin, string dob, string dept, double salary) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
            this.Salary = salary;
        }


        public double Salary
        {
            get { return salary;}
            set { salary = value;}
        }

        public override double GetPay()
        {
            return Salary;
        }


        public override string ToString() 
        {
            return base.ToString() + $", Salary: {Salary}";
        }



    }
}
