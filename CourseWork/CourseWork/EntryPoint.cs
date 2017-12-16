using System;

namespace CourseWork
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            SaastamoinenModel saastamoinenModel = new SaastamoinenModel();
            BlackModel blackModel = new BlackModel();
            HopfieldModel hopfieldModel = new HopfieldModel();
            NeilModel neilModel = new NeilModel();
            Console.WriteLine(saastamoinenModel.ToString());
            Console.WriteLine(blackModel.ToString());
            Console.WriteLine(hopfieldModel.ToString());
            Console.WriteLine(neilModel.ToString());
        }
    }
}
