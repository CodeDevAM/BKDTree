namespace BKDTree;

public record struct Option<TValue>(bool HasValue, TValue Value)
{
    public static implicit operator Option<TValue>(TValue value) => new(true, value);

    public override readonly string ToString()
    {
        string result = HasValue ? $"{Value}" : "";
        return result;
    }
}