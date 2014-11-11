namespace Core.Dal
{
    public interface IProvidesSession
    {
        ISession GetSession();
        void SetSession( ISession session );
    }
}
