namespace Stack_and_Queue.ExpressionConversions;

public class Infix_To_Prefix
{
    public string InfixToPrefix(string infix)
    {
        var n = new Infix_To_Postfix();
        
        var reversed = infix.Replace(" ", "").Reverse().ToArray();
        for (int i = 0; i < reversed.Length; i++)
        {
            if (reversed[i] == '(') reversed[i] = ')';
            else if (reversed[i] == ')') reversed[i] = '(';
        }

        string reveresedInfix = new string(reversed);
        string postfix = n.InfixToPostfix(reveresedInfix);
        return new string(postfix.Reverse().ToArray());
    }
}