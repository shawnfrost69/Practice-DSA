namespace Stack_and_Queue.ExpressionConversions;

public class Prefix_To_Infix
{
    private bool IsOperator(char c) => "+-*/^".Contains(c);
    
    public string PrefixToInfix(string prefix)
    {
        var stack = new Stack<string>();

        for (int i = prefix.Length - 1; i >= 0; i--)
        {
            char c = prefix[i];
            if (char.IsLetterOrDigit(c))
            {
                stack.Push(c.ToString());
            }
            else if (IsOperator(c))
            {
                var op1 = stack.Pop();
                var op2 = stack.Pop();
                stack.Push($"({op1}{c}{op2})");
            }
        }

        return stack.Pop();
    }
}