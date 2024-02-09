/* Esercizio: crea tre classi: una classe base 'Artista' e due classi derivate(la classe 'Musicista e la classe 'Cantante'. 
 Nel programma principale istanzia i 3 oggetti e richiama i metodi delle 3 classi.*/
namespace Esercizio_Artisti_OOP
{
    internal class Concerto
    {
        static void Main(string[] args)
        {
            // Creo un oggetto 'Artista', chiamato 'artista' e utilizzo il costruttore vuoto per inizializzare l'oggetto. Per creare l'oggetto utilizzo la parola chiave 'new'.
            Artista artista = new Artista();
            Console.WriteLine("Scrivi il nome dell'artista!");
            artista.nome = Console.ReadLine();
            Console.WriteLine("scrivi il cognome dell'artista!");
            artista.cognome = Console.ReadLine();
            Console.WriteLine("Scrivi il costo di una serata dell'artista!");
            artista.costoSerata = Convert.ToDouble(Console.ReadLine());

            artista.presentazioneArtista(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'presentazioneArtista' per visualizzare le caratteristiche di un artista.

            // Inizializzando un oggetto con il costruttore vuoto, l'utente è libero di cambiare il valore di un attributo ogni volta che esegue il programma.

            // Creo un oggetto 'Musicista', chiamato 'musicista' e utilizzo il costruttore vuoto per inizializzare l'oggetto. Per creare l'oggetto utilizzo la parola chiave 'new'.
            Musicista musicista = new Musicista();
            Console.WriteLine("Scrivi il nome del musicista!");
            musicista.nome = Console.ReadLine();
            Console.WriteLine("scrivi il cognome del musicista!");
            musicista.cognome = Console.ReadLine();
            Console.WriteLine("Scrivi il costo di una serata del musicista!");
            musicista.costoSerata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Scrivi che strumento musicale suone il musicista!");
            musicista.strumento = Console.ReadLine();

            musicista.presentazioneArtista(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'presentazioneArtista' per visualizzare le caratteristiche di un musicista.

            musicista.suona(); // Attraverso questa sintassi chiamo ed eseguo il metodo suona che specifica che strumento musicale suona il musicista.

            // Creo un oggetto 'Cantante', chiamato 'cantante' e utilizzo il costruttore vuoto per inizializzare l'oggetto. Per creare l'oggetto utilizzo la parola chiave 'new'.
            Cantante cantante = new Cantante();
            Console.WriteLine("Scrivi il nome del cantante!");
            cantante.nome = Console.ReadLine();
            Console.WriteLine("scrivi il cognome del cantante!");
            cantante.cognome = Console.ReadLine();
            Console.WriteLine("Scrivi il costo di una serata del cantante!");
            cantante.costoSerata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Scrivi a che genere musicale appartiene il cantante!");
            cantante.genereMusicale = Console.ReadLine();

            cantante.presentazioneArtista(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'presentazioneArtista' per visualizzare le caratteristiche di un cantante.

            cantante.canta(); // Attraverso questa sintassi chiamo ed eseguo il metodo canta che specifica a che genere musicale appartiene il cantante.

            Console.WriteLine("PROGRAMMA TERMINATO");
        }
    }
}

// Esercizio terminato! Ora puoi eseguire il programma.
