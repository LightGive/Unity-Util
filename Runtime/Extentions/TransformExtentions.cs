using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LightGive.UnityUtil
{
    public static class TransformExtentions
    {
        /// <summary>
        /// Z���W�͂��̂܂܂�X,Y���W��ݒ肵�܂�
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void SetPosition2D(this Transform transform, float x, float y)
        {
            transform.position = new Vector3(x, y, transform.position.z);
        }

        /// <summary>
        /// Z���W�͂��̂܂܂�X,Y���W��ݒ肵�܂�
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="position"></param>
        public static void SetPosition2D(this Transform transform,Vector2 position)
		{
            transform.position = new Vector3(position.x, position.y, transform.position.z);
		}
    }
}