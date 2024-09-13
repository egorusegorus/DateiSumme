namespace DateiSumme
{
    public class Dateisumme
    {
        public double summe, ergebnis1, ergebnis2, summe1, summe2;

        public Dateisumme() { }
        public Dateisumme(double summe, double ergebnis1, double ergebnis2)
        {
            ergebnis1 = summe * 0.07;
            ergebnis2 = summe * 0.19;
            summe1 = summe + ergebnis1;
            summe2 = summe + ergebnis2;


        }


        public override string ToString()
        {
            return $"{summe} 7% {summe1} 19%{summe2}";
        }
    }

}
