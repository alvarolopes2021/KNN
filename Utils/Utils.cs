namespace KNN.Utils
{
    public static class Utils
    {
        public static List<T> Shuffle<T>(this IList<T> list)
        {

            Random random = new Random();

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return (List<T>)list;
        }

        public static int ClassifyAge(int age)
        {
            if (age < 10)
                return 0;
            else if (age >= 10 && age <= 19)
                return 1;
            else if (age >= 20 && age <= 29)
                return 2;
            else if (age >= 30 && age <= 39)
                return 3;
            else if (age >= 40 && age <= 49)
                return 4;
            else if (age >= 50 && age <= 59)
                return 5;
            else if (age >= 60 && age <= 69)
                return 6;
            else if (age >= 70 && age <= 79)
                return 7;
            else if (age >= 80 && age <= 89)
                return 8;
            else
                return 9;

        }

        public static int ClassifySize(int size)
        {
            if (size < 0)
                return 0;
            else if (size >= 0 && size <= 4)
                return 1;
            else if (size >= 5 && size <= 9)
                return 2;
            else if (size >= 10 && size <= 14)
                return 3;
            else if (size >= 15 && size <= 19)
                return 4;
            else if (size >= 20 && size <= 24)
                return 5;
            else if (size >= 25 && size <= 29)
                return 6;
            else if (size >= 30 && size <= 34)
                return 7;
            else if (size >= 35 && size <= 39)
                return 8;
            else if (size >= 40 && size <= 44)
                return 9;
            else if (size >= 45 && size <= 49)
                return 10;
            else if (size >= 50 && size <= 54)
                return 11;
            else
                return 12;
        }

        public static int ClassifyInvNodes(int invNodes)
        {
            if (invNodes < 0)
                return 0;
            else if (invNodes >= 0 && invNodes <= 2)
                return 1;
            else if (invNodes >= 3 && invNodes <= 5)
                return 2;
            else if (invNodes >= 6 && invNodes <= 8)
                return 3;
            else if (invNodes >= 9 && invNodes <= 11)
                return 4;
            else if (invNodes >= 12 && invNodes <= 14)
                return 5;
            else if (invNodes >= 15 && invNodes <= 17)
                return 6;
            else if (invNodes >= 18 && invNodes <= 20)
                return 7;
            else if (invNodes >= 21 && invNodes <= 23)
                return 8;
            else if (invNodes >= 24 && invNodes <= 26)
                return 9;
            else if (invNodes >= 27 && invNodes <= 29)
                return 10;
            else if (invNodes >= 30 && invNodes <= 32)
                return 11;
            else if (invNodes >= 33 && invNodes <= 35)
                return 12;
            else
                return 13;
        }

    }
}
