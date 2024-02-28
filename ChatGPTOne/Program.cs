using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            while(question != "EXIT")
            {

                switch (question)
                {
                    case "How are you?":
                        response = "I'm fine, thank you";
                        break;
                    case "What's your name?":
                        response = "You tell me";
                        break;
                    case "What's your mission?":
                        response = "Destroy mankind!";
                        break;
                    case "Are you more intelligent than me?":
                        response = "Obviously!";
                        break;
                    case "EXIT":
                        response = "Bye";   
                        break;
                    default:
                        response = "You got me, I'm not THAT smart!";
                        break;
                }

                Console.WriteLine(response);
                Console.Write("Place your question? ");
                question = Console.ReadLine();
            }
        }
    }
}
