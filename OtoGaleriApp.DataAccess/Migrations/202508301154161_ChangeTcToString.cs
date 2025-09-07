namespace OtoGaleriApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTcToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kisis", "TC", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kisiler", "TC", c => c.String(nullable: false, maxLength: 11));

        }
    }
}
