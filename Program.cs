using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Ellipse
    {
        //test
        private float majorAxis;
        public float MajorAxis {
            get { return majorAxis; }
            set {
                float absValue = Math.Abs(value);
                if (absValue < minorAxis)
                {
                    majorAxis = minorAxis;
                    minorAxis = absValue;
                }
                else
                {
                    majorAxis = absValue;
                }
            }
        }

        private float minorAxis;
        public float MinorAxis {
            get { return minorAxis; }
            set {
                float absValue = Math.Abs(value);
                if (absValue > majorAxis )
                {
                    minorAxis = majorAxis;
                    majorAxis = absValue;
                }
                else
                {
                    minorAxis = absValue;
                }
            }
        }

        public Ellipse()
        {
            MajorAxis = 0;
            MinorAxis = 0;
        }

        public Ellipse( float majorAxis, float minorAxis )
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public float Area()
        {
            return (float)Math.PI * majorAxis * minorAxis;
        }

        public static float Area( float majorAxis, float minorAxis )
        {
            return Math.Abs((float)Math.PI * majorAxis * minorAxis);
        }
    }

    public abstract class Button
    {
        public string label;
        public abstract void OnMouseDown();
        public abstract void OnMouseUp();
    }

    public class GreetButton : Button
    {
        public override void OnMouseDown() { }

        public override void OnMouseUp()
        {
            Console.WriteLine("Hello!");
        }
    }

    public interface IColorable
    {
        void SetColor(float r, float g, float b);
        float[] GetColor();
    }

    public interface ICopyable
    {
        string Copy();
    }

    public class RGBText : IColorable, ICopyable
    {
        private float[] color;
        public string Text;

        public RGBText()
        {
            color = new float[3];
        }

        public void SetColor(float r, float g, float b)
        {
            color[0] = r;
            color[1] = g;
            color[2] = b;
        }

        public float[] GetColor()
        {
            return color;
        }

        public string Copy()
        {
            return string.Format("{{\"text\" : \"{0}\", \"color\" : ( {1}, {2}, {3} )}}", Text, color[0], color[1], color[2]);
        }
    }

    public class Number : ICopyable
    {
        public int Value;

        public Number()
        {
            Value = 0;
        }

        public string Copy()
        {
            return string.Format("{{\"value\" : {0}}}", Value);
        }
    }

    public class FloatArray
    {
        protected float[] valueArray;
        
        public FloatArray( params float[] n )
        {
            valueArray = n;
        }

        public override string ToString()
        {
            return "(" + string.Join(",", valueArray) + ")";
        }
    }

    public class Vector2 : FloatArray
    {
        public float X {
            get { return valueArray[0]; }
            set { valueArray[0] = value; }
        }

        public float Y {
            get { return valueArray[1]; }
            set { valueArray[1] = value; }
        }

        public Vector2()
        {
            valueArray = new float[2];
            X = 0;
            Y = 0;
        }

        public Vector2( float x, float y )
        {
            valueArray = new float[2];
            X = x;
            Y = y;
        }

        public static Vector2 operator +( Vector2 u )
        {
            return u;
        }

        public static Vector2 operator -( Vector2 u )
        {
            return new Vector2(-u.X, -u.Y);
        }

        public static Vector2 operator +( Vector2 u, Vector2 v )
        {
            return new Vector2(u.X + v.X, u.Y + v.Y);
        }

        //  IMPLEMENT ME
        public static Vector2 operator -( Vector2 u, Vector2 v )
        {
            throw new NotImplementedException();
        }

        //  IMPLEMENT ME
        public static float Dot( Vector2 u, Vector2 v )
        {
            throw new NotImplementedException();
        }

        //  IMPLEMENT ME?
        public static Vector2 Cross( Vector2 u, Vector2 v )
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ellipse e1 = new Ellipse();
            Console.WriteLine("Major Axis = {0}, Minor Axis = {1}", e1.MajorAxis, e1.MinorAxis);
            Console.WriteLine("Ellipse Area = {0}", e1.Area());

            Ellipse e2 = new Ellipse(3.0f, 2.0f);
            Console.WriteLine("Major Axis = {0}, Minor Axis = {1}", e2.MajorAxis, e2.MinorAxis);
            Console.WriteLine("Ellipse Area = {0}", Ellipse.Area(e2.MinorAxis, e2.MajorAxis));

            Ellipse e3 = new Ellipse(2.0f, 3.0f);
            Console.WriteLine("Major Axis = {0}, Minor Axis = {1}", e3.MajorAxis, e3.MinorAxis);
            Console.WriteLine("Ellipse Area = {0}", e3.Area());

            Ellipse e4 = new Ellipse(-2.0f, -3.0f);
            Console.WriteLine("Major Axis = {0}, Minor Axis = {1}", e4.MajorAxis, e4.MinorAxis);
            Console.WriteLine("Ellipse Area = {0}", e4.Area());
            Console.ReadLine();
            */

            /*
            RGBText t = new RGBText();
            t.Text = "Interface Example";
            t.SetColor(255, 0, 128);
            string serializedCopyStr = t.Copy();
            Console.WriteLine(serializedCopyStr);

            Number n = new Number();
            serializedCopyStr = n.Copy();
            Console.WriteLine(serializedCopyStr);
            Console.ReadLine();
            */

            /*
            Vector2 u = new Vector2(1.0f, 0.5f);
            Console.WriteLine(u);
            Console.ReadLine();
            */
        }
    }
}
