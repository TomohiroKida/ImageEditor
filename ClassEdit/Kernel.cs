using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditClass
{
    public static class Kernel
    {
        private static readonly float[,] onenine = new float[3, 3] { { 1f / 9f, 1f / 9f, 1f / 9f }, { 1f / 9f, 1f / 9f, 1f / 9f }, { 1f / 9f, 1f / 9f, 1f / 9f } };

        public static float[,] OneNine
        {
            get
            {
                return onenine;
            }
        }
    }
}
