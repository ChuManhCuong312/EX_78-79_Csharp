using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Phần a: Thread
        var thread = new Thread(() =>
        {
            Console.WriteLine("Thread bắt đầu.");
            Thread.Sleep(1000);
            Console.WriteLine("Thread kết thúc.");
        });

        thread.Start();
        thread.Join(); // Đợi thread hoàn thành

        Console.WriteLine("Thread hoàn thành. Bắt đầu phần async.");

        // Phần b: Async/Await
        await Async1();
        
        Console.WriteLine("Chương trình kết thúc.");
    }

    public static async Task Async1()
    {
        Console.WriteLine("Async bắt đầu.");
        await Task.Delay(1000); // Tạm dừng trong 1 giây
        Console.WriteLine("Async kết thúc.");
    }
}
