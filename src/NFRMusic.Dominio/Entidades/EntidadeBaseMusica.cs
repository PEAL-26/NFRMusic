using System;
using System.Collections.Generic;
using System.Text;

namespace NFRMusic.Dominio.Entidades
{
    public class EntidadeBaseMusica : EntidadeBase
    {
        public string Titulo { get; set; }
        public const int TituloTamanhoMaximo = 50;
        public string Artista { get; set; }
        public const int ArtistaTamanhoMaximo = 50;
        public string Album { get; set; }
        public const int AlbumTamanhoMaximo = 50;
        public string Genero { get; set; }
        public const int GeneroTamanhoMaximo = 50;

        public override bool Valido()
        {
            throw new NotImplementedException();
        }
    }
}
