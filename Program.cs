using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questionsArr =
            {
                "Kosmosa ucan ilk süni peyk hansıdır?",
                "Bunlardan hansı gilemeyvedir?",
                "İlk sesli film hansıdır?"

            };
            string[] answersArr =
            {
                 " Challenger, Apollon, Sputnik, Azerspeys",
                 " Badam, Erik, Qarpız, Xiyar",
                 " Mavi denizin sahilinde, Cazz oxuyan, Böyük şeherin işıqları, Ehmed haradadır"
            };
            string[] correctArr =
            {
                " Sputnik", " Qarpız", " Cazz oxuyan"
            };
            //int points = 0;
            bool keepRunning = true;
            int yourPoints = 0;
            for (int i = 0; i < questionsArr.Length; i++)
            {
                var question = new Quiz(i + 1, questionsArr[i], answersArr[i], correctArr[i]);
                Console.WriteLine( question.number +"." + question.question + '\n');
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine((char)((int)'a'+j) + ")" + question.answers[j]  );
                }
                Console.Write("Cavabinizi daxil edin : ");
                string yourAnswer;
                
               
                while (true)
                {
                    yourAnswer = Console.ReadLine();
                    if ((int)yourAnswer[0] >= (int)'a' && (int)yourAnswer[0] <= (int)'e')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun variantlar a - d araliqinda olmalidir");
                        Console.Write("Cavabinizi daxil edin : ");                      
                    }

                }
                int pointer = (int)yourAnswer[0] - (int)'a';
                if (question.answers[pointer] == question.correct)
                {
                    yourPoints = yourPoints + 10;
                    
                }
                
                
                
                
            }
            Console.WriteLine("Sizin xaliniz 30 uzerinden {0} ",yourPoints);



        }
    }

}
