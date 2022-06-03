
namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {

        public int Id { get; set; }

        public string Nome { get; set; }
        public string Descrizione { get; set; }

        public string Foto { get; set; }

        public double Prezzo { get; set; }

        public Pizza(int id ,string nome, string descrizione, string foto, double prezzo)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione; 
            Foto = foto;
            Prezzo = prezzo;
           
        }
    }
}