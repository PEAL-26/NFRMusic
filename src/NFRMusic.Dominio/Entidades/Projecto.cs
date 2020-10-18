using System;
using System.Collections.Generic;
using System.Text;

namespace NFRMusic.Dominio.Entidades
{
    public class Projecto : EntidadeBaseMusica
    {
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string Tipo { get; set; }
        
        public ICollection<Musica> Musicas { get; set; }
        public override bool Valido()
        {
            throw new NotImplementedException();
        }
    }
}
