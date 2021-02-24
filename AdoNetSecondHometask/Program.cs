using Data;

namespace AdoNetSecondHometask
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var groupData = new GroupDataAccess())
            {
                groupData.CreateTable();
            }
        }
    }
}
