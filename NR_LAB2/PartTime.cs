using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_LAB2
{
    public class PartTime : Employee
    {
        private double rate;
        private double hours;

        public PartTime()
        {

        }

        public PartTime(string id, string name, string address, string phone
            , long sin, string dob, string dept, double rate, double hours)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }   
        }

        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }


        public override double GetPay()
        {
            return Rate * Hours;
        }

        public override string ToString()
        {
            return base.ToString() + $", Part-time pay: {GetPay()}";
        }




    }
}
