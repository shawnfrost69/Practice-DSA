﻿using Stack_and_Queue.ExpressionConversions;

namespace Stack_and_Queue;

class Program
{
    static void Main(string[] args)
    {
        var postfixToInfix = new Postfix_To_Infix();
        string s6 = "A B C * +";
        Console.WriteLine($"Postfix to Infix: {postfixToInfix.PostfixToInfix(s6)}");

        var postfixToPrefix = new Postfix_To_Prefix();
        string s5 = "A B C * +";
        Console.WriteLine($"Postfix to Prefix: {postfixToPrefix.PostfixToPrefix(s5)}");
        
        var prefixToPostfix = new Prefix_To_Postfix();
        string s4 = "+ A * B C";
        Console.WriteLine($"Prefix to Postfix: {prefixToPostfix.PrefixToPostfix(s4)}");

        var prefixToInfix = new Prefix_To_Infix();
        string s3 = "+A *B C";
        Console.WriteLine($"Prefix to Infix: {prefixToInfix.PrefixToInfix(s3)}");
        
        var infixToPrefix = new Infix_To_Prefix();
        string s1 = "A+(B + C)";
        Console.WriteLine($"Infix to Prefix: {infixToPrefix.InfixToPrefix(s1)}");

        var converter = new Infix_To_Postfix();
        string s2 = "(C+B)+A";
        Console.WriteLine($"Infix to Postfix: {converter.InfixToPostfix(s2)}");
        
        Queue_Using2Stacks queueUsing2Stacks = new();
        queueUsing2Stacks.Enqueue(4);
        queueUsing2Stacks.Enqueue(3);
        queueUsing2Stacks.PrintQueue();
        queueUsing2Stacks.Dequeue();
        queueUsing2Stacks.PrintQueue();
        
        Console.WriteLine("-----------------------------------");
        Queue_UsingLinkedList queueLL = new();
        queueLL.Enqueue(4);
        queueLL.Enqueue(10);
        queueLL.PrintQueue();
        queueLL.Dequeue();
        queueLL.PrintQueue();

        Console.WriteLine("-----------------------------------");
        
        Queue_UsingArray queueUsingArray = new(6);
        queueUsingArray.Enqueue(2);
        queueUsingArray.Enqueue(22);
        queueUsingArray.Enqueue(12);
        queueUsingArray.Enqueue(1);
        queueUsingArray.Enqueue(8);
        queueUsingArray.Enqueue(5);
        queueUsingArray.PrintQueue();
        queueUsingArray.Dequeue();
        queueUsingArray.PrintQueue();
        
        Console.WriteLine("-----------------------------------");

        Stack_UsingOneQueue stack = new Stack_UsingOneQueue();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.PrintStack();

        stack.Pop();
        stack.PrintStack();
        Console.WriteLine("Stack using Single Queue Ends here:");
        Console.WriteLine("---------------------------------------------");
        
        var stackLL = new Stack_UsingLL();
        stackLL.Push(10);
        stackLL.Push(20);
        stackLL.Push(30);

        stackLL.PrintNode();
        stackLL.Pop();
        stackLL.PrintNode();

        Console.WriteLine("LL Stack Ends here:");
        Console.WriteLine("-------------------------------------------------");
        
        var stackCostlyPush = new Stack_UsingCostlyPush();
        stackCostlyPush.Push(100);
        stackCostlyPush.Push(200);
        stackCostlyPush.Push(300);

        stackCostlyPush.PrintStack();
        stackCostlyPush.Pop();
        stackCostlyPush.PrintStack();

        Console.WriteLine("Costly Push Stack Ends here:");
        Console.WriteLine("-------------------------------------------------");
        
        
        var stackCostlyPop = new Stack_UsingCostlyPop();
        stackCostlyPop.Push(110);
        stackCostlyPop.Push(210);
        stackCostlyPop.Push(310);

        stackCostlyPop.PrintStack();
        stackCostlyPop.Pop();
        stackCostlyPop.PrintStack();

        Console.WriteLine("Costly Pop Stack Ends here:");
        Console.WriteLine("-------------------------------------------------");
        
        
        
        Console.WriteLine("Enter stack size using Array:");
        int size = int.Parse(Console.ReadLine());

        Stack_Array stackArray = new(size);

        while (true)
        {

            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Print stack");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter value to Push:");
                    int val = int.Parse(Console.ReadLine());
                    stackArray.Push(val);
                    break;
                
                case 2:
                    Console.WriteLine("Popped value:");
                    stackArray.Pop();
                    break;
                
                case 3:
                    Console.WriteLine("Top Value:");
                    stackArray.Peek();
                    break;
                
                case 4:
                    stackArray.PrintStack();
                    break;
                
                case 5:
                    return;
                
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
        }
    }
}