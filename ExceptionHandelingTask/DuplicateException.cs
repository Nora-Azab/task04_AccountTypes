namespace ExceptionHandelingTask
{
    [Serializable]
    internal class DuplicateException : Exception
    {
        private int num;

        public DuplicateException()
        {
        }
        public DuplicateException(int num):base($"there is a doublication for {num}")
        {
            
            this.num = num;
        }
    }
}