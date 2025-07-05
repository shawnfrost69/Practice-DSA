namespace Greedy_algorithm;

public class AssignCookies
{
    // child greed childGreed = [1,2,3], cookies = [1,1]
    public int Cookies(int[] cookie, int[] childGreed)
    {
        Array.Sort(cookie);
        Array.Sort(childGreed);

        int greedPoint = 0;
        foreach (int cookieSize in cookie)
        {
            if (greedPoint == childGreed.Length)
                break;

            if (cookieSize >= childGreed[greedPoint])
            {
                greedPoint++;
            }
        }
        return greedPoint;
    }
}