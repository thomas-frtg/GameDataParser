



public class ConsoleUserInteractor : IUserInteractor
{
    public void PrintErrorMessage(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadValidFilePath()
    {
        bool isFilePathValid = false;
        var fileName = default(string);

        do
        {
            PrintMessage("Enter the name of the file you want to read: ");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                PrintMessage("The file name cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                PrintMessage("The file name cannot be empty");
            }
            else if (!File.Exists(fileName))
            {
                PrintMessage("File was not found");
            }
            else
            {
                isFilePathValid = true;
            }
        } while (!isFilePathValid);
        return fileName;
    }
}
