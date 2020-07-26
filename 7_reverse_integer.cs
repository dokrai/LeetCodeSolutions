// Given a 32-bit signed integer, reverse digits of an integer.

// First approach -> O(log(n)) (40 ms)
public class Solution {
    public int Reverse(int x) {
        
        double max = Math.Pow(2,31) - 1;
        
        bool isNegative = x < 0;
        if (x > 0-(Math.Pow(2,31))) {
            x = Math.Abs(x);
        } else {
            return 0;
        }
        
        int result = 0;
        int auxX = x; 
        while(auxX > 0) {
            int lastNum = auxX % 10;
            auxX /= 10;
            
            if (max/10 < result) {
				return 0;
			}
            
            int tmp = result * 10 + lastNum;
            result = tmp;
        }
        
        if (isNegative) {
            return 0 - result;
        }
        return result;
    }
}

// Clean version -> O(log(n)) (40 ms)
public class Solution {
    public int Reverse(int x) {
        
        long result = 0;
        
        while (x != 0) {
            result = result * 10 + x % 10;
            x /= 10;
        }
        
        if (result > Int32.MaxValue || result < Int32.MinValue) {
            return 0;
        }
        
        return (int)result;
    }
}