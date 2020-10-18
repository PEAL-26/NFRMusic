namespace NFRMusic.Infra.Data.Configuracoes
{
    public class ContextoDatabase
    {
        public ContextoDatabase() { }

        public ContextoDatabase(DbContextOptions<ContextoDatabase> options) : base(options)
        {

            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfiguracaoMapeamento.AplicarConfiguracao(modelBuilder);
            ConfiguracaoSeeds.AplicarConfiguracao(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=NFRMusic; Initial Catalog=IQLabsSystem; Integrated Security=True";
            return strCon;
        }
    }
}
