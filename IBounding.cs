using Assimp;
using System.Numerics;

namespace RayTracingInCSharp
{
    public enum BoundingType
    {
        AABox = 1,
        Sphere = 2,
    }
    public interface IBounding
    {

        BoundingType GetWarpMode { get; }
        bool isIntersect(Ray ray, Vector3 startPoint);
    }

    public class AABoundingBox : IBounding
    {
        /// <summary>
        /// 包围的网格
        /// </summary>
        Node meshRef;
        //AABoundingBox
        public BoundingType GetWarpMode => BoundingType.AABox;
        public bool isIntersect(Ray ray, Vector3 startPoint)
        {
            return true;
        }
    }

    public class BoundingSphere : IBounding
    {
        Vector3 center;
        float radius;

        public BoundingSphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public BoundingSphere(Mesh mesh)
        {
            if (mesh.Vertices.Count == 0)
            {
                center = Vector3.Zero;
                radius = 0f;
                return;
            }

            Vector3 min = new Vector3(float.MaxValue);
            Vector3 max = new Vector3(float.MinValue);
            Vector3 temp = Vector3.Zero;

            foreach (var vertex in mesh.Vertices)
            {
                temp.X = vertex.X; temp.Y = vertex.Y; temp.Z = vertex.Z;
                min = Vector3.Min(min, temp);
                max = Vector3.Max(max, temp);
            }

            Vector3 boxCenter = (min + max) / 2.0f;
            Vector3 boxSize = max - min;
            float boxDiagonal = boxSize.Length();

            radius = boxDiagonal / 2.0f;
            center = boxCenter;
        }

        // Impl
        public BoundingType GetWarpMode => BoundingType.Sphere;

        public bool isIntersect(Ray ray, Vector3 startPoint)
        {
            return true;
        }
    }
}
