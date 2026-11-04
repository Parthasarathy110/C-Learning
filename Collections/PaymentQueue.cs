class PaymentQueue
{
    static void Main(string[] args)
    {
        Queue<string> payments=new Queue<string>();
        payments.Enqueue("PAY101");
        payments.Enqueue("PAY102");
        payments.Enqueue("PAY103");
        Console.WriteLine(string.Join(" ",payments));
        Console.WriteLine($"First Element: {payments.Peek()}");
        payments.Dequeue();
        Console.WriteLine($"Removed After: {string.Join(" ",payments)}");
        Console.WriteLine($"Final Count: {payments.Count()}");

    }
}