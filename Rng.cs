using System;
using System.Collections.Generic;
using UnityEngine;

namespace Engine
{
    public static class Rng
    {
        private static Random sRandom = new Random();
        public static void Seed()
        {
            sRandom = new Random();
        }

        public static void Seed(int seed)
        {
            sRandom = new Random(seed);
        }
        /// <summary>
        /// 返回0～max(不包含)整数
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Int(int max)
        {
            return sRandom.Next(max);
        }
        /// <summary>
        /// 返回min～max(不包含)随机整数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Int(int min,int max)
        {
            return Int(max - min) + min;
        }

        /// <summary>
        /// 返回0～max随机整数
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int IntInclusive(int max)
        {
            return sRandom.Next(max + 1);
        }

        /// <summary>
        /// 返回min～max随机整数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int IntInclusive(int min, int max)
        {
            return IntInclusive(max - min) + min;
        }

        public static float Float(float max)
        {
            if(max<0.0f) throw new ArgumentOutOfRangeException("max必须大于等于0");
            return (float)sRandom.NextDouble() * max;
        }

        public static float Float(float min, float max)
        {
            if(min>max) throw new ArgumentOutOfRangeException("max必须大于min");
            return Float(max - min) + min;
        }

        public static Vector2 Vector2(Vector2 size)
        {
            return new Vector2()
        }
    }
}