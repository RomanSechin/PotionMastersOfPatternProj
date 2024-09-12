internal class Program
{
    private static void Main(string[] args)
    {
        public Func<int, bool> Delegat;
    Console.WriteLine("Sieve filter");
        string line = "";
        while(((line = Console.ReadLine()) == "1" || line == "2" || line == "3") == false)
        Console.WriteLint("Pick the filter:\n(1) returns true for even numbers\n" +
            "(2) returns true for positive numbers\n(3) returns true for multiples of 10");
        
        switch(line){
            "1": Delegat = IsEven; break;
            "2": Delegat = IsPositive; break;
            "3": Delegat = IsMultipleOfTen; break;
        default: break;
        }
        Sieve sieve = new Sieve(Delegat);
        while (int.TryParse(Console.ReadLine(), int out num) == true) {
            Console.WriteLine($"filter {line} - result {sieve.Delegat.Invoke(num)}";            
        }
    }
}

public class Sieve {
    public Func<int, bool> Delegat;
    public bool IsGood(int number) {
        return Delegat.Invoke(number);
    }
    public Sieve(Func<int, bool> deleg) {
        Delegat += deleg;
    }
    public bool IsEven(int number) {
        return number % 2 == 0;
    }
    public bool IsPositive(int number) { 
        return number > 0;
    }
    public bool IsMultipleOfTen(int number) {
        return number % 10 == 0;
    }
}