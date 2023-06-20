namespace ConsoleApp;

public class FileWriter
{
    public static void CreateAndWrite(string login, int password)
    {
        if (File.Exists(login + ".txt"))
        {
            Console.WriteLine("File with name {0} already exist", login + ".txt");
            return;
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