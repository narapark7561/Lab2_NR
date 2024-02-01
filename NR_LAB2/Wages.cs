using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_LAB2
{
    public class Wages : Employee
    {
        private double rate { get; set; }
        private double hours { get; set; }

        public Wages()
        {

        }

        public Wages(string id, string name, string address, string phone,
            long sin, string dob, string dept, double rate, double hours)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
            this.Rate = rate;
            this.Hours = hours;
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
            double overtime;
            double regularPay;
           

            if (Hours > 40)
            {
                overtime = (Hours - 40) * (Rate * 1.5);

                regularPay = 40 * Rate;
            }

            else
            {
                overtime = 0;
                regularPay = Hours * Rate;
            }

            return regularPay + overtime;
        }

        public override string ToString()
        {
            return base.ToString() + $", Wages: {GetPay()}";
        }

    }
   }
