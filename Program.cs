namespace Zusammenfassung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primitive Datentypen:
            /*
             * void : gar kein Datentyp
             * int : ganzzahliger Datentyp
             * float : "kommazahlen"
             * bool : Wahrheitswert (entweder "true" oder "false")
             * char : einzelnes Zeichen bzw. Buchstabe
             * string : Eine Zeichenkette .. "Array aus Char"
             * double ... decimal ... et cetera ...
             */

            //Variablen (Daten benennen innerhalb des Scopes -> { } )
            //Deklarieren
            int nummer1;
            //Initialisieren
            nummer1 = 6;

            //Deklarieren und Initialisieren
            int nummer2 = 5;
            string myName = "Nicolas";

            //Variablen kann man nur nutzen, wenn sie auch initialisert sind.


            //Arrays:               index  0         1            2  
            int[] telefonBuch = { 022156485, 022178548, 02214555 }; //Eine feste Sammlung an int
            //Jedes Element in der Sammlung kann mit einem INDEX angesprochen werden
            Console.WriteLine(telefonBuch[0]); //Output: 022156485

            //Ausdrücke: Zuweisungen, Post-Inkrement, etc.

            //Jeder Ausdruck wird mit einem Semikolon ";" abgeschlossen (Expression)
            nummer2 = 10; //Zuweisung über direkte Eingabe
            nummer2 = nummer1;  //Zuweisung über Variable
            nummer2++; //Post-Inkrement (Zahl wird um 1 erhöht)
            ++nummer2; //Pre-Inkrement (Zahl wird bevor sie genutzt wird um 1 erhöht)
            int nummer3; //Ausdruck für Variablen deklaration
            nummer3 = telefonBuch[0]; //Nummer3 ist nun Telefonnummer Index 0


            //Anweisungen:
            //Schleifen
            //for-Schleife:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Forschleife für jedes Element aus dem Telefonbuch Array
            for (int i = 0; i < telefonBuch.Length; i++)
            {
                Console.WriteLine(telefonBuch[i]);
            }

            //while Schleife
            bool isTrue = true;
            while(isTrue)
            {
                Console.WriteLine("Die Condition war true");
                isTrue = false;
            }

            //do-while : Führt den Codeblock einmal aus und überprüft dann, ob die Condition true ist
            do
            {
                Console.WriteLine("Die Condition ist " + isTrue + ", aber Console.WriteLine wird so oder so ausgeführt!");
            } while (isTrue); //IsTrue ist false


            //If-else
            bool b = nummer1 > nummer2;
            if (b)           //"Wenn die Condition TRUE ist, dann..."
            {
                Console.WriteLine("Nummer1 war größer");
            }
            else            //"Sonst..."
            {
                Console.WriteLine("Nummer1 war kleiner");
            }

            if (nummer1 > nummer2) //andere Schreibweise, ohne Bool variable zu deklarieren
            {
                Console.WriteLine("Nummer1 war größer");
            }
            else if (nummer1 == nummer2) //Sonst, wenn diese Condition TRUE ist
            {
                Console.WriteLine("Die beiden Zahlen sind gleich groß");
            }

            //switch-case : eine andere Schreibweise für ein if-else if

            int nummer4 = 2;

            switch (nummer4)
            {
                case 0: //Der Fall, wenn die Zahl 0 ist   -> if (nummer4 == 0)
                    Console.WriteLine("Die Zahl war 0");
                    break;
                case 1: //-> else if (nummer4 == 1)
                    Console.WriteLine("Die Zahl war 1");
                    break;
                case 2: // -> else if (nummer4 == 2)
                    Console.WriteLine("Die Zahl war 2");
                    break;
                default: //Der Fall, den wir selbst nicht deklariert haben    -> else
                    Console.WriteLine("Die Zahl war weder 0, noch 1, noch 2");
                    break;
            }

            //Methoden aufrufen
            MyMethod();
            //Argumente übergeben
            MyParameterMethod(nummer2);
            MyReturnValueMethod(nummer2); //Rückgabewert nicht nutzen bedeutet: Variable nummer2 ändert sich nicht
            Console.WriteLine("Rückgabewert wurde nicht zugewiesen: " + nummer2);
            nummer2 = MyReturnValueMethod(nummer2); //Rückgabewert auf Variable zuweisen
            Console.WriteLine("Rückgabewert wurde zugewiesen: " + nummer2);
        
        } //<-Ende des Scopes für die Main-Methode


        //Methoden deklarieren und definieren
               //Rückgabewert: Was ist das ergebnis meiner Methode
               //Methodenname
               //Die Parameterliste (): Was braucht meine Methode, um korrekt zu funktionieren
        static void MyMethod()
        {
            Console.WriteLine("Hallo, ich bin eine Methode, die keine Parameter hat und nichts zurückgibt");
        }

        static void MyParameterMethod(int _a)
        {
            Console.WriteLine("Hallo, ich bin eine Methode und der int, den du mir gegeben hast lautet:" + _a);
        }

        static int MyReturnValueMethod(int _a)
        {
            Console.WriteLine("Hallo ich bin eine Methode und dein int " + _a + " wird jetzt um 1 erhöht");
            _a++;
            return _a; //gibt den neuen Wert für _a zurück an den Code, den die Methode ausgeführt hat
        }
    }
}
