namespace IntergenicLibrary
{
    public class GenericDefaulterList<T> where T : IDefaulterList
    {
        private T[] defaulter;
        private int numElements;
        private const int DEFAULTSIZE = 5;

        public  GenericDefaulterList()
        {
            defaulter = new T[DEFAULTSIZE];
            numElements = 0;
        }

         public  GenericDefaulterList(int size)
        {
            defaulter = new T[size];
            numElements = 0;
        }

        public void Add(T item)
        {
            if(numElements < defaulter.Length)
            {
                defaulter[numElements] = item;
                numElements++;
            }else{
                throw new System.Exception("Defaulter list is full!");
            }
        }
        public T[] GetAllDefaulters()
        {
            if(numElements > 0)
            {
                return defaulter;
            }
            throw new System.Exception("DefaulterList is empty!");
        }

    }
}