namespace Stack_and_Queue.ExpressionConversions;

public class Postfix_To_Prefix
{
    private bool IsOperator(char c) => "+-*/^".Contains(c);
    
    public string PostfixToPrefix(string postfix)
    {
        var stack = new Stack<string>();
        postfix = postfix.Replace(" ", "");

        foreach (char c in postfix)
        {
            if (char.IsLetterOrDigit(c))
            {
                stack.Push(c.ToString());
            }
            else if (IsOperator(c))
            {
                var op1 = stack.Pop();
                var op2 = stack.Pop();
                
                stack.Push($"{c}{op1}{op2}");
            }
        }

        return stack.Pop();
    }
}