using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Initializer;

namespace P01_HospitalDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseInitializer.ResetDatabase();
        }
    }
}
