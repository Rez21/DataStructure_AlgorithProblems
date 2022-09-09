using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    class BubbleSort
    {
        public int[] arr;
        public int Top;
        public int numElements;

        public BubbleSort(int size)
        {
          
            arr = new int[size];
          
            Top = size - 1;
           
            numElements = 0;
        }
        public void InsertNumbers(int item)
        {

            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int display = 0; display <= Top; display++)
                Console.WriteLine(arr[display] + ",");
        }
        public void BubbleSorts()
        {            
            int temp;
            for (int outer = Top; outer >= 1; outer--)
            {                
                for (int inner = 0; inner <= outer - 1; inner++)
                    if ((int)arr[inner] > arr[inner + 1])
                    {                        
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
            }            
            this.DisplayElements();
        }
    }
}
