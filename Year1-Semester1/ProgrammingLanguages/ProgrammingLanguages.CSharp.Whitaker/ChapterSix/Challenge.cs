namespace ProgrammingLanguages.CSharp.Whitaker.ChapterSix;

public class Challenge
{
    public static void VariableShop()
    {
        // Integral types
        byte byteVar = 255;           // 8-bit unsigned
        sbyte sbyteVar = -128;        // 8-bit signed
        short shortVar = -32768;      // 16-bit signed
        ushort ushortVar = 65535;     // 16-bit unsigned
        int intVar = -2147483648;     // 32-bit signed
        uint uintVar = 4294967295;    // 32-bit unsigned
        long longVar = -9223372036854775808; // 64-bit signed
        ulong ulongVar = 18446744073709551615; // 64-bit unsigned

        // Floating-point types
        float floatVar = 3.14f;        // 32-bit floating point
        double doubleVar = 3.14159265359; // 64-bit floating point
        decimal decimalVar = 79228162514264337593543950335m; // 128-bit high precision

        // Other types
        char charVar = 'A';           // Unicode 16-bit character
        bool boolVar = true;          // Boolean value
        string stringVar = "Hello";   // Sequence of characters

        // Output the values
        Console.WriteLine($"byte: {byteVar}");
        Console.WriteLine($"sbyte: {sbyteVar}");
        Console.WriteLine($"short: {shortVar}");
        Console.WriteLine($"ushort: {ushortVar}");
        Console.WriteLine($"int: {intVar}");
        Console.WriteLine($"uint: {uintVar}");
        Console.WriteLine($"long: {longVar}");
        Console.WriteLine($"ulong: {ulongVar}");
        Console.WriteLine($"float: {floatVar}");
        Console.WriteLine($"double: {doubleVar}");
        Console.WriteLine($"decimal: {decimalVar}");
        Console.WriteLine($"char: {charVar}");
        Console.WriteLine($"bool: {boolVar}");
        Console.WriteLine($"string: {stringVar}");
    }
}
