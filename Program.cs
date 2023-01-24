using System.Collections;

namespace Angebotsvergleich {
    public class Program {

        ArrayList myList = new ArrayList();

        static void Main() {
            Program prog = new Program();
            prog.input();
        }

        public void berechneKosten() {
            double listeneinkaufspreis, bezugskosten, lieferrabatt, lieferskonto;
            double zieleinkaufspreis, bareinkaufspreis, bezugspreis;

            // Eingabe Werte
            System.Console.WriteLine("Geben Sie den Listeneinkaufspreis ein!");
            listeneinkaufspreis = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Geben Sie die Bezugskosten ein!");
            bezugskosten = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Geben Sie den Lieferrabatt ein!");
            lieferrabatt = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Geben Sie den Lieferskonto ein!");
            lieferskonto = Convert.ToDouble(Console.ReadLine());

            // Berechnung Bezugspreis
            lieferrabatt = ((lieferrabatt * listeneinkaufspreis) / 100);

            zieleinkaufspreis = listeneinkaufspreis - lieferrabatt;

            lieferskonto = ((lieferskonto * zieleinkaufspreis) / 100);

            bareinkaufspreis = zieleinkaufspreis - lieferskonto;

            bezugspreis = bareinkaufspreis + bezugskosten;

            myList.Add(bezugspreis);
        }

        public void input() {
            for (int i = 0; i < 5; i++) {
                System.Console.WriteLine("Welche Option möchten Sie wählen?");
                System.Console.WriteLine("---------------------------------");
                System.Console.WriteLine("1. Angebot hinzufügen.");
                System.Console.WriteLine("2. Angebote vergleichen.");
                System.Console.WriteLine("3. Programm beenden.");
                System.Console.WriteLine("");
                int j = Convert.ToInt32(Console.ReadLine());
            
                switch(j) {
                    case 1:
                        berechneKosten();
                        break;
                    case 2:
                        outputKosten();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
        }

        public void outputKosten() {
            foreach (double i in myList) {
                System.Console.WriteLine(i);
                System.Console.WriteLine("");
            }

            double bestOffer = 0;
            int angebot = 1;
            for (int i = 0; i < myList.Count; i++) {
                if (i == 0) {
                    bestOffer = (double)myList[i];
                }
                if (bestOffer > (double)myList[i]) {
                    bestOffer = (double)myList[i];
                    angebot = i;
                }
            }
            System.Console.WriteLine("Das Beste Angebot ist Angebot " + angebot + " mit einem Bezugspreis von: " + bestOffer);
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
    }
}