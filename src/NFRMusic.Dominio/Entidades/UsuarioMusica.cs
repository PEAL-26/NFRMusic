using System;
using System.Collections.Generic;
using System.Text;

namespace NFRMusic.Dominio.Entidades
{
   public  class UsuarioMusica
    {
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int MusicaId { get; set; }
        public virtual Musica Musica { get; set; }
        public bool Favorita { get; set; }
        public bool Guardada { get; set; }
        public string Localizacao { get; set; }
        
    }
}
