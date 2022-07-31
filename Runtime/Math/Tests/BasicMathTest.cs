using NUnit.Framework;
using UnityEngine;

namespace LightGive.UnityUtil.Math
{
	public class BasicMathTest
	{
		[Test]
		public void PointInOutForSquareInteriorAngleIn180DgreeTest()
		{
			Vector3[] square = new Vector3[]
			{
				new Vector3(-0.5f,-0.5f,0.0f),
				new Vector3(-0.5f,0.5f,0.0f),
				new Vector3(0.5f,0.5f,0.0f),
				new Vector3(0.5f,-0.5f,0.0f)
			};

			// �E���ƍ����ňႢ��������
			// �O�㍶�E�ňႢ��������
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.zero, square[0], square[1], square[2], square[3]), Is.EqualTo(true));
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.zero, square[3], square[2], square[1], square[0]), Is.EqualTo(true));
			// �E
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.right, square[0], square[1], square[2], square[3]), Is.EqualTo(false));
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.right, square[3], square[2], square[1], square[0]), Is.EqualTo(false));
			// ��
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.left, square[0], square[1], square[2], square[3]), Is.EqualTo(false));
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.left, square[3], square[2], square[1], square[0]), Is.EqualTo(false));
			// ��
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.up, square[0], square[1], square[2], square[3]), Is.EqualTo(false));
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.up, square[3], square[2], square[1], square[0]), Is.EqualTo(false));
			// ��
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.down, square[3], square[2], square[1], square[0]), Is.EqualTo(false));
			Assert.That(BasicMath.PointInOutForSquareInteriorAngleIn180Dgree(Vector3.down, square[3], square[2], square[1], square[0]), Is.EqualTo(false));
		}
	}
}