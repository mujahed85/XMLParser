namespace ConsoleApplication1.EntitiesMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentMasters",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.EmployeeMasters",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.DepartmentMasters", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateStoredProcedure(
                "dbo.InsertEmployee",
                p => new
                    {
                        Code = p.String(),
                        Name = p.String(),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[EmployeeMasters]([Code], [Name], [DepartmentId])
                      VALUES (@Code, @Name, @DepartmentId)
                      
                      DECLARE @EmployeeId int
                      SELECT @EmployeeId = [EmployeeId]
                      FROM [dbo].[EmployeeMasters]
                      WHERE @@ROWCOUNT > 0 AND [EmployeeId] = scope_identity()
                      
                      SELECT t0.[EmployeeId]
                      FROM [dbo].[EmployeeMasters] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[EmployeeId] = @EmployeeId"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateEmployee",
                p => new
                    {
                        EmployeeId = p.Int(),
                        Code = p.String(),
                        Name = p.String(),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[EmployeeMasters]
                      SET [Code] = @Code, [Name] = @Name, [DepartmentId] = @DepartmentId
                      WHERE ([EmployeeId] = @EmployeeId)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteEmployee",
                p => new
                    {
                        EmployeeId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[EmployeeMasters]
                      WHERE ([EmployeeId] = @EmployeeId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteEmployee");
            DropStoredProcedure("dbo.UpdateEmployee");
            DropStoredProcedure("dbo.InsertEmployee");
            DropForeignKey("dbo.EmployeeMasters", "DepartmentId", "dbo.DepartmentMasters");
            DropIndex("dbo.EmployeeMasters", new[] { "DepartmentId" });
            DropTable("dbo.EmployeeMasters");
            DropTable("dbo.DepartmentMasters");
        }
    }
}
