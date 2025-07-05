namespace Maths;

public class BinaryToDecimal
{
    public static int binaryToDecimal(string b)
    {
        int powerOf2 = 1;
        int result = 0;
        
        for(int i = b.Length -1; i >= 0; i--)
        {
            if(b[i] == '1')
            {
                result += powerOf2;
            }
            
            powerOf2 *= 2;
        }
        return result;
    }
}