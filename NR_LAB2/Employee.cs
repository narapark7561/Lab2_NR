﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_LAB2
{
    public class Employee
    {
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;
        private string dob;
        private string dept;

        public Employee()
        {

        }

        public Employee(string id, string name, string address,
            string phone, long sin, string dob, string dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public long Sin
        {
            get { return sin; }
            set { sin = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public virtual double GetPay()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Address: {Address}, Phone: {Phone}, SIN: {Sin}, DOB: {Dob}, Department: {Dept}";
        }

    }
}
