using System.Drawing;
using System.Numerics;

namespace miniRenderer
{
    internal class Triangle
    {
        public Vector3[] point = new Vector3[] { Vector3.Zero, Vector3.Zero, Vector3.Zero, };
        public Color[] colors = new Color[] { Color.Black, Color.Black, Color.Black };
        public Vector2[] tex_coords = new Vector2[] { Vector2.Zero, Vector2.Zero, Vector2.Zero };
        public Vector3[] normal = new Vector3[3];

        public Triangle(Vector3 point1, Vector3 point2, Vector3 point3)
        {
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
        }

        public void SetNormal(int ind, Vector3 normal)
        {
            this.normal[ind] = normal;
        }

        public void SetVertex(int ind, Vector3 ver)
        {
            point[ind] = ver;
        }

        public void SetColor(int ind, Color color)
        {
            colors[ind] = color;
        }

        public void SetTexCoord(int ind, float s, float t)
        {
            tex_coords[ind] = new Vector2(s, t);
        }

        public Vector4[] ToVector4()
        {
            Vector4 v1 = new Vector4(point1, 0);
            Vector4 v2 = new Vector4(point2, 0);
            Vector4 v3 = new Vector4(point3, 0);
            return new Vector4[] { v1, v2, v3 };
        }
    }
}