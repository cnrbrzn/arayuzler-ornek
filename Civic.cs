namespace arayuzler_ornek{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StardartRengiNe()
        {
            return Renk.Gri;
        }
    }
}