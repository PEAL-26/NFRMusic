using System;
using System.Collections.Generic;
using System.Text;

namespace NFRMusic.Dominio.Entidades
{
   public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public abstract bool Valido();
    }
}
