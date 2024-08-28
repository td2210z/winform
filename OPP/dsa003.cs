using System;

class Program {
  static void Main() {
    long n = long.Parse(Console.ReadLine());
    primeFactorization(n);
  }

  static void primeFactorization(long n) {
    for (long i = 2; i <= Math.Sqrt(n); i++) {
      if (n % i == 0) {
        int cnt = 0;
        while (n % i == 0) {
          cnt++;
          n /= i;
        }
        Console.Write(i);
        if (cnt > 1) {
          Console.Write("^" + cnt);
        }
        Console.Write(" * ");
      }
    }
    if (n > 1) {
      Console.Write(n);
    }
  }
}
