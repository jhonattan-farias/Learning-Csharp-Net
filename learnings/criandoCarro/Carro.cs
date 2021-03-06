namespace criandoCarro
{
    public class Carro
    {
        public string model;
        public int year;
        public float price;

        public static int registeresCars = 0;

            public Carro(string aModel,int aYear, float aPrice)
            {
                model = aModel;
                year = aYear;
                price = aPrice;

                registeresCars++;
            }
    }
}