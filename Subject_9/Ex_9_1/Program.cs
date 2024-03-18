namespace Ex_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass obj = new TestClass();

            Iy iy = obj;
            Iz iz = obj;

            iy.F0('F');
            iy.F1();

            iz.F0('X');
            iz.F1();


            ((Ix)obj).IxF0('Y');
            ((Ix)obj).IxF1();


            Ix ix = obj;
            ix.IxF0('Z');
            ix.IxF1();
        }
    }
}