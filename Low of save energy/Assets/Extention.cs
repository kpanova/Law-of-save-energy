using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public static class Extention
    {
        public static void MoveByZ(this GameObject obj, float step)
        {
            obj.transform.Translate(0, 0, step);
        }
        public static void RotateByZ(this GameObject obj, float value)
        {
            obj.transform.Rotate(0, 0, value, Space.World);
        }
    }
}
