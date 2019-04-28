using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_folder
{
    class Program
    {
        public static List<Question> Questions { get; set; }

        static void Main(string[] args)
        {
            //Prepare array
            PopulateQuestions();

            //Instructions
            Console.WriteLine("Here are a few riddles to test your smarts.");
            Console.WriteLine("Also you can only answer each question ONCE.");
            Console.WriteLine("Think carefully before answering...");
            Console.WriteLine();
            Console.WriteLine();

            //For Loop
            foreach (Question q in Questions)
            {
                //Call Question method to current question number
                AskQuestion(q);
            }


            //Calculate Results
            CalcResults();

            //Write thanks for playing
            Console.WriteLine("");
            Console.WriteLine("Thanks for playing this game thingy. Press any key to close me.");
            Console.ReadLine();


        }

        public static void PopulateQuestions()
        {
            //  QID (int) | QuestionText (string) | Answer (ucase(string)) | Correct (int) | Incorrect (int)
            Questions = new List<Question>();

            //Question 1
            Question q1 = new Question();
            q1.QID = 1;
            q1.QuestionText = "If a car key would open a car, and a house key opens a house, then what key opens a banana?";
            q1.Answer = "MONKEY";
            q1.Correct = 0;
            q1.Incorrect = 0;
            Questions.Add(q1);

            //Question 2
            Question q2 = new Question();
            q2.QID = 2;
            q2.QuestionText = "I stand when I'm sitting, and jump when I'm walking. Who am I?";
            q2.Answer = "KANGAROO";
            q2.Correct = 0;
            q2.Incorrect = 0;
            Questions.Add(q2);

            //Question 3
            Question q3 = new Question();
            q3.QID = 3;
            q3.QuestionText = "The more you take, the more you leave behind. What am I?";
            q3.Answer = "FINGERPRINTS";
            q3.Correct = 0;
            q3.Incorrect = 0;
            Questions.Add(q3);

            //Question 4
            Question q4 = new Question();
            q4.QID = 4;
            q4.QuestionText = "Give me food, and I will live. Give me water and I will die. What am I?";
            q4.Answer = "FIRE";
            q4.Correct = 0;
            q4.Incorrect = 0;
            Questions.Add(q4);

            //Question 5
            Question q5 = new Question();
            q5.QID = 5;
            q5.QuestionText = "I hide behind rocks and rills, under the mountains and hills. I cannot be seen or felt, nor heard or smelt. The more I am, the less you see. What am I?";
            q5.Answer = "DARKNESS";
            q5.Correct = 0;
            q5.Incorrect = 0;
            Questions.Add(q5);

        }

        public static void AskQuestion(Question Q)
        {
            //get array record fields

            //Ask question
            Console.WriteLine("Question " + Q.QID.ToString());
            Console.WriteLine(Q.QuestionText);

            //get input
            string input = Console.ReadLine();

            //Check input against array using ucase
            //If statement:
            if (input.ToUpper() == Q.Answer)
            {

                //if correct:
                //set array correct answer to 1
                //write they were correct
                //return

                Q.Correct = 1;
                Console.WriteLine("Yay, you did it!");
                Console.WriteLine();
            }

            else
            {

                //if incorrect:
                //set array incorrect answer to 1
                //write they were incorrect
                //return

                Q.Incorrect = 1;
                Console.WriteLine("Wrong answer.");
                Console.WriteLine();
            }

        }

        public static void CalcResults()
        {
            //Loop through array, show the question number, and correct and incorrect answers and write results.
            int ctot = 0;
            int itot = 0;
            foreach (Question q in Questions)
            {
                ctot += q.Correct;
                itot += q.Incorrect;
            }
            Console.WriteLine("");
            Console.WriteLine("Here is your score...");
            Console.WriteLine("Correct: " + ctot.ToString());
            Console.WriteLine("Incorrect: " + itot.ToString());
            Console.WriteLine("");
        }
    }

    public class Question
    {
        //  QID (int) | QuestionText (string) | Answer (ucase(string)) | Correct (int) | Incorrect (int)

        //QID
        public int QID { get; set; }

        //QuestionText
        public string QuestionText { get; set; }

        //Answer
        private string answer;

        public string Answer
        {
            get { return answer.ToUpper(); }
            set { answer = value.ToUpper(); }
        }

        //Correct
        public int Correct { get; set; }

        //Incorrect
        public int Incorrect { get; set; }
    }
}
