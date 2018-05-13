using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndExam
{
    class QuestionDificultly : IComparer<Question>
    {
        public int Compare(Question x, Question y)
        {
            return (x.Dificultly).CompareTo(y.Dificultly);
        }
    }
}
