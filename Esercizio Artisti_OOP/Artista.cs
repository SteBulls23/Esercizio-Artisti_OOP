using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Artisti_OOP
{
    // Creo la classe artista(classe base). Definisco tutti gli attributi e i metodi 'public' perchè voglio rendere il codice accessibile per tutte le classi.
    internal class Artista
    {
        // Definisco gli attributi o proprietà della classe 'Artista'.
        public string nome { get; set; } = string.Empty;
        public string cognome { get; set; } = string.Empty;
        public double costoSerata { get; set; } = 0;

        // Definisco il costruttore vuoto della classe 'Artista'.
        public Artista()
        {
            this.nome = string.Empty;
            this.cognome = string.Empty;
            this.costoSerata = 0;
        }

        // Definisco il secondo costruttore, stavolta passandogli dei parametri(overload del metodo costruttore).
        public Artista(string pNome, string pCognome, double pCostoSerata)
        {
            this.nome = pNome;
            this.cognome = pCognome;
            this.costoSerata = pCostoSerata;
        }

        // Definisco un metodo per visualizzare le caratteristiche dell'artista. Lo definisco 'virtual', così consento al metodo di essere sottoposto a override nelle classi derivate 'Musicista' e 'Cantante'.
        public virtual void presentazioneArtista() // La funzione la definisco void perchè non restituisce nulla.
        {
            Console.WriteLine("Nome artista: {0}; Cognome artista: {1}; Costo di una serata dell'artista: {2} euro.", this.nome, this.cognome, this.costoSerata);
        }
    }
}
