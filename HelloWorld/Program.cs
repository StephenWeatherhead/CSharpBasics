//Console.WriteLine("Hi mate!");
//Console.WriteLine("What's your name again?");
//string name = Console.ReadLine();
//Console.WriteLine($"Hello there {name}!");

// integer types
sbyte mySignedByte; // -128 to 127 (8 bits)
byte myByte; // 0 to 255 (8 bits)
short myShort; // -32,768 to 32767 (16 bits)
ushort myUnsignedShort; // 0 to 65,635 (16 bits)
int myInt; // -2,147,483,648 to 2,147,483,647 (32 bits)
uint myUnsignedInt; // 0 to 4,294,967,295
long myLong = 123L; // signed 64 bits
ulong myUnsignedLong = 123uL; // 64 bits

// int literals
int myDecimalLiteral = 123; // digit separator - 123000 can be written as 123_000
int myHexadecimalLiteral = 0x2A;
int myBinaryLiteral = 0b_0010_1010;

// native integers
// The size of this type is determined at runtime by the CPU
// the code is running on. It matches the CPU word size.
// Native integers are primarily used to make it easier
// to write interop code for other libraries.
nint myNativeInt;
nuint myNativeUnsignedInt;

// float types
float myFloat = 134.45E-2f; // 4 bytes
double myDouble = 0.42e2d; // 8 bytes
decimal myDecimal = 1.5E6m; // 16 bytes

Console.ReadLine();