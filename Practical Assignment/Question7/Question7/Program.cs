using System;
using System.IO;

class FileOperations
{
    static void Main()
    {
        try
        {
            // 1. File Creation and Writing
            File.WriteAllText("example.txt", "Hello, this is a sample text.");
            Console.WriteLine("File 'example.txt' created and written to.");

            // 2. File Reading
            string content = File.ReadAllText("example.txt");
            Console.WriteLine("File Content: " + content);

            // 3. Append Text to File
            File.AppendAllText("example.txt", "\nAdditional text appended.");
            Console.WriteLine("Additional text appended to 'example.txt'.");

            // 4. Copy File
            if (!File.Exists("copy_example.txt"))
            {
                File.Copy("example.txt", "copy_example.txt");
                Console.WriteLine("File copied to 'copy_example.txt'.");
            }
            else
            {
                Console.WriteLine("File 'copy_example.txt' already exists. Skipping copy.");
            }

            // 5. Move File
            //File.Move("copy_example.txt", "moved_example.txt");
            //Console.WriteLine("File moved to 'moved_example.txt'.");

            // 6. Delete File
            //File.Delete("example.txt");
            Console.WriteLine("File 'example.txt' deleted.");

            //// 7. Check File Existence
            //if (File.Exists("moved_example.txt"))
            //{
            //    Console.WriteLine("File 'moved_example.txt' exists.");
            //}
            //else
            //{
            //    Console.WriteLine("File not found.");
            //}
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
