public class Spinner
{
    public void DisplaySpinner(int seconds = 3, int speed = 250)
    {
        // Spinner frames to simulate rotation
        char[] spinner = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(speed);     // speed controls how fast/slow it spins
            Console.Write("\b");     // backspace to overwrite previous char
            i++;
        }
        Console.Write(" ");
        Console.Write("\b");
    }
}