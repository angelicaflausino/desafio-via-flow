using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioApp
{
    public class Questao3<T>
    {
        /// <summary>
        /// Lista Genérica que aceita qualquer tipo classe
        /// </summary>
        public List<T> ListaGenericaDoTipoT { get; set; }

        /// <summary>
        /// Lista Enumerada genérica que aceita qualquer tipo de classe
        /// </summary>
        public IEnumerable<T> ListaEnumeradaGenerica { get; set; }

        /// <summary>
        /// Uma coleção do objeto que for passado para a propriedade
        /// </summary>
        public ICollection<T> ColecaoDeObjetosDoTipoT { get; set; }
    }
}
