using System;

class Exercise2.2
    {
    static void Main(string[] args)
    {

        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "Type", "Byte(s) of memory", "Min", "Max");
        Console.WriteLine(new string('-', 90));


        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30:G9} {3,-30:G9}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30:G17} {3,-30:G17}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
}