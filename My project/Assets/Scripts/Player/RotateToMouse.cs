using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    private float limitMinX = -80; // ���� ���Ʒ� ����
    private float limitMaxX = 50;

    private float eulerAngleX; 
    private float eulerAngleY;

    

    public void UpdateRotate(float mouseX, float mouseY)
    {
        // ���콺 ��/�� �̵����� ī�޶� y�� ȸ��
        eulerAngleY += mouseX * Gamemanager.Instance.lookSensitivity;

        // ���콺 ��/�� �̵����� ī�޶� x�� ȸ��
        // ���콺�� �Ʒ��� ������ �����ε� ������Ʈ�� x���� +�������� ȸ���ؾ� �Ʒ��� ���⶧���� -=���ҿ����ڷ� ����
        eulerAngleX -= mouseY * Gamemanager.Instance.lookSensitivity;

        // ī�޶� x�� ȸ���� ��� ȸ�� ������ �����ؾ��Ѵ�
        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);

        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;

        if (angle > 360)
            angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
