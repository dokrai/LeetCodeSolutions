// Determine whether an integer is a palindrome.

// Converting to string -> O(log10(n)) (92 ms)
public class Solution {
    public bool IsPalindrome(int x) {
        
        if (x < 0) {
            return false;
        }
        
        string strX = x.ToString();
		
		while (strX.Length > 1) {
			if(strX.Substring(0,1) != strX.Substring(strX.Length-1,1)) {
				return false;
			}
			strX = strX.Substring(1,strX.Length-2);
		}
        
        return true;
    }
}

// Operating with numbers -> O(log10(n)) (60 ms)
public class Solution {
    public bool IsPalindrome(int x) {
        
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }
        
        int reverse = 0;
		
		while (x > reverse) {
			reverse = reverse * 10 + x % 10;
            x /= 10;
		}
        
        return x == reverse || x == reverse / 10;
    }
}