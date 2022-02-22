namespace MusicApp
{
    public partial class Form1
    {
        class Canzone
        {
            public int Id { get; set; }
            public string NomeCanzone { get; set; }
            public string AnnoProduzione { get; set; }

            public Canzone(int id, string name, string year)
            {
                Id = id;
                NomeCanzone = name;
                AnnoProduzione = year;
            }
        }
    }
}
