using System;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            IntListNode newNode = new IntListNode(value);
            if (First == null) 
            { 
                First = newNode;
            }
            else
            {
                IntListNode lastNode = First;
                while (lastNode != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
            }
        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            if (index < 0)
            {
                return null; 
            }

            IntListNode currentNode = First;
            int currentIndex = 0;

            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
                currentIndex++;
            }

            return null; 
        }

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            IntListNode node = GetNode(index);

            if (node != null)
            {
                return node.Value;
            }
            else
            {
                return 0; 
            }
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            int count = 0;
            IntListNode currentNode = First;

            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            return count;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index < 0)
            {
                return; // Posición negativa, no se hace nada
            }

            if (index == 0)
            {
                First = First?.Next; // Elimina el primer elemento si index es 0
                return;
            }

            IntListNode prevNode = GetNode(index - 1);

            if (prevNode != null && prevNode.Next != null)
            {
                prevNode.Next = prevNode.Next.Next; // Elimina el elemento en la posición index
            }
        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            First = null;
        }
    }
}