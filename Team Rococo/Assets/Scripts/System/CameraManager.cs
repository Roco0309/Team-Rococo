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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gPlayer = SystemData.I.sPlayerInfo.gPlayer;
        tPlayerTransform = gPlayer.transform;
    }

    // Update is called once per frame
    void Update()
    {
        vCameraArmPos = gCameraArm.transform.position;
        gCameraArm.transform.position += (tPlayerTransform.position - vCameraArmPos) * SystemData.I.sPlayerInfo.vMoveSpeed;
    }
}
