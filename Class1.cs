using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Delegates
{
    public delegate void GradeChange(double avg);
    class Student
    {
        string fullname;
        double gpa;
        int units;
        public event GradeChange Targets;
        public string FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }
        public Student(string name,double avg,int count)
        {
            FullName = name;
            gpa = avg;
            units = count;
        }
        public void RecordClass(double grade)
        {
            gpa = (gpa * units + grade) / (units + 1);
            units++;
            if(Targets!=null)
            Targets(gpa);
        }
    }
    //-----------------
    class parent
    {
        string fname;
        public parent(string name)
        {
            fname = name;
        }
        public void Report(double avg)
        {
            string s;
            s = "I'm " + fname + "\nOne of the parents" + "\nMy child's GPA has reported to me and that is : " + avg.ToString();
            MessageBox.Show(s);
        }
    }

    //------------------
    class Registrar
    {
        public void log(double avg)
        {
            string s;
            s = "I'm the registrar \nI've loged your GPA\nYour GPA is: " + avg.ToString();
            MessageBox.Show(s);
        }
    }
}
