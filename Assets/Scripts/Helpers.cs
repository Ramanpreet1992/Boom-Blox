using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers
{
    public static float NormalizeAngle(float angle)
    {
        if (angle > 180f) return angle - 360f;
        else if (angle < -180f) return angle + 360f;
        return angle;
    }
}
