namespace IfStatements
{
    public static class Task8
    {
        public static int DoSomething(int i1, int i2)
        {
            if (i1 >= -4 && i1 < 9 && i2 > 5)
            {
                return i1 + i2;
            }
            else if (i1 >= -4 && i1 < 9 && i2 <= -3)
            {
                return (i1 * 2) - i2;
            }
            else if (i1 >= -4 && i1 < 9 && i2 > -3 && i2 <= 5)
            {
                return i2 - (i1 * i1);
            }
            else if (i1 < -4 && i2 >= 7)
            {
                return (i2 * 2) - i1;
            }
            else if (i1 < -4 && i2 < -5)
            {
                return i2 - i1;
            }
            else if (i1 < -4 && i2 >= -5 && i2 < 7)
            {
                return i1 - i2;
            }
            else if (i1 >= 9 && i2 >= 7)
            {
                return i1 - (i2 * i2);
            }
            else if (i1 >= 9 && i2 < -7)
            {
                return (i1 * 2) - (i2 * 2);
            }
            else
            {
                return i2 * i1;
            }
        }
    }
}
