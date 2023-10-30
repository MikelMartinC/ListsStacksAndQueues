using System;
using System.Windows.Markup;

namespace Common
{
    public class GenericArrayList<T> : IGenericList<T>
        T[] Values;
        int NumElements = 0;

        public GenericArrayList(int n)
        {
        //TODO #1: initialize Values with an array of size n
        Values = new T[n];
    }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i].ToString() + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        

        public void Add(T value)
        {
        //TODO #2: add a new element to the end of the list
        if (NumElements < Values.Length)
        {
            Values[NumElements] = value;
            NumElements++;
        }
        else
        {
            
            int newCapacity = Values.Length * 2; 
            T[] newValues = new T[newCapacity];
            Array.Copy(Values, newValues, Values.Length);
            Values = newValues;

            Values[NumElements] = value;
            NumElements++;
        }
    }

        public T Get(int index)
        {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        if (index <= NumElements)
        {
            return T[index]
        }
            return null;
        }

        public int Count()
        {
            //TODO #4: return the number of elements on the list

            return NumElements;
        }

        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            Values2 = new T[NumElements];
         if(index> NumElements)
        {
            return null;
        }
        else { 
           for (int i=0;i < NumElements; i++)
            {
                if (i < index)
                {
                    Values2[i] = Values[i];
                }
                else
                {
                    Values2[i] = Values[i + 1];
                }
            }

            Values = Values2;
               
        }

            
        }

        public void Clear()
        {
        //TODO #6: remove all the elements on the list
            
        NumElements = 0;
        Values = new T[0];

    }
    }
}