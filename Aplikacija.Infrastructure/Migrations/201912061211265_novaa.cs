namespace Aplikacija.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novaa : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Contractors", new[] { "Policy_ID" });
            RenameColumn(table: "dbo.Policies", name: "Policy_ID", newName: "Contractor_ID");
            AddColumn("dbo.Policies", "Moment", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contractors", "Regnumber", c => c.String());
            CreateIndex("dbo.Policies", "Contractor_ID");
            DropColumn("dbo.Contractors", "RegnumberyProperty");
            DropColumn("dbo.Contractors", "Policy_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contractors", "Policy_ID", c => c.Guid());
            AddColumn("dbo.Contractors", "RegnumberyProperty", c => c.String());
            DropIndex("dbo.Policies", new[] { "Contractor_ID" });
            DropColumn("dbo.Contractors", "Regnumber");
            DropColumn("dbo.Policies", "Moment");
            RenameColumn(table: "dbo.Policies", name: "Contractor_ID", newName: "Policy_ID");
            CreateIndex("dbo.Contractors", "Policy_ID");
        }
    }
}
