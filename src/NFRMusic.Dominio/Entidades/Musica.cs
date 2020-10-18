using System;
namespace NFRMusic.Dominio.Entidades
{
    public class Musica : EntidadeBaseMusica
    {


        public int AnoLancamento { get; set; }
        public int NumeroReproducao { get; set; }
        public string Capa { get; set; }
        public string Ficheiro { get; set; }
        public DateTime DataInsersao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public override bool Valido()
        {
            throw new NotImplementedException();
        }
    }
}
