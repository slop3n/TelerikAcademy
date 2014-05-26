namespace Kitchen
{
    using System;
    using System.Linq;

    class RefactorStatement
    {
        const int MAX_ROW = int.MaxValue;
        const int MIN_ROW = int.MinValue;
        const int MAX_COLUMN = int.MaxValue;
        const int MIN_COLUMN = int.MinValue;

        static void Main()
        {
            var potato = new Potato();
            if (potato != null)
            {
                if (potato.IsPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
            }

            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            bool rowIsInner = (row >= MIN_ROW) && (row <= MAX_ROW);
            bool columnIsInner = (column >= MIN_COLUMN) && (column <= MAX_COLUMN);

            if (rowIsInner && columnIsInner)
            {
                VisitCell();
            }
        }

        static void Cook(Vegetable vegetable)
        {
            vegetable.IsCooked = true;
        }

        static void VisitCell()
        {
            Console.WriteLine("The cell is visited");
        }
    }
}
