using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BKDTree;

public class DimensionalComparer<T>(int dimension) : IComparer<T> where T : ITreeItem<T>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int Compare(T left, T right)
    {
        int result = left.CompareDimensionTo(right, dimension);
        return result;
    }
}
