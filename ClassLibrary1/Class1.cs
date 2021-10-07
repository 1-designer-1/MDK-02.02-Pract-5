using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void IndexArrya(int[,] Array, out int result, out int index)
        {
            //Узнаем размеры массива
            int rows = Array.GetUpperBound(0) + 1;
            int columns = Array.Length / rows;
            List<int> listArray = new List<int>();
            result = 0;
            //index = 0;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (Array[j, i] % 5 == 0 || Array[j, i] % 7 == 0) result++;
                    else throw new Exception("Такого столбца нет");
                }
                listArray.Add(result);
               
            }
            index = listArray.IndexOf(result);//Запаминаем номер столбца

        }























    }
}
