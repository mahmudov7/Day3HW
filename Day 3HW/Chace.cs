public class Chache<T>
{
    T velu;
    public void Add(T t)
    {
        velu = t;
    }
    public T GetValue()
    {
        return velu;
    }
    public void Remove()
    {
        velu = default(T);
    }
}