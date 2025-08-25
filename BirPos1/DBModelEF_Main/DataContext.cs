using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    public class DataContext : DbContext
    {
        public DataContext() : base(services.GetConnectionString())
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<ApplicationVersion> ApplicationVersion { get; set; }
        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<CampaignContragent> CampaignContragent { get; set; }
        public DbSet<CampaignNoList> CampaignNoList { get; set; }
        public DbSet<Cashier> Cashier { get; set; }
        public DbSet<CashierPermission> CashierPermission { get; set; }
        public DbSet<CashLoginHistory> CashLoginHistory { get; set; }
        public DbSet<Contragent> Contragent { get; set; }
        public DbSet<DisplayDocument> DisplayDocument { get; set; }
        public DbSet<DocumentAuthorizedHistory> DocumentAuthorizedHistory { get; set; }
        public DbSet<DocumentBase> DocumentBase { get; set; }
        public DbSet<DocumentDetail> DocumentDetail { get; set; }
        public DbSet<DocumentGifHistory> DocumentGifHistory { get; set; }
        public DbSet<OtpHistory> OtpHistory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductBarcode> ProductBarcode { get; set; }
        public DbSet<ProductCustomPrice> ProductCustomPrice { get; set; }
        public DbSet<ProductExtraCode> ProductExtraCode { get; set; }
        public DbSet<ProductPrice> ProductPrice { get; set; }
        public DbSet<ReportData> ReportData { get; set; }
        public DbSet<Seller> Seller { get; set; }

    }
}
