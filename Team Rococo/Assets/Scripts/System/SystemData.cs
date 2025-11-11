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
        public (int, int) resolution;     //해상도
        public int fullScreenMode;        //전체 화면
        public int framerate;             //주사율
        public int textureQuality;        //텍스처
        public int shadowQuality;         //그림자
        public int antiAliasing;          //안티앨리어싱
        public int vSync;                 //수직동기화    
        public int anisotropicFiltering;  //비등방성 필터링
    }
    public LOCAL_SETTING sLocalSetting;

    public struct TERRAIN_INFO
    {
        public GameObject gTerrain;
    };
    public TERRAIN_INFO sTerrainInfo;

    public struct INGAME_DATA
    {
        public float nowTime;
        public bool toothBrush;
        public bool flashLight;
        public bool toySword;
        public bool snack;
        public bool familyPhoto;
    };
    public INGAME_DATA sIngameData;

}
