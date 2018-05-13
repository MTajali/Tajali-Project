using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndExam
{
    class Exam : IEnumerable,IEnumerator
    {
       
        public string ExamName { get; set; }
        public int Time { get; set; }
        public int QuestCount { get; set; }
        public string Teacher { get; set; }
        public List<Question> questions { get; set; }
        private int position = -1; 
        public object Current
        {
            get
            {
                return questions[position];
            }
        }
        public Exam(List<Question> questions)
        {
            questions = new List<Question>();
           
        }

        public IEnumerator GetEnumerator()
        {
            return new Exam(questions);
        }

        public bool MoveNext()
        {
            if (position <= questions.Capacity)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
        public override string ToString()
        {
            return $"ExamName: {ExamName}\tQuestCount:{QuestCount}\tTeacher:{Teacher}\tTimeExam:{Time}";
        }
    }
}

