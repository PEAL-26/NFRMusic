using NFRMusic.Infra.Data.Mapeamentos;

namespace NFRMusic.Infra.Data.Configuracoes
{
    public static class ConfiguracaoMapeamento
    {
        public static void AplicarConfiguracao(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusicaMap());
            modelBuilder.ApplyConfiguration(new PlayListMap());
            modelBuilder.ApplyConfiguration(new PlayListMusicaMap());
            modelBuilder.ApplyConfiguration(new ProjectoMap());
            modelBuilder.ApplyConfiguration(new ProjectoMusicaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMusicaMap());

        }
    }
}
