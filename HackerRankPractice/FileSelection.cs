using System;
namespace HackerRankPractice
{
    public class FileSelection
    {
        //Create new object of new program in each file and call
        //the constructor to run the program class file and comment out
        //the other class object
        public FileSelection()
        {
            //FunnyString funnyString = new FunnyString();
            //GemStone gemStone = new GemStone();
            GradingStudent gradingStudent = new GradingStudent();
            AppleAndOrange appleAndOrange = new AppleAndOrange();
        }
    }
}
