// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Net.NetworkInformation;
public class Program
{
  static void Energiewesen() {
    string bezeichnung;
    int id; //ushort auch möglich
    string ?kategorie = null;
    double leuchtkraft;

    string[] kategorieWesen = ["A", "B", "C"];

    bool pruef = false;

    // Eingabe:
    Console.WriteLine("1. Bezeichnung:");
    bezeichnung = Console.ReadLine();

    ResetRegister:
    Console.WriteLine("2. Registriernummer: (max. 65535)");
    id = int.Parse(Console.ReadLine());
    String idString = id.ToString();
    if (idString.Length > 5) {
      Console.WriteLine("Die Bezeichnung ist zu lang!");
      goto ResetRegister;
    }
    id += 100000;
    idString = id.ToString().Substring(1);
    
    do {
        Console.WriteLine("3. Kategorie: (A, B, C)");
        kategorie = Console.ReadLine();
        pruef = kategorieWesen.Contains(kategorie);
        if (pruef) break;
        Console.WriteLine("Kategorie nicht verfügbar!");
    } while (!pruef);
    
    Console.WriteLine("4. Leuchtkraft:");
    leuchtkraft = Math.Round(float.Parse(Console.ReadLine()),2);

    // Ausgabe:
    Console.WriteLine("Energiewesen: " + bezeichnung + " | Nr: " + idString + " | Kategorie: " + kategorie + " | Leuchtkraft: " + leuchtkraft);

  }

  static void Aufg4a() {
    double a = 1, b = 2, c = 3, r = 4; // geändert zu double um nicht bei jeder Variable (double) schreiben zu müssen
    double y = 4.0;
    
    Console.WriteLine("Aufgabe 4 a: \n");
    double d = a/b;
    Console. WriteLine("d = {0}\n", d);

    double f1 = ((a+b)/(c-y)) - a/b;
    Console.WriteLine("f1 = " + f1 + "\n");

    double f2 = (-b + Math.Sqrt(b*b - 4*a*c)) / (2*a);
    Console.WriteLine("f2 = {0}\n", f2);

    double A = Math.PI*Math.Pow(r,2);
    Console.WriteLine("A = " + A);
  }
  static void Aufg4b() {
    double x1 = 0.5, x2 = 10.5, y1 = 1, y2 = 11;
    Console.WriteLine("Aufgabe 4 b: \n");
    Console.WriteLine("Eingabe x: \n");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Eingabe y: \n");
    double y = double.Parse(Console.ReadLine());

    //x in x-Bereich?
    if (x>=x1 && x1<=x2) {
      Console.WriteLine("Der Wert x={0} liegt im Intervall (x1,x2)=({1},{2})\n", x, x1, x2);
    } else {
      Console.WriteLine("Der Wert x={0} liegt NICHT im Intervall (x1,x2)=({1},{2})\n", x, x1, x2);
    }
    
    //Punkt in Rechteck?
    if (x>=x1 && x1<=x2 && y>=y1 && y<=y2) {
      Console.WriteLine("Der Punkt (x,y)=({0},{1}) liegt im Rechteck mit den Eckpunkten (x1,y1)=[{2},{4}] und (x2,y2)=({3},{5})\n", x, y, x1, x2, y1, y2);
    } else {
      Console.WriteLine("Der Punkt (x,y)=({0},{1}) liegt NICHT im Rechteck mit den Eckpunkten (x1,y1)=[{2},{4}] und (x2,y2)=({3},{5})\n", x, y, x1, x2, y1, y2);

      if (x<=x1 && x1>=x2) {
        Console.WriteLine("Aber der Wert x={0} liegt im Intervall (x1,x2)=({1},{2})", x, x1, x2);
      } else if (y<=y2 && y>=y1) {
        Console.WriteLine("Aber der Wert y={0} liegt im Intervall (y1,y2)=({1},{2})", y, y1, y2);
      }
    }
    
    //2Punkte gleiche Koordinaten?
    Console.WriteLine("Eingabe weiterer Punkt:");
    Console.WriteLine("Eingabe Px:");
    double Px = double.Parse(Console.ReadLine());
    Console.WriteLine("Eingabe Py:");
    double Py = double.Parse(Console.ReadLine());
    if ((x==Px) && (y==Py)) {
        Console.WriteLine("Die Punkte haben die gleichen Koordinaten");
    }else{
        Console.WriteLine("Die Punkte haben NICHT die gleichen Koordinaten");
    }

  }
  static void Aufg4c() {
    int x = 0b0001_0001, y=0b1000_1000, z=0b1111;
    /*
    x & y & z,
    (x | y) & z,
    ~(x ^ y) und
    ~(x ^ y) & byte.MaxValue
    */
    
    
  }


  static void Main(string[] args)
  {
    // Print Hello World message
    //string message = "Glück auf";
    //Console.WriteLine(message + " Freiberg");
    //Energiewesen();
    //TemperatureCalculator.Program.Temperatur();
    //Aufg4a();
    //Aufg4b();
    Aufg4c();
  }
}