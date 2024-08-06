# BKDTree

BKDTree offers a simple and high performant implementation of a growing only BKDTree and a static KDTree for C# and .NET. 

A BKDTree and an KDTree allow storing any queying of multidimensional data. Non of these support a method for removing items.

<img src="./icon.png" width="256" height="256"/>

## Usage
Items of type `T` that shall be stored in a `BKDTree<T>` or a `KDTree<T>` must implement the interface `ITreeItem<T>` with its method `CompareDimensionTo()`.

```Csharp
public interface ITreeItem<in T>
{
    int CompareDimensionTo(T other, int dimension);
}
```

## Contribution

Contributions are welcome.

## License

MIT License

Copyright (c) 2024 DevAM

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
