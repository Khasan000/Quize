namespace ConsoleApp;

public class FileWriter
{
    public static void CreateAndWrite(string login, int password)
    {
        if (File.Exists(login + ".txt"))
        {
            throw new ArgumentException("File has already exist!");
        }
        
        using (FileStream fs = new FileStream(login+".txt", FileMode.CreateNew))
        {
            byte[] array = System.Text.Encoding.Default.GetBytes(login+"\n");
            byte[] array1 = System.Text.Encoding.Default.GetBytes(password.ToString());

            fs.Write(array);
            fs.Write(array1);
        }
    }
}