namespace NFRMusic.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public string Telefone { get; set; }
        public string? Email { get; set; }
        public string Senha { get; set; }
        public string Biografia { get; set; }
        public TipoUsuario Tipo { get; set; }

        public override bool Valido()
        {
            throw new System.NotImplementedException();
        }
    }
}
