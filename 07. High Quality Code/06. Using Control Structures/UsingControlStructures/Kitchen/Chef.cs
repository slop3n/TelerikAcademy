namespace Kitchen
{
    using System;
    using System.Linq;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;
            Peel(potato);
            Peel(carrot);
            bowl = GetBowl();
            Cut(potato);
            Cut(carrot);
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            var bowl = new Bowl();
            return bowl;
        }

        private Carrot GetCarrot()
        {
            var carrot = new Carrot();
            return carrot;
        }

        private Potato GetPotato()
        {
            var potato = new Potato();
            return potato;
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.IsCut = true;
        }

        static void Main()
        {
            var chef = new Chef();
            chef.Cook();
        }
    }
}
