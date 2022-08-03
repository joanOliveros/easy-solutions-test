using System;
using System.Text;

namespace BetterPath
{
    public class Files
    {
        public int[,] GetData(String FilePath = "")
        {
            using (StreamReader fileData = new StreamReader(FilePath))
            {
                string Line;
                var IsSize = false;
                string[] Array;
                int Count = 0;
                int[,]? Mountain = new int[0,0];
                while ((Line = fileData.ReadLine()) != null) // Reading about the document
                {
                    Array = Line.Split(' ');  // Convert to an array
                    if (!IsSize)
                    {
                        Mountain = new int[int.Parse(Array[0]), int.Parse(Array[0])];  // define array size
                    }
                    else
                    {
                        foreach (var item in Array.Select((value, i) => new { i, value }))
                        {
                            Mountain[item.i, Count] = int.Parse(item.value);
                        }
                        Count++;
                    }
                    IsSize = true;
                }
            return Mountain;
            }
        }
    }
}

