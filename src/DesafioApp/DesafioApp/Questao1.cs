using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DesafioApp
{
    public class NoArvore
    {
        public int No { get; set; }
        public int NoEsquerda { get; set; }
        public int NoDireita { get; set; }
    }

    public class ArvoreBuilder<T>
    {
        public List<NoArvore> Arvore { get; set; }
        public ArvoreBuilder()
        {
            Arvore = new List<NoArvore>();
        }

        public NoArvore AdicionarNo(int pai, int filho)
        {
            if (pai == 0 || filho == 0)
                throw new Exception(E4);

            NoArvore proximo = new NoArvore();
            proximo.No = pai;
            proximo.NoEsquerda = pai + 1;
            proximo.NoDireita = pai + 2;

            Arvore.Add(proximo);            

            return proximo;
        }

       private const string E1 = "Mais de 2 filhos";
       private const string E2 = "Ciclo presente";
       private const string E3 = "Raizes múltiplas";
       private const string E4 = "Qualquer outro erro";
    }
}
