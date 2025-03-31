// a. Write a program to read, write, and append the text file contents.
// b. Write a program to read and write contents of a binary file.
// c. Write a program to demonstrate usage of DirectoryInfo and FileInfo classes.

using System;
using System.IO;

class FileOperations
{
    static void Main()
    {
        Question1();
        Question2();
        Question3();
    }

    static void Question1()
    {
        string filePath = "E:\\Dot Net Workshop\\College Assignment\\Checking\\Question5\\Question5\\sample.txt";

        // Writing to file
        Console.WriteLine("Writing to file...");
        File.WriteAllText(filePath, "Hello, this is the first line of the file.\n");

        // Appending to file
        Console.WriteLine("Appending to file...");
        File.AppendAllText(filePath, "This is an appended line.\n");

        // Reading from file
        Console.WriteLine("Reading from file...");
        string content = File.ReadAllText(filePath);
        Console.WriteLine("File Content:\n" + content);

        Console.WriteLine("File operations completed successfully.");
    }

    static void Question2()
    {
        string binaryFilePath = "E:\\Dot Net Workshop\\College Assignment\\Checking\\Question5\\Question5\\sample.bin";

        // Writing to binary file
        using (BinaryWriter writer = new BinaryWriter(File.Open(binaryFilePath, FileMode.Create)))
        {
            Console.WriteLine("Writing to binary file...");
            writer.Write(123);
            writer.Write(45.67);
            writer.Write("Binary File Example");
        }

        // Reading from binary file
        using (BinaryReader reader = new BinaryReader(File.Open(binaryFilePath, FileMode.Open)))
        {
            Console.WriteLine("Reading from binary file...");
            Console.WriteLine($"Int: {reader.ReadInt32()}\nDouble: {reader.ReadDouble()}\nString: {reader.ReadString()}");
        }
    }

    static void Question3()
    {
        Console.WriteLine("Enter the path to get file and directory information:");
        string path = Console.ReadLine();

        // Directory Information
        DirectoryInfo dirInfo = new DirectoryInfo(path);
        if (dirInfo.Exists)
        {
            Console.WriteLine($"Directory Name: {dirInfo.Name}");
            Console.WriteLine($"Full Path: {dirInfo.FullName}");
            Console.WriteLine($"Creation Time: {dirInfo.CreationTime}");
            Console.WriteLine("Files:");
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                Console.WriteLine($" - {file.Name} (Size: {file.Length} bytes)");
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }
    }
}
