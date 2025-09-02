using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SystemInit : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = SystemData.vFPS;
        SystemData.I.sPlayerInfo.gPlayer = GameObject.FindGameObjectWithTag("Player");
        if (SystemData.I.sPlayerInfo.gPlayer == null )
        {
            SystemData.I.QuitProcess("Error :: gPlayer is null");
        }
        SystemData.I.sPlayerInfo.vDashSpeed = 5.0f;
        SystemData.I.sPlayerInfo.vMoveSpeed = 5.0f;
        SystemData.I.sPlayerInfo.vJumpPower = 2.0f;
        SystemData.I.sPlayerInfo.vGravityScale = 2.0f;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
