using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace miniRenderer
{
    public enum Buffers
    {
        Color = 1,
        Depth = 2
    }

    public enum Primitive
    {
        Line,
        Triangle
    }

    public struct Buffer
    {
        public Buffers Buffers;

        public static Buffers operator &(Buffer a, Buffer b)
        {
            var reBuffer = (int)a.Buffers & (int)b.Buffers;
            return (Buffers)reBuffer;
        }

        public static Buffers operator |(Buffer a, Buffer b)
        {
            var reBuffer = (int)a.Buffers | (int)b.Buffers;
            return (Buffers)reBuffer;
        }
    }

    internal struct ind_buf_id
    {
        private int ind_id;
    }

    internal struct pos_buf_id
    {
        private int pos_id;
    }

    internal class Rasterizer
    {
        private Matrix4X4 model;
        private Matrix4X4 view;
        private Matrix4X4 projection;
        private Dictionary<int, Vector3> posBuf;
        private Dictionary<int, Vector3> indBuf;
        private List<Vector3> frameBufl;
        private List<float> depthBuf;

        private int GetIndex(int x, int y)
        {

        }

        private int GetNextId()
        {
        }

        private int width, height;
        private int nextId = 0;

        public Rasterizer(int w, int h)
        {
        }

        public void Clear(Buffers buff)
        {
        }

        public void Draw(pos_buf_id posBuffer, ind_buf_id indBuffer, Primitive type)
        {
        }

        public Vector3 FrameBuffer()
        {
        }

        public void SetModel(Matrix4X4 m)
        {
        }

        public void SetPixel(Vector3 point, Color color)
        {
        }

        public void SetProjection(Matrix4X4 p)
        {
        }

        public void SetView(Matrix4X4 v)
        {
        }

        private ind_buf_id LoadIndices(Vector3 positions)
        {
        }

        private pos_buf_id LoadPostions(Vector3 positions)
        {
        }
    }
}