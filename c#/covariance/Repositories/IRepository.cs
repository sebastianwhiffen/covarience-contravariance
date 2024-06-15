namespace Covariance;

public interface IRepository<out T>
{
    T GetItem(int id);
}