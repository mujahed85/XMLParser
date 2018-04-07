using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            EntitiesContext objEntitiesContext = new EntitiesContext();
            DepartmentMaster objDepartmentMaster = new DepartmentMaster();
            objDepartmentMaster.Code = "222";
            objDepartmentMaster.Name= "CS";
            objDepartmentMaster.DepartmentId= 22;

            //EmployeeMaster objEmployeeMaster = new EmployeeMaster();
            //objEmployeeMaster.Code = "1001";
            //objEmployeeMaster.Name = "Emp1";
            //objEmployeeMaster.EmployeeId = 101;
            //objEmployeeMaster.Department= objDepartmentMaster;

            //objEntitiesContext.Employees.Add(objEmployeeMaster);
            objEntitiesContext.Departments.Add(objDepartmentMaster);
            objEntitiesContext.SaveChanges();
        }
    }
}
