
namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        private List<T> objects = new List<T>();

        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            GenericList<T> list = new GenericList<T>();
            foreach (var obj in objects)
            {
                list.Add(obj);
            }
            return list.AsString();
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return objects.Count;
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            objects.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            objects.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it

            if (objects.Count > 0)
            {
                int lastIndex = objects.Count - 1;
                T lastObject = objects[lastIndex];
                objects.RemoveAt(lastIndex);
                return lastObject;
            }
            else
            {
                return default(T);
            }
        }
    }
}