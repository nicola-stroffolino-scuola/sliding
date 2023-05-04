using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if(span == 0) return 1;
        if(
            span < 0 
            || (string.IsNullOrEmpty(digits) && span != 0)
            || span > digits.Length
        ) throw new ArgumentException();

        int max = 0;
        for (int i = 0; i < digits.Length - span + 1; i++){
            int x = 1;
            for (int j = 0; j < span; j++){
                if(digits[i + j] < 48 || digits[i + j] > 57)
                    throw new ArgumentException();
                x *= (int) digits[i + j] - 48;
            }
            if(x > max) max = x;
        }

        return max;
    }
}