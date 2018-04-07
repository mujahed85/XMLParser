using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DepartmentMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<EmployeeMaster> Employees { get; set; }
    }
    public class EmployeeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentMaster Department { get; set; }
    }
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("name=Entities")
        {

        }
        public DbSet<DepartmentMaster> Departments { get; set; }
        public DbSet<EmployeeMaster> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeMaster>()
                .MapToStoredProcedures(s => s.Insert(u => u.HasName("InsertEmployee", "dbo"))
                                                .Update(u => u.HasName("UpdateEmployee", "dbo"))
                                                .Delete(u => u.HasName("DeleteEmployee", "dbo"))
                );
        }
    }
}
