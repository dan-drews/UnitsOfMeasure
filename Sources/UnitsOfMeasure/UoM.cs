﻿namespace UnitsOfMeasure;

public static class UoM
{
    public static Unit<Meter<T>, Meter<T>, T> Meters<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Kilometer<T>, Meter<T>, T> Kilometers<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Mile<T>, Meter<T>, T> Miles<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Second<T>, Second<T>, T> Seconds<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Minute<T>, Second<T>, T> Minutes<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Degree<T>, Radian<T>, T> Degrees<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Radian<T>, Radian<T>, T> Radians<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Kilogram<T>, Kilogram<T>, T> Kilograms<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Gram<T>, Kilogram<T>, T> Grams<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Tonn<T>, Kilogram<T>, T> Tonns<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParseable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);
}