namespace Aplikacija.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovaMigracija : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Contractors", new[] { "Policy_ID" });
            DropColumn("dbo.Contractors", "ID");
            RenameColumn(table: "dbo.Contractors", name: "Policy_ID", newName: "ID");
            DropPrimaryKey("dbo.Contractors");
            AddColumn("dbo.Policies", "Moment", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contractors", "Regnumber", c => c.String());
            AlterColumn("dbo.Contractors", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Contractors", "ID");
            CreateIndex("dbo.Contractors", "ID");
            DropColumn("dbo.Contractors", "RegnumberyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contractors", "RegnumberyProperty", c => c.String());
            DropIndex("dbo.Contractors", new[] { "ID" });
            DropPrimaryKey("dbo.Contractors");
            AlterColumn("dbo.Contractors", "ID", c => c.Guid());
            DropColumn("dbo.Contractors", "Regnumber");
            DropColumn("dbo.Policies", "Moment");
            AddPrimaryKey("dboC.ontractors", "ID");
            RenameColumn(table: "dbo.Contractors", name: "ID", newName: "Policy_ID");
            AddColumn("dbo.Contractors", "ID", c => c.Guid(nullable: false));
            CreateIndex("dbo.Contractors", "Policy_ID");
        }
    }
}
