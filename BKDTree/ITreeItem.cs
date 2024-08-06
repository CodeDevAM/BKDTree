namespace BKDTree;

public interface ITreeItem<in T>
{
    int CompareDimensionTo(T other, int dimension);
}