using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Artisti_OOP
{
    // Creo la classe Musicista(classe derivata) che estende la classe Artista, in quanto un musicista è anche un artista. Definisco tutti gli attributi e i metodi 'public' perchè voglio rendere il codice accessibile per tutte le classi.
    internal class Musicista : Artista
    {
        // Definisco gli attributi o proprietà della classe Musicista.
        public string strumento {  get; set; } = string.Empty;

        // Definisco il costruttore vuoto della classe Musicista.
        public Musicista()
        {
            this.strumento = string.Empty;
        }

        // Definisco il secondo costruttore, stavolta passandogli dei parametri(overload del metodo costruttore).
        public Musicista(string pNome, string pCognome, double pCostoSerata, string pStrumento) : base(pNome, pCognome, pCostoSerata)
        {
            this.strumento = pStrumento;
        }

        // Definisco un metodo per visualizzare le caratteristiche del musicista. In questo caso faccio l'override del metodo 'presentazioneArtista'.
         public override void presentazioneArtista() // La funzione la definisco void perchè non restituisce nulla.
        {
            Console.WriteLine("Nome musicista: {0}; Cognome musicista: {1}; Costo di una serata musicista: {2} euro; Strumento musicista: {3} .", this.nome, this.cognome, this.costoSerata, this.strumento);
         }

        // Definisco un metodo 'suona' che specifica che strumento musicale suona il musicista.
        public void suona() // La funzione la definisco void perchè non restituisce nulla.
        {
            Console.WriteLine("Un musicista di fama mondiale e suona: {0} .", this.strumento);
        }
    }
}
