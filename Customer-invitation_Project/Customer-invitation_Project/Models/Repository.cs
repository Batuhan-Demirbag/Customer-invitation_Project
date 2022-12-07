using System.Collections.Generic;

namespace Customer_invitation_Project.Models
{
    public class Repository
    {
        //Model Binding
        private static List<Answer> answers=new List<Answer>();
        public static IEnumerable<Answer> Answers => answers;

        public static void SendAnswer(Answer answer)
        {
            answers.Add(answer);
        }

    }
}
