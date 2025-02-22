using Entity_FrameWork_Session_01.Entities;

namespace Entity_FrameWork_Session_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterPriceDBContext dBContext = new EnterPriceDBContext();
            Student student01 = new Student()
            {
                FName = "Sajeda",
                LName = "Mohamed",
                Address = "Cairo",
                Age = 20, 
            };
        }
    }
}
