using System;
using System.Collections.Generic;
using System.Text;

namespace NFRMusic.Dominio.Entidades
{
    public class PlayListMusica
    {
        public int PlayListId { get; set; }
        public virtual PlayList PlayList { get; set; }
        public int MusicaId { get; set; }
        public virtual Musica Musica { get; set; }
    }
}
