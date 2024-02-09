using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Artisti_OOP
{
    // Creo la classe Cantante(classe derivata) che estende la classe Artista, in quanto un cantante è anche un artista. Definisco tutti gli attributi e i metodi 'public' perchè voglio rendere il codice accessibile per tutte le classi.
    internal class Cantante : Artista
    {
        // Definisco gli attributi o proprietà della classe Cantante.
        public string genereMusicale { get; set; } = string.Empty;

        // Definisco il costruttore vuoto della classe Musicista.
        public Cantante()
        {
            this.genereMusicale = string.Empty;
        }

        // Definisco il secondo costruttore, stavolta passandogli dei parametri(overload del metodo costruttore).
        public Cantante(string pNome, string pCognome, int pCostoSerata, string pGenereMusicale) : base(pNome, pCognome, pCostoSerata)
        {
            this.genereMusicale = pGenereMusicale;
        }

        // Definisco un metodo per visualizzare le caratteristiche del cantante. In questo caso faccio l'override del metodo 'presentazioneArtista'.
        public override void presentazioneArtista() // La funzione la definisco void perchè non restituisce nulla.
        {
            Console.WriteLine("Nome cantante: {0}; Cognome cantante: {1}; Costo di una serata cantante: {2} euro; Genere musicale cantante: {3} .", this.nome, this.cognome, this.costoSerata, this.genereMusicale);
        }

        // Definisco un metodo 'canta' che specifica a che genere musicale appartiene il cantante.
        public void canta() // La funzione la definisco void perchè non restituisce nulla.
        {
            Console.WriteLine("Un cantante di fama mondiale e appartiene al genere: {0} .", this.genereMusicale);
        }
    }
}
