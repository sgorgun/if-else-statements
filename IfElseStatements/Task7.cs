namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            int result = 0;

            if (b)
            {
                if (i < -5 || i >= 5)
                {
                    return i + 10;
                }
                else
                {
                    if (i >= -5 && i < 5)
                    {
                        return 10 - (i * i);
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            else
            {
                if (i <= -7 || i > 4)
                {
                    return i - 100;
                }
                else
                {
                    if (i > -7 && i <= 4)
                    {
                        return 10 - i;
                    }
                    else
                    {
                        return result;
                    }
                }
            }
        }
    }
}
