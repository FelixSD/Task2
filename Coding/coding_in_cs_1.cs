using System;
public class coding_in_cs_1 {
    public string Name;
    public int Nummer;
    
    public static void calc_array() {
        // int[] ia = new int[10];         // Grundtyp: int, Speicherplätze: 10
        // char[] ca = new char[30];       // Grundtyp: char, Speicherplätze: 30
        // double[] da = new double[12];   // Grundtyp: double, Speicherplätze: 12

        int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6};
        int ergebnis = ia[2] * ia[8] + ia[4];

        Console.WriteLine("Das Ergebnis der Berechnung ist " + ergebnis);
    }

    public static void special_array() {
        double pi = 3.1415;
        double euler = 2.712;
        double kepler = 8; // wollte die Zahl nicht extra nachschauen
        double[] special_numbers = {pi, euler, kepler};

        Console.WriteLine("Der spezielle Array aus unschönen zahlen enthält " + special_numbers.Length + " Einträge.");
    }

    public static void strings() {
        string a = "eins";
        string b = "zwei";
        string c = "eins";
        bool a_eq_b = (a == b);
        bool a_eq_c = (a == c);
        string meinstring = "Das ist ein String";
        char zeichen = meinstring[5];

        Console.WriteLine("Beim Vergleich der Strings a und b war das Ergebnis " + a_eq_b);
        Console.WriteLine("Beim Vergleich der Strings a und c war das Ergebnis " + a_eq_c);
        Console.WriteLine("Das 6. Zeichen meines Strings ist " + zeichen);

    }

    public static void class_parameters() {
        coding_in_cs_1 aufgabe = new coding_in_cs_1();
        aufgabe.Name = "Zweite Aufgabe";
        aufgabe.Nummer = 2;

        Console.WriteLine("Die Klassenvariable Name heisst " + aufgabe.Name + " und die Nummer lautet " + aufgabe.Nummer);
    }

    public static void if_else() {
        Console.WriteLine("Zahl(int) 1 eingeben:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Zahl(int) 2 eingeben:");
        int b = int.Parse(Console.ReadLine());

        if(a > b) {
            Console.WriteLine("a grösser b");
        } else {
            Console.WriteLine("b grösser a");
        }

        if(a > 3 && b == 6) {
            Console.WriteLine("Du hast gewonnen");
        } else if(a <= 3 && b != 6) {
            Console.WriteLine("Du hast verloren");
        }
    }

    public static void switch_case() {
        Console.WriteLine("Zahl zwischen 1 und 4 eingeben:");
        int i = int.Parse(Console.ReadLine());

        switch(i) {     // wenn ich versuche ein break weg zu lassen bekomme ich einen error (Das Steuerelement kann nicht von einer case-Bezeichnung ("case 1:") zur nächsten fortfahren.)
            case 1:
                Console.WriteLine("Du hast 1 eingegeben");
                break;
            case 2:
                Console.WriteLine("Du hast 2 eingegeben");
                break;
            case 3:
                Console.WriteLine("Du hast 3 eingegeben");
                break;
            case 4: 
                Console.WriteLine("Du hast 4 eingegeben");
                break;
            default:
                Console.WriteLine("Deine eingegebene Zahl liegt nicht zwischen 1 und 4");
                break;
        }
    }

    public static void switch_case_as_if_else() {
        Console.WriteLine("Zahl zwischen 1 und 4 eingeben:");
        int i = int.Parse(Console.ReadLine());

        if(i == 1) {
            Console.WriteLine("Du hast 1 eingegeben");
        } else if(i == 2) {
            Console.WriteLine("Du hast 2 eingegeben");
        } else if(i == 3) {
            Console.WriteLine("Du hast 3 eingegeben");
        } else if(i == 4) {
            Console.WriteLine("Du hast 4 eingegeben");
        } else {
            Console.WriteLine("Deine eingegebene Zahl liegt nicht zwischen 1 und 4");
        }
    }

    public static void while_loop() {
        int i = 1;

        while(i <= 10) {
            Console.WriteLine(i);
            i++;
        } 
    }

    public static void for_loop() {
        String[] array = {"Hier", "sehen", "wir", "einen", "Array", "von", "Strings"};

        for(int i = 0; i < 5; i++) {
            Console.WriteLine(array[i]);
        }
    }

    public static void for_as_while() {
        String[] array = {"Hier", "sehen", "wir", "einen", "Array", "von", "Strings"};
        int i = 0;

        while(i < array.Length) {
            Console.WriteLine(array[i]);
            i++;
        }
    }

    public static void foreach_loop() {
        String[] stringArray = {"Hier", "sehen", "wir", "einen", "Array", "von", "Strings"};

        foreach(String array_element in stringArray) {
            Console.WriteLine(array_element);
        }
    }

    public static void Main(String[] args) {
        calc_array();
        special_array();
        strings();
        class_parameters();
        if_else();
        switch_case();
        switch_case_as_if_else();
        while_loop();
        for_loop();
        for_as_while();
        foreach_loop();
    }
}