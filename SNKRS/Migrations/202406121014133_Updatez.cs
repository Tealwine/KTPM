namespace PortfolioWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatez : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PortfolioViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Image = c.String(nullable: false),
                        isVisible = c.Boolean(nullable: false),
                        portfolio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Portfolios", t => t.portfolio_Id)
                .Index(t => t.portfolio_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PortfolioViewModels", "portfolio_Id", "dbo.Portfolios");
            DropIndex("dbo.PortfolioViewModels", new[] { "portfolio_Id" });
            DropTable("dbo.PortfolioViewModels");
        }
    }
}
