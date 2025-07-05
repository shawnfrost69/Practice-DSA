namespace Greedy_algorithm;

public class LemonadeChange
{
    public static bool lemonade(int[] bills)
    {
        int five = 0, ten = 0;
        foreach (int bill in bills)
        {
            if (bill == 5)
            {
                five++;
            }
            else if (bill == 10)
            {
                if (five == 0)  // cann't give the changes
                {
                    return false;
                }

                five--;
                ten++;
            }
            else
            {
                if (ten > 0 && five > 0)
                {
                    ten--;
                    five--;
                }else if (five >= 3)
                {
                    five -= 3;
                }
                else
                {
                    return false;
                }
            }
        }
         return true;
    }
}