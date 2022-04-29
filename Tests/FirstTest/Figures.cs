using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    public static class Figures
    {
        public static double GetIntersection(Rectangle r1, Rectangle r2)
        {
            var r1TopRightCorner = r1.TopLeftCorner + r1.SizeX;
            var r2TopRightCorner = r2.TopLeftCorner + r2.SizeX;

            if (r1.TopLeftCorner == r2.TopLeftCorner)
                return r1.TopLeftCorner;

            if (r1.TopLeftCorner > r2.TopLeftCorner && r1.TopLeftCorner < r2TopRightCorner)
                return r1.TopLeftCorner; //la interseccion esta en el extremo izquierdo del rectangulo 1

            if (r2.TopLeftCorner > r1.TopLeftCorner && r2.TopLeftCorner < r1TopRightCorner)
                return r2.TopLeftCorner; //la interseccion esta en el extremo izquierdo del rectangulo 2

            return -1;
        }
    }
}
