using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list

        GenericListNode<T> newNode = new GenericListNode<T>(value);

        if (First == null)
        {
            First = newNode;
        }
        else
        {
            GenericListNode<T> current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'

        if (index < 0)
            return null;

        GenericListNode<T> current = First;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index)
            {
                return current;
            }

            current = current.Next;
            currentIndex++;
        }

        return null;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds

        GenericListNode<T> node = FindNode(index);

        if (node != null)
        {
            return node.Value;
        }
        else
        {
            return default(T);
        }
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list

        int count = 0;
        GenericListNode<T> current = First;

        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        if (index < 0)
            return;

        if (index == 0)
        {
            if (First != null)
            {
                First = First.Next;
            }
            return;
        }

        GenericListNode<T> previousNode = FindNode(index - 1);
        if (previousNode != null && previousNode.Next != null)
        {
            previousNode.Next = previousNode.Next.Next;
        }

        public void Clear()
    {
            //TODO #6: remove all the elements on the list
            First = null;
        }
}