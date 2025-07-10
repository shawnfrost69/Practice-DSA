namespace Stack_and_Queue.ExpressionConversions;

public class Postfix_To_Infix
{
    private bool IsOperator(char c) => "+-*/^".Contains(c);
    public string PostfixToInfix(string postfix)
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
                
                stack.Push($"({op2}{c}{op1})");
            }
        }

        return stack.Pop();
    }
}