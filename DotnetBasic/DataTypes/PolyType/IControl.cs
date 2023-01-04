using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.PolyType
{
    public interface IControl
    {
        void Paint();
        void Create();
    }

    public interface ISurface
    {
        void Paint();
        void Draw();
    }

    public class SampleClassImplement : IControl, ISurface
    {
        public void Create()
        {
            Console.WriteLine("Create method in SampleClass");
        }

        public void Draw()
        {
            Console.WriteLine("Draw method in SampleClass");
        }

        // Both ISurface.Paint and IControl.Paint call this method.
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }

        public static void InterfaceImplement()
        {
            SampleClassImplement sample = new SampleClassImplement();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            sample.Paint();
            sample.Create();
            sample.Draw();

            control.Paint();
            control.Create();

            surface.Paint();
            surface.Draw();

            // Output:
            // Paint method in SampleClass
            // Paint method in SampleClass
            // Paint method in SampleClass
        }
    }

}
