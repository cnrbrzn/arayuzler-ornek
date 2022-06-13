namespace arayuzler_ornek{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StardartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}