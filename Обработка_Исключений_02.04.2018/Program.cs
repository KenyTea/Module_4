using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обработка_Исключений_02._04._2018 // Try Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region try
            try
            {
            int[] mas = new int[10];
                Console.WriteLine(mas[23]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            
        }
    }
}
