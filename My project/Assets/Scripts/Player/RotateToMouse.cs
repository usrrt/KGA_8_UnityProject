using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    private float limitMinX = -80; // 시점 위아래 범위
    private float limitMaxX = 50;

    private float eulerAngleX; 
    private float eulerAngleY;

    

    public void UpdateRotate(float mouseX, float mouseY)
    {
        // 마우스 좌/우 이동으로 카메라 y축 회전
        eulerAngleY += mouseX * Gamemanager.Instance.lookSensitivity;

        // 마우스 상/하 이동으로 카메라 x축 회전
        // 마우스를 아래로 내리면 음수인데 오브젝트의 x축이 +방향으로 회전해야 아래를 보기때문에 -=감소연산자로 설정
        eulerAngleX -= mouseY * Gamemanager.Instance.lookSensitivity;

        // 카메라 x축 회전의 경우 회전 범위를 설정해야한다
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
