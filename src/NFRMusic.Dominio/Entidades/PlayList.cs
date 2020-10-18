using System;
using System.Collections.Generic;
using System.Text;

namespace NFRMusic.Dominio.Entidades
{
    public class PlayList : EntidadeBase
    {
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string Nome { get; set; }

        public ICollection<Musica> Musicas { get; set; }
        
        public override bool Valido()
        {
            throw new NotImplementedException();
        }
    }
}
