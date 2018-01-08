using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.ViewModel
{
    public abstract class StaffMember
    {
        protected int age;
        public int getAge() { return age; }
        public void setAge(int newAge) { age = newAge; }

        protected int salary;
        public int getSalary() { return salary; }
        public void setSalary(int newSalary) { salary = newSalary; }
    }
}
