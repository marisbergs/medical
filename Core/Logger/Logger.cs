namespace Core
{
    public static class Logger
    {
        private static ILogger _databaseAppender = null;

        public static void SetDatabaseAppender(ILogger implementor)
        {
            _databaseAppender = implementor;
        }

        public static ILogger DB
        {
            get
            {
                if (_databaseAppender == null)
                    throw new System.Exception("Log implementor not set");
                return _databaseAppender;
            }
        }
    }
}
