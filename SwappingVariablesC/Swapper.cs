namespace SwappingVariablesC;

public static class Swapper
{
    public static (int, int) Vanilla(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;

        return (a, b);
    }

    public static (int, int) AdditionAndSubtraction(int a, int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;

        return (a, b);
    }

    public static (int, int) MultiplicationAndDivision(int a, int b)
    {
        a = a * b;
        b = a / b;
        a = a / b;

        return (a, b);
    }

    public static (int, int) Xor(int a, int b)
    {
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        return (a, b);
    }

    public static (int, int) TupleDeconstruction(int a, int b)
    {
        (b, a) = (a, b);

        return (a, b);
    }
}