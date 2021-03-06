﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calc
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please give me a simple expression. I'm not a very good calculator.");
            Expression parse = new Expression();
            Terminal prompt = new Terminal();
            Operations math = new Operations();
            Stack stack = new Stack();
            bool running = true;
            while (true)
            {
                Console.Write(prompt.PromptForExpression());
                string userInput = Console.ReadLine().Replace(" ", "");
                RunProgram(userInput, prompt, parse, math, stack, running);
            }
        }

        public static void RunProgram(string userInput, Terminal prompt, Expression parse, Operations math, Stack stack, bool running)
        {
            object[] userExpressionObject;
            if (userInput == "lastq" || userInput == "last")
            {
                if (stack.lastQ == null)
                {
                    throw new ArgumentException("Last what? You haven't asked me anything yet.");
                }
                userExpressionObject = stack.lastQ;
                string response;
                response = prompt.ReturnLastExpressionString(stack);
                Console.WriteLine(response);
                if (userInput == "last")
                {
                    string answer = prompt.ReturnExpressionAnswer(math.DoMath(userExpressionObject));
                    response = string.Format(response + answer);
                    Console.WriteLine(answer);
                }
            }
            else if (userInput == "exit" || userInput == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                userExpressionObject = parse.ParseExpression(userInput, stack);
                double answer;
                /*
                if (userExpressionObject[0] is int)
                {
                    userExpressionObject[0] = stack.GetConstant((char)userExpressionObject[0]);
                }
                */
                answer = math.DoMath(userExpressionObject);
                Console.WriteLine(prompt.ReturnExpressionAnswer(answer));
            }
        }
    }
}