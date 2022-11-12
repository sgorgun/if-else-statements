namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething1(bool b1, bool b2, bool b3, bool b4)
        {
            int result = 0;

            if (b1)
            {
                if (b2)
                {
                    return 1;
                }
                else
                {
                    if (b3)
                    {
                        return 2;
                    }
                    else
                    {
                        if (b4)
                        {
                            return 3;
                        }
                        else
                        {
                            return result;
                        }
                    }
                }
            }
            else
            {
                if (b3)
                {
                    if (!b4)
                    {
                        if (b2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                    else
                    {
                        if (!b2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
                else
                {
                    if (b2)
                    {
                        if (!b4)
                        {
                            return 8;
                        }
                        else
                        {
                            return 9;
                        }
                    }
                    else
                    {
                        if (b4)
                        {
                            return 10;
                        }
                        else
                        {
                            return 11;
                        }
                    }
                }
            }
        }

        public static int DoSomething2(bool b1, bool b2, bool b3, bool b4)
        {
            int result = 0;

            if (b1 && b2)
            {
                return 1;
            }
            else if (b1 && b3)
            {
                return 2;
            }
            else if (b1 && b4)
            {
                return 3;
            }
            else if (!b1 && b3 && !b4 && b2)
            {
                return 4;
            }
            else if (!b1 && b3 && !b4 && !b2)
            {
                return 5;
            }
            else if (!b1 && b3 && b4 && !b2)
            {
                return 6;
            }
            else if (!b1 && b3 && b4 && b2)
            {
                return 7;
            }
            else if (!b1 && !b3 && b2 && !b4)
            {
                return 8;
            }
            else if (!b1 && !b3 && b2 && b4)
            {
                return 9;
            }
            else if (!b1 && !b3 && !b2 && b4)
            {
                return 10;
            }
            else if (!b1 && !b3 && !b2 && !b4)
            {
                return 11;
            }
            else
            {
                return result;
            }
        }
    }
}
