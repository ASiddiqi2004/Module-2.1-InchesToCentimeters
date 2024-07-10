using System;


class Program {
  public static void Main (string[] args) {
    int inches = 3;
    const double constcentimeters = 2.54;
    double centimeters = inches * constcentimeters;
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
  }
}