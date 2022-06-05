//Task 1:
using ConsoleApp1.Models;
Console.WriteLine("--------------------------------------------this is task 1----------------------------------------------------");

Console.Write("Enter Your Name : ");
string fullName = Console.ReadLine();
Console.WriteLine($"Your name is {fullName}");

//Task 2:
Console.WriteLine("--------------------------------------------this is task 2----------------------------------------------------");
BinaryConverter Task2 = new BinaryConverter();
string binary = Task2.StringToBinary(fullName);
Console.WriteLine(binary);
Task2.binaryToString(binary);

//Task 3:
Console.WriteLine("--------------------------------------------this is task 3----------------------------------------------------");
HexadecimalConverter Task3 = new HexadecimalConverter();
string hexa = Task3.hexaConverter(fullName);
Console.WriteLine(hexa);
Task3.ConvertHexToString(hexa);


//Task 4:
Console.WriteLine("--------------------------------------------this is task 4----------------------------------------------------");
Base64Converter Task4 = new Base64Converter();
string Base64 = Task4.Base64Encode(fullName);
Console.WriteLine(Base64);
Task4.Base64StringDecode(Base64);

//Task 5:
Console.WriteLine("--------------------------------------------this is task 5----------------------------------------------------");
//entryption decryption
string plaintext = fullName;
int encryptionDepth = 10;
int[] key = plaintext.ToString().Select(o => Convert.ToInt32(o)).ToArray();
for (int i = 0; i < key.Length; i++)
{
    Console.Write(key[i] + "\t");
}
Console.WriteLine("\n\n");
string cipherasString = String.Join(",", key.Select(x => x.ToString())); //For display purposes
//EncryptDecrypt encrypter = new EncryptDecrypt(plaintext, key, encryptionDepth);
EncryptDecrypt encrypter = new EncryptDecrypt(plaintext, key, encryptionDepth);
//Single Level Encrytion
string nameEncryptWithCipher = EncryptDecrypt.EncryptWithCipher(plaintext, key);
Console.WriteLine($"Encrypted once using the cipher {{{cipherasString}}} {nameEncryptWithCipher}");
string nameDecryptWithCipher = EncryptDecrypt.DecryptWithCipher(nameEncryptWithCipher, key);
Console.WriteLine($"Decrypted once using the cipher {{{cipherasString}}} {nameDecryptWithCipher}");
//Deep Encrytion
Console.WriteLine("\n");
string nameDeepEncryptWithCipher = EncryptDecrypt.DeepEncryptWithCipher(plaintext, key, encryptionDepth);
Console.WriteLine($"Deep Encrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepEncryptWithCipher}");
string nameDeepDecryptWithCipher = EncryptDecrypt.DeepDecryptWithCipher(nameDeepEncryptWithCipher, key, encryptionDepth);
Console.WriteLine($"Deep Decrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepDecryptWithCipher}");