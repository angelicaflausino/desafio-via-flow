using System;
using System.Reflection;

namespace DesafioApp
{
    /// <summary>
    /// Exemplificando o uso de Reflaction
    /// </summary>
    public class Questao2
    {
        public string Titulo { get; set; }
        public string Resposta { get; set; }

        /// <summary>
        /// Retornar o Tipo do Classe Questao2
        /// </summary>
        public Type ObterTipoClasse => this.GetType();

        /// <summary>
        /// Instanciar um objeto do tipo da classe Questao2 via reflection
        /// </summary>
        /// <returns></returns>
        public object InstanciarObjeto()
        {
            var questao2 = Activator.CreateInstance(typeof(Questao2));

            return questao2;
        }

        /// <summary>
        /// Retorna as informações de Assembly da classe Questao2
        /// </summary>
        public Assembly ObterInformacoesDeAssembly => typeof(Questao2).Assembly;
    }
}
