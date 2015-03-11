using System.Data.Entity;
using WebASPMVC_BS.Models;

namespace WebASPMVC_BS.FirstDBModel
{
    public class Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<WebASPMVC_BS.FirstDBModel.Context>());

        public Context() : base("name=FirstDBEntities")
        {
        }

        public DbSet<TRACK> TRACKs { get; set; }
        public DbSet<USER> USERs { get; set; }
        public DbSet<ITEM> ITEMs { get; set; }

        public DbSet<SWAP> SWAPs { get; set; }

    }
}
