using System.Collections.Generic;

namespace MusicApp
{
    public partial class Form1
    {
        class Cantante
        {
            public int Id { get; set; }
            public string NomeCompleto { get; set; }
            public string Nomearte { get; set; }
            public string Nazione { get; set; }

            List<Canzone> canzoni;

            public Cantante(int id, string name, string artname, string nation)
            {
                Id = id;
                NomeCompleto = name;
                Nomearte = artname;
                Nazione = nation;
                canzoni = new List<Canzone>();
            }
        }
    }
}
