using System.Collections.Generic;

namespace MusicApp
{
    public partial class Form1
    {
        class GenereMusica
        {
            public string Sigla { get; set; }
            public string NomeGenere { get; set; }
            List<Cantante> cantanti;

            public GenereMusica(string sigla, string genre)
            {
                Sigla = sigla;
                NomeGenere = genre;
            }
        }
    }
}
