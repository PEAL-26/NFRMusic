namespace NFRMusic.Dominio.Entidades
{
    public class ProjectoMusica
    {
        public int ProjectoId { get; set; }
        public virtual Projecto Projecto { get; set; }
        public int MusicaId { get; set; }
        public virtual Musica Musica { get; set; }
    }
}
