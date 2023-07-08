namespace ConsoleApp90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol;
            int bracketExpression = 0;
            int depthExpression = 0;
            bool isBracketExpressionCorrect = true;

            Console.Write("Введите скобочное выражение:");
            symbol = Console.ReadLine();

            for (int i = 0; i < symbol.Length; i++)
            {
                if (symbol[i] == '(' && bracketExpression == 0)
                {
                    bracketExpression++;
                    depthExpression++;
                }
                else if (symbol[i] == ')' && bracketExpression > 0)
                {
                    bracketExpression--;
                }
                else if ((symbol[i] == '(') && depthExpression > 0)
                {
                    isBracketExpressionCorrect = false;
                }
            }

            Console.WriteLine(bracketExpression);

            if (bracketExpression == 0 && isBracketExpressionCorrect == true)
            {
                Console.WriteLine("Скобочное выражение - верное.");
            }
            else if (isBracketExpressionCorrect == false)
            {
                Console.WriteLine("Скобочное выражение - не верное.");
            }

            Console.WriteLine("Максимальная глубина скобочного выражения - " + depthExpression);
        }
    }
}