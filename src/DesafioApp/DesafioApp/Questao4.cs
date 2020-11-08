using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioApp
{
    public class Questao4
    {
        /// <summary>
        /// Cria a instancia do tipo de objeto desejado utilizando reflection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T ExportarDados<T>()
        {
            T retorno = Activator.CreateInstance<T>();

            return retorno;
        }
    }
}
