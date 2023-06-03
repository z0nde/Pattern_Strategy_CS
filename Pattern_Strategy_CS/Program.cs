using Pattern_Strategy_CS;

class Program
{
    public static void Main()
    {
        Car TOYOTA = new Car();
        TOYOTA.DoCar(new SwapV8());
        Car NISSAN = new Car();
        NISSAN.DoCar(new SwapV6());
    }
}