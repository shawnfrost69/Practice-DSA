namespace Stack_and_Queue.ExpressionConversions;

public class Infix_To_Postfix
{
    private bool IsOperator(char c) => "+-*/^".Contains(c);
    private int PriorityOrder(char c)
    {
        return c switch
        {
            '+' or '-' => 1,
            '*' or '/' => 2,
            '^' => 3,
            _ => -1
        };
    }
    public string InfixToPostfix(string infix)
    {
        var result = new List<char>();
        var stack = new Stack<char>();

        infix = infix.Replace(" ", "");

        foreach (var c in infix)
        {
            if (char.IsLetterOrDigit(c))
            {
                result.Add(c);
            }
            else if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                while (stack.Peek() != '(')
                {
                    result.Add(stack.Pop());
                }

                stack.Pop();
            }
            else if (IsOperator(c))
            {
                while (stack.Any() && PriorityOrder(c) <= PriorityOrder(stack.Peek()))
                {
                    result.Add(stack.Pop());
                }

                stack.Push(c);
            }
        }

        while (stack.Any())
        {
            result.Add(stack.Pop());
        }
        
        return new string(result.ToArray());
    }
}