namespace Ex_13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyInfo myInfo = new MyInfo();
            myInfo.NameChanged += MyInfo_NameChanged;

            myInfo.Name = "Анна";
            myInfo.Name = "Иван";
        }

        static void MyInfo_NameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Имя изменено.");
        }
    }
}