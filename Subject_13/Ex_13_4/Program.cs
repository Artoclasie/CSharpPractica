namespace Ex_13_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            FirstObserver firstObserver = new FirstObserver();
            SecondObserver secondObserver = new SecondObserver();

            publisher.EventOccurred += firstObserver.ReactToEvent;
            publisher.EventOccurred += firstObserver.ReactToEvent;
            publisher.EventOccurred += secondObserver.ReactToEvent;

            publisher.RaiseEvent();

            Console.WriteLine();

            publisher.EventOccurred -= firstObserver.ReactToEvent;

            publisher.RaiseEvent();
        }
    }
}