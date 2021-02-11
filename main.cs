using System;

class MainClass {
  public static void Main (string[] args) {

    char letra;

    Console.WriteLine ("Letras de la A-Z: ");

    for (letra = 'Z'; letra >= 'A'; letra--)

    Console.Write ("{0}", letra);

  

    Console.ReadKey();

  }
}