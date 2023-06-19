using System;
using System.Collections.Generic;
using System.Linq;
public static class CustomExtensions
{
    // CustomAll extension method that checks if all elements in a collection satisfy a given predicate.
    public static bool CustomAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (T item in source)
        {
            if (!predicate(item))
            {
                return false;
            }
        }

        return true;
    }

    // CustomAny extension method that checks if any element in a collection satisfies a given predicate.
    public static bool CustomAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (T item in source)
        {
            if (predicate(item))
            {
                return true;
            }
        }

        return false;
    }

    // CustomMax extension method that returns the maximum element in a collection as determined by the given selector function.
    public static T CustomMax<T>(this IEnumerable<T> source, Func<T, IComparable> selector)
    {
        // Argument null checks
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (selector == null)
        {
            throw new ArgumentNullException(nameof(selector));
        }

        // Throw exception if the sequence is empty
        if (!source.Any())
        {
            throw new InvalidOperationException("Sequence contains no elements.");
        }

        // Initialize the maximum element and its value
        T max = source.First();
        IComparable maxValue = selector(max);

        // Iterate through the rest of the collection, comparing each element to the current maximum
        foreach (T item in source.Skip(1))
        {
            IComparable value = selector(item);

            if (value.CompareTo(maxValue) > 0)
            {
                max = item;
                maxValue = value;
            }
        }

        return max;
    }

    // CustomMin extension method that returns the minimum element in a collection as determined by the given selector function.
    public static T CustomMin<T>(this IEnumerable<T> source, Func<T, IComparable> selector)
    {
        // Argument null checks
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (selector == null)
        {
            throw new ArgumentNullException(nameof(selector));
        }

        // Throw exception if the sequence is empty
        if (!source.Any())
        {
            throw new InvalidOperationException("Sequence contains no elements.");
        }

        // Initialize the minimum element and its value
        T min = source.First();
        IComparable minValue = selector(min);

        // Iterate through the rest of the collection, comparing each element to the current minimum
        foreach (T item in source.Skip(1))
        {
            IComparable value = selector(item);

            if (value.CompareTo(minValue) < 0)
            {
                min = item;
                minValue = value;
            }
        }

        return min;
    }

    // CustomWhere extension method that returns a new collection containing only the elements that satisfy a given predicate.
    public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        foreach (T item in source)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }

    // CustomSelect extension method that returns a new collection containing the results of applying a given selector function to each element in the collection.
    public static IEnumerable<TResult> CustomSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        foreach (TSource item in source)
        {
            yield return selector(item);
        }
    }
}