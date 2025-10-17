using Unity.VisualScripting;

using UnityEngine;

public class CameraManager : MonoBehaviour
{
    GameObject gPlayer;
    GameObject gCamera;
    GameObject gCameraArm;
    GameObject gCameraVector;
    GameObject gCameraAxis;
    [SerializeField]
    GameObject Eyepos;

    Transform tPlayerTransform;
    Vector3 vCameraPos;
    Vector3 vCameraArmPos;
    Vector2 vCameraRotation = Vector2.zero;
    Quaternion vCameraQuatX, vCameraQuatY;

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
        float vMouseX = Input.GetAxis("Mouse X") * vMouseSensitivity;
        float vMouseY = Input.GetAxis("Mouse Y") * vMouseSensitivity;

        vCameraRotation.x += vMouseX;
        vCameraRotation.y += vMouseY;
        vCameraRotation.y = Mathf.Clamp(vCameraRotation.y, -90f, 90f);

        vCameraQuatX = Quaternion.AngleAxis(vCameraRotation.x, Vector3.up);
        vCameraQuatY = Quaternion.AngleAxis(vCameraRotation.y, Vector3.left);
        SystemData.I.sPlayerInfo.vCameraQuatX = vCameraQuatX;

        transform.position = Eyepos.transform.position;
        transform.rotation = vCameraQuatX * vCameraQuatY;
        
    }
}
