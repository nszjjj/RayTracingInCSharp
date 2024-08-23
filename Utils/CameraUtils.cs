using System;

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
    }
}
