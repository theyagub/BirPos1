namespace BirPos1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PendingChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationVersion",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        AppVersion = c.String(),
                        AppPath = c.String(),
                        MustUpdate = c.Boolean(nullable: false),
                        Target = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Campaign",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        GroupOrderNo = c.Int(nullable: false),
                        OrderNo = c.Int(nullable: false),
                        Name = c.String(),
                        Note = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        WorkingCount = c.Int(nullable: false),
                        ApplyDocumentTotalAmount = c.Int(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        DiscountPercentage = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        ApplyContragentType = c.Int(nullable: false),
                        CriteriaType = c.Int(nullable: false),
                        CriteriaQuantity = c.Int(nullable: false),
                        CriteriaQuantityConvertToAmount = c.Boolean(nullable: false),
                        GifType = c.Int(nullable: false),
                        GifCriteria = c.String(),
                        GifQuantity = c.Int(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.CampaignContragent",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CampaignOid = c.String(),
                        ContragentCode = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.CampaignNoList",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CampaignOid = c.String(),
                        NoCampaignOid = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Cashier",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CashierNumber = c.String(),
                        Password = c.String(),
                        CardNumber = c.String(),
                        Name = c.String(),
                        LoginUpdateContragent = c.Boolean(nullable: false),
                        LoginUpdateProduct = c.Boolean(nullable: false),
                        LoginUpdateBarcode = c.Boolean(nullable: false),
                        LoginUpdatePrice = c.Boolean(nullable: false),
                        LoginUpdateSeller = c.Boolean(nullable: false),
                        LoginUpdateCampaign = c.Boolean(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.CashierPermission",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CashierOid = c.Guid(nullable: false),
                        Permission = c.Int(nullable: false),
                        CanPermission = c.Boolean(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Cashier", t => t.CashierOid, cascadeDelete: true)
                .Index(t => t.CashierOid);
            
            CreateTable(
                "dbo.CashLoginHistory",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CashierOid = c.String(),
                        LoginType = c.Int(nullable: false),
                        IsSyncMasterApp = c.Boolean(nullable: false),
                        SyncMasterAppDate = c.DateTime(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Contragent",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        GSM = c.String(),
                        Contract = c.String(),
                        PriceTypeID = c.String(),
                        PriceTypeName = c.String(),
                        TaxIncludePrice = c.Boolean(nullable: false),
                        TaxPercentage = c.Double(nullable: false),
                        debt = c.Double(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.DisplayDocument",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        DocumentOid = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        OpenTime = c.DateTime(nullable: false),
                        CloseDate = c.DateTime(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.DocumentAuthorizedHistory",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        DocumentOid = c.Guid(nullable: false),
                        Permission = c.Int(nullable: false),
                        AuthorizedCashierOid = c.Guid(nullable: false),
                        AuthorizedCardNumber = c.String(),
                        IsSyncMasterApp = c.Boolean(nullable: false),
                        SyncMasterAppDate = c.DateTime(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.DocumentBase",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CashOid = c.String(),
                        DepartmentCode = c.String(),
                        CompanyOid = c.String(),
                        CashierOid = c.String(),
                        DeviceNumber = c.String(),
                        SellerNo = c.String(),
                        SellerName = c.String(),
                        SellerPIN = c.String(),
                        DocumentType = c.Int(nullable: false),
                        DocumentNumber = c.String(),
                        ContragentCode = c.String(),
                        Amount = c.Single(nullable: false),
                        DiscountAmount = c.Single(nullable: false),
                        GifAmount = c.Single(nullable: false),
                        TotalDiscountAmount = c.Single(nullable: false),
                        TotalAmount = c.Single(nullable: false),
                        TaxAmount = c.Single(nullable: false),
                        GrandTotalAmount = c.Single(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        CloseDate = c.DateTime(nullable: false),
                        RefernceDocumentOid = c.String(),
                        IsSyncMasterApp = c.Boolean(nullable: false),
                        SyncMasterAppDate = c.DateTime(nullable: false),
                        LastDebtInfo = c.String(),
                        IsCanceled = c.Boolean(nullable: false),
                        HfConvertSale = c.Boolean(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.DocumentDetail",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        RowNumber = c.Int(nullable: false),
                        DocumentBaseOid = c.Guid(nullable: false),
                        DocumentType = c.Int(nullable: false),
                        ProductCode = c.String(),
                        ProductBarcode = c.String(),
                        Quantity = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        PriceIncludeTax = c.Single(nullable: false),
                        Amount = c.Single(nullable: false),
                        DiscountAmount = c.Single(nullable: false),
                        GifAmount = c.Single(nullable: false),
                        TaxAmount = c.Single(nullable: false),
                        TotalAmount = c.Single(nullable: false),
                        ReturnPrice = c.Single(nullable: false),
                        DepartmentCode = c.String(),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.DocumentBase", t => t.DocumentBaseOid, cascadeDelete: true)
                .Index(t => t.DocumentBaseOid);
            
            CreateTable(
                "dbo.DocumentGifHistory",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        DocumentOid = c.String(),
                        DetailOid = c.String(),
                        CampaignOid = c.String(),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.OtpHistory",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ContragentCode = c.String(),
                        PhoneNumber = c.String(),
                        Sms = c.String(),
                        IsSyncMasterApp = c.Boolean(nullable: false),
                        SyncMasterAppDate = c.DateTime(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Unit = c.String(),
                        BrandCode = c.String(),
                        BrandName = c.String(),
                        CustomPrice = c.Boolean(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ProductBarcode",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Barcode = c.String(),
                        ProductCode = c.String(),
                        IsDecimalQuantity = c.Boolean(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ProductCustomPrice",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ProductCode = c.String(),
                        Barcode = c.String(),
                        Price = c.Double(nullable: false),
                        TaxIncludedPrice = c.Boolean(nullable: false),
                        IsDecimalQuantity = c.Boolean(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ProductExtraCode",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ProductCode = c.String(),
                        ExtraCode = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ProductPrice",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ProductCode = c.String(),
                        PriceTypeID = c.String(),
                        Price = c.Double(nullable: false),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ReportData",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Name = c.String(),
                        DocumentType = c.Int(nullable: false),
                        Data = c.String(),
                        DefaultReport = c.Binary(),
                        InputDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Seller",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Name = c.String(),
                        PIN = c.String(),
                        DepartmentCode = c.String(),
                        Department = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Oid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentDetail", "DocumentBaseOid", "dbo.DocumentBase");
            DropForeignKey("dbo.CashierPermission", "CashierOid", "dbo.Cashier");
            DropIndex("dbo.DocumentDetail", new[] { "DocumentBaseOid" });
            DropIndex("dbo.CashierPermission", new[] { "CashierOid" });
            DropTable("dbo.Seller");
            DropTable("dbo.ReportData");
            DropTable("dbo.ProductPrice");
            DropTable("dbo.ProductExtraCode");
            DropTable("dbo.ProductCustomPrice");
            DropTable("dbo.ProductBarcode");
            DropTable("dbo.Product");
            DropTable("dbo.OtpHistory");
            DropTable("dbo.DocumentGifHistory");
            DropTable("dbo.DocumentDetail");
            DropTable("dbo.DocumentBase");
            DropTable("dbo.DocumentAuthorizedHistory");
            DropTable("dbo.DisplayDocument");
            DropTable("dbo.Contragent");
            DropTable("dbo.CashLoginHistory");
            DropTable("dbo.CashierPermission");
            DropTable("dbo.Cashier");
            DropTable("dbo.CampaignNoList");
            DropTable("dbo.CampaignContragent");
            DropTable("dbo.Campaign");
            DropTable("dbo.ApplicationVersion");
        }
    }
}
