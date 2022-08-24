//Shady
using UnityEngine;

[ExecuteInEditMode]
public class Reveal : MonoBehaviour
{
    [SerializeField] Material Mat;
    [SerializeField] Light SpotLight;
    [SerializeField] PlayerLight lightOn;
	
	void Update ()
    {
        if(Mat && SpotLight && lightOn.flashLightEnable)
        {
            Mat.SetVector("MyLightPosition",  SpotLight.transform.position);
            Mat.SetVector("MyLightDirection", -SpotLight.transform.forward );
            Mat.SetFloat ("MyLightAngle", SpotLight.spotAngle);
        }
        else
        {
            Mat.SetFloat("MyLightAngle", 0);
        }
    }//Update() end
}//class end