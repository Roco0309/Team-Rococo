using UnityEngine;

public class CameraManager : MonoBehaviour
{
    GameObject gPlayer;
    GameObject gCamera;
    GameObject gCameraArm;
    GameObject gCameraVector;
    GameObject gCameraAxis;

    Transform tPlayerTransform;
    Vector3 vCameraPos;
    Vector3 vCameraArmPos;

    float vMouseSensitivity;
    float vXRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gPlayer = SystemData.I.sPlayerInfo.gPlayer;
        tPlayerTransform = gPlayer.transform;
        vMouseSensitivity = SystemData.I.sLocalSetting.vMouseSensitivity;
    }

    // Update is called once per frame
    void Update()
    {
        float vMouseX = Input.GetAxis("Mouse X") * vMouseSensitivity * Time.deltaTime;
        float vMouseY = Input.GetAxis("Mouse Y") * vMouseSensitivity * Time.deltaTime;

        
        vCameraArmPos = gCameraArm.transform.position;
        gCameraArm.transform.position += (tPlayerTransform.position - vCameraArmPos) * SystemData.I.sPlayerInfo.vMoveSpeed;
    }
}
