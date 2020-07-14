using Application.ValueObject;

namespace Data.Repository.Interface
{
    public interface ICountDataStore
    {
        int GetCount();
        void SetCount(int value);
    }
}