
using System;
class HelloWorld {
  static void Main() {
    int n = int.Parse(Console.ReadLine());
    if (check(n)){
        Console.WriteLine("YES");
    }else{
        Console.WriteLine("NO");
    }
  }
  static bool check(int n){
      if (n < 2){
          return false;
      }
      for (int i = 2; i <= Math.Sqrt(n) ; i++){
          if (n % i == 0){
              return false;
          }
      }
      return true;
  }
}