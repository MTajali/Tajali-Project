using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAndExam
{

    class Question
    {
        public string Subject { get; set; }
        public string Questfase { get; set; }
        public Dificultly Dificultly { get; set; }
        public double Mark { get; set; }
        public int Time{ get; set; }


        public override string ToString()
        {
            return $"Subject:{Subject}\tDificultly:{Dificultly}\tMark:{Mark}\tTime:{Time} minute\n{Questfase}";
        }
    }

}
    

