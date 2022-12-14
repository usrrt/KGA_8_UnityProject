using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    private float limitMinX = -85; // 시점 위아래 범위
    private float limitMaxX = 70;

    private float eulerAngleX; 
    private float eulerAngleY;

    public Camera sight;

    public void CameraRotate(float mouseY)
    {
        // 마우스 상/하 이동으로 카메라 x축 회전
        // 마우스를 아래로 내리면 음수인데 오브젝트의 x축이 +방향으로 회전해야 아래를 보기때문에 -=감소연산자로 설정
        eulerAngleX -= mouseY * GameManager.Instance.lookSensitivity;
        // 카메라 x축 회전의 경우 회전 범위를 설정해야한다
        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);

        sight.transform.localEulerAngles = new Vector3(eulerAngleX, 0, 0);
        //sight.transform.eulerAngles = new Vector3(eulerAngleX, 0, 0);

    }

    public void CharacterRotate(float mouseX)
    {
        // 마우스 좌/우 이동으로 카메라 y축 회전
        eulerAngleY += mouseX * GameManager.Instance.lookSensitivity;

        transform.rotation = Quaternion.Euler(0, eulerAngleY, 0);
    }

    /// <summary>
    /// 위,아래 시점 범위 제한
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
