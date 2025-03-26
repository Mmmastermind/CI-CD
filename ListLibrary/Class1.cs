namespace ListLibrary
{
    public class ListUtils
    {
         public static void Add<T>(List<T> list, T item)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            list.Add(item);
        }

        public static void Remove<T>(List<T> list, T item)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (!list.Contains(item))
            {
                throw new ArgumentException("Item not found in the list.", nameof(item));
            }
            list.Remove(item);
        }

        public static bool Contains<T>(List<T> list, T item)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if (!list.Contains(item))
            {
                throw new ArgumentException("Item not found in the list.", nameof(item));
            }
            return list.Contains(item);
            

           
        }
    }
}
