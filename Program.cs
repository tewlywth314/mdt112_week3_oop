using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class FloatArray
    {
        private float[] valueArray;
        public float[] ValueArray {
            get { return valueArray; }
            set { valueArray = value; }
        }
        
        public FloatArray( params float[] n )
        {
            valueArray = n;
        }

        public override string ToString()
        {
            return "(" + string.Join(",", ValueArray) + ")";
        }
    }

    public class Vector2 : FloatArray
    {
        public float X {
            get { return ValueArray[0]; }
            set { ValueArray[0] = value; }
        }

        public float Y {
            get { return ValueArray[1]; }
            set { ValueArray[1] = value; }
        }

        public Vector2()
        {
            ValueArray = new float[2];
            X = 0;
            Y = 0;
        }

        public Vector2( float x, float y )
        {
            ValueArray = new float[2];
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
            Vector2 u = new Vector2(1.0f, 0.5f);
            Console.WriteLine(u);
            Console.Read();
        }
    }
}
