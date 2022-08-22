using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    private float limitMinX = -85; // ���� ���Ʒ� ����
    private float limitMaxX = 70;

    private float eulerAngleX; 
    private float eulerAngleY;

    public Camera sight;

    public void CameraRotate(float mouseY)
    {
        // ���콺 ��/�� �̵����� ī�޶� x�� ȸ��
        // ���콺�� �Ʒ��� ������ �����ε� ������Ʈ�� x���� +�������� ȸ���ؾ� �Ʒ��� ���⶧���� -=���ҿ����ڷ� ����
        eulerAngleX -= mouseY * GameManager.Instance.lookSensitivity;
        // ī�޶� x�� ȸ���� ��� ȸ�� ������ �����ؾ��Ѵ�
        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);

        sight.transform.localEulerAngles = new Vector3(eulerAngleX, 0, 0);

    }

    public void CharacterRotate(float mouseX)
    {
        // ���콺 ��/�� �̵����� ī�޶� y�� ȸ��
        eulerAngleY += mouseX * GameManager.Instance.lookSensitivity;

        transform.rotation = Quaternion.Euler(0, eulerAngleY, 0);
    }

    /// <summary>
    /// ��,�Ʒ� ���� ���� ����
    /// </summary>
    /// <param name="angle"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;

        if (angle > 360)
            angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
