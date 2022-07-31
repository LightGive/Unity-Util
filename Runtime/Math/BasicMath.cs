using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LightGive.UnityUtil.Math
{
	/// <summary>
	/// ��b�I�Ȍv�Z
	/// </summary>
	public class BasicMath
	{
        /// <summary>
        /// �Ђ��`�̓��O����
        /// ���p��180�x�ȉ��ł��鎖���O��
        /// </summary>
        /// <returns></returns>
        public static bool PointInOutForSquareInteriorAngleIn180Dgree(Vector3 checkPoint, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
        {
            var ab = Vector3.Cross(b - a, b - checkPoint).z;
            var bc = Vector3.Cross(c - b, c - checkPoint).z;
            var cd = Vector3.Cross(d - c, d - checkPoint).z;
            var da = Vector3.Cross(a - d, a - checkPoint).z;
            return
                (ab > 0 && bc > 0 && cd > 0 && da > 0) ||
                (ab < 0 && bc < 0 && cd < 0 && da < 0);
        }
    }
}