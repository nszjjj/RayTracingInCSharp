using System;
using System.Numerics;

namespace RayTracingInCSharp.Utils
{
    static public class CameraUtils
    {
        /// <summary>
        /// 将水平FOV转换为垂直FOV
        /// </summary>
        /// <param name="horizontalFOV">水平FOV，单位是弧度</param>
        /// <param name="aspectRatio">视口的宽高比</param>
        /// <returns>垂直FOV，单位是弧度</returns>
        public static float Convert2VerticalFOV(float horizontalFOV, float aspectRatio)
        {
            // 计算水平FOV的一半的切线值
            float tanHorizontalFOV = (float)Math.Tan(horizontalFOV / 2.0f);
            // 计算垂直FOV的一半的切线值
            float tanVerticalFOV = tanHorizontalFOV / aspectRatio;
            // 计算垂直FOV的弧度
            float verticalFOVRadians = (float)Math.Atan(tanVerticalFOV) * 2.0f;
            return verticalFOVRadians;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="horizontalFOV">水平FOV，单位是弧度</param>
        /// <param name="focalLegnth"></param>
        /// <returns></returns>
        public static float CalViewportWidth(float horizontalFOV, float focalLegnth)
        {
            return (float)Math.Tan(horizontalFOV / 2) * focalLegnth * 2;
        }

        /// <summary>
        /// 列主序（等会验证一下Mesh里存的是不是列主序
        /// </summary>
        /// <param name="viewMatrix"></param>
        /// <returns></returns>
        public static (Vector3, Vector3) CalViewportDir(Assimp.Matrix4x4 viewMatrix)
        {
            Vector3 rightDirection = new Vector3(
            viewMatrix[0, 0],
            viewMatrix[1, 0],
            viewMatrix[2, 0]
        );

            // 成像面纵向方向
            Vector3 upDirection = new Vector3(
                viewMatrix[0, 1],
                viewMatrix[1, 1],
                viewMatrix[2, 1]
            );

            return (rightDirection, upDirection);
        }
    }
}
