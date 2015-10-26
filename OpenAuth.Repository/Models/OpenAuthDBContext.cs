using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using OpenAuth.Domain;
using OpenAuth.Repository.Models.Mapping;

namespace OpenAuth.Repository.Models
{
    public partial class OpenAuthDBContext : DbContext
    {
        static OpenAuthDBContext()
        {
            Database.SetInitializer<OpenAuthDBContext>(null);
        }

        public OpenAuthDBContext()
            : base("Name=OpenAuthDBContext")
        {
        }

        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleRole> ModuleRoles { get; set; }
        public DbSet<Org> Orgs { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageElement> PageElements { get; set; }
        public DbSet<PageElementGrant> PageElementGrants { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCfg> UserCfgs { get; set; }
        public DbSet<UserExt> UserExts { get; set; }
        public DbSet<UserModule> UserModules { get; set; }
        public DbSet<UserOrg> UserOrgs { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ModuleMap());
            modelBuilder.Configurations.Add(new ModuleRoleMap());
            modelBuilder.Configurations.Add(new OrgMap());
            modelBuilder.Configurations.Add(new PageMap());
            modelBuilder.Configurations.Add(new PageElementMap());
            modelBuilder.Configurations.Add(new PageElementGrantMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserCfgMap());
            modelBuilder.Configurations.Add(new UserExtMap());
            modelBuilder.Configurations.Add(new UserModuleMap());
            modelBuilder.Configurations.Add(new UserOrgMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
        }
    }
}
