namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new();
            Console.WriteLine(focus.HangiMarkaninAraci());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StardartRengiNe());

            Civic civic = new();
            Console.WriteLine(civic.HangiMarkaninAraci());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StardartRengiNe());
            
        }
    }
}