// Build: 97bbfa93348bb2254db9cf1f1f199d0a
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
