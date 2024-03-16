using static System.Console;
namespace Ex_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursWork = 45;
            Accauntant accauntant = new Accauntant();
            bool a = accauntant.AskForBonus(Accauntant.Positions.OfficeManager, hoursWork);
            WriteLine(a);
        }
    }
    internal class Accauntant
    {
        public enum Positions
        {
            GeneralDirector = 24,
            ArtDirector = 26,
            HRDirector = 34,
            ManagingDirector = 40,
            ProjectManager = 48,
            BranchManager = 36,
            SeniorManager = 60,
            OfficeManager = 54,
            SalesManager = 100
        }
        public bool AskForBonus(Positions worker, int hours)
        {
            int requiredHours = (int)worker;

            if (hours < requiredHours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}