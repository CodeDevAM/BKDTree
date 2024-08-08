namespace BKDTree;

public interface ITreeItem<in T>
{
    int CompareDimensionTo(T other, int dimension);
}

public interface IMetricTreeItem<in T> : ITreeItem<T>
{
    double GetDimension(int dimension);
}