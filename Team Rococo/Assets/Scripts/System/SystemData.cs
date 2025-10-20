using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SystemData
{
    static private SystemData pInstance;
    public const int vFPS = 60;
    static public SystemData I
    {
        get
        {
            if (pInstance != null)
            {
                return pInstance;
            }
            pInstance = new SystemData();
            return pInstance;
        }
    }

    public void QuitProcess(string tString)
    {
#if UNITY_EDITOR
        Debug.LogError(tString);
        EditorApplication.ExecuteMenuItem("Edit/Play");
#else
                Application.Quit();
#endif
    }

    public struct PLAYER_INFO
    {
        public GameObject gPlayer;
        public Rigidbody rPlayer;
        public PlayerController playerController;

        public Quaternion vCameraQuatX;

        public float vMoveSpeed;
        public float vJumpPower;
        public float vDashCool;
        public float vDashSpeed;
        public float vGravityScale;

        public int vPlayerLevel;
        public int v;
        public int vNodPoint;
        public int vUsingNodPoint;

        public float vDefaultATK;
        public float vFinalATK;
        public float vDefaultDefense;
        public float vFinalDefense;
    };
    public PLAYER_INFO sPlayerInfo;

    public struct LOCAL_SETTING
    {
        [Header("Controll")]
        public float vMouseSensitivity;

        [Header("Sounds")]
        public float vMainVolume;
        public float vEffectVolume;
        public float vBGMVolume;

        [Header("Video")]
        public int vFPS;
        public (int, int) resolution;     //�ػ�
        public int fullScreenMode;        //��ü ȭ��
        public int framerate;             //�ֻ���
        public int textureQuality;        //�ؽ�ó
        public int shadowQuality;         //�׸���
        public int antiAliasing;          //��Ƽ�ٸ����
        public int vSync;                 //��������ȭ    
        public int anisotropicFiltering;  //���漺 ���͸�
    }
    public LOCAL_SETTING sLocalSetting;

    public struct TERRAIN_INFO
    {
        public GameObject gTerrain;
    };
    public TERRAIN_INFO sTerrainInfo;

}
