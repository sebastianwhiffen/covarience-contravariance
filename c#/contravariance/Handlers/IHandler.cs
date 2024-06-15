public interface IHandler<in T> : IHandler
{
    void Handle(T item);
}

public interface IHandler {}