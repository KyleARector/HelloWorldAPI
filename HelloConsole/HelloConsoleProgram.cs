using System;
using HelloAPI;

namespace HelloConsole
{
    class HelloConsoleProgram
    {
        static void Main(string[] args)
        {
            // Instantiate new console writer
            HelloAPIConsole console = new HelloAPIConsole("Hello World");

            // Write the message to console
            console.WriteMessage();

            // Wait for user input to close
            Console.Read();
        }
    }
}
