using System;


class Program {
  public static void Main (string[] args) {
    int inches;
    const double constcentimeters = 2.54;
    Console.WriteLine ("Enter desired inches for conversion");
    inches = Convert.ToInt32(Console.ReadLine());
    double centimeters = inches * constcentimeters;
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
  }
}