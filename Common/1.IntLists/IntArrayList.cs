using System;

namespace Common
{
    public class IntArrayList : IList
    {
        int[] Values;
        int NumElements = 0;
        
        public IntArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
            Values = new int[n];
            NumElements = n;
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i] + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #2: add a new integer to the end of the list
            if (NumElements < Values.Length)
            {
                Values[NumElements] =value;
                NumElements++;
            }
            else
            {
                int newSize = Values.Length +1;
                int[] newValues = new int[newSize];
                for(int i = 0;i < Values.Length; i++)
                {
                    newValues[i] = Values[i];
                }
                Values= newValues;
                Values[NumElements] = value;
                NumElements++;
            }

        }

        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            if (index < NumElements)
            {
                return Values[index];
            }
            else
            {
                return 0;
            }
            
        }


        
        public int Count()
        {
            //TODO #4: return the number of elements on the lis
            return NumElements;
        }



        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index <= NumElements)
            {
                int newSize = Values.Length - 1;
                int[] newValues = new int[newSize];
                for (int i = 0; i < Values.Length; i++)
                {


                    if (Values[i] >= index)
                    {
                        newValues[i] = Values[i + 1];

                    }
                    else
                    {
                        newValues[i] = Values[i];
                    }
                }
                Values = newValues;
                NumElements--;
            }
        }

        public void Clear()
        {
            int[] newValues = new int[0];
            Values = newValues;
            NumElements = 0;
        }
    }
}