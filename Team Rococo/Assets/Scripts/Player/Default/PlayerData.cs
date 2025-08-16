using UnityEditor;

using UnityEngine;

public class PlayerData
{
    static private PlayerData pInstance;
    public const int vFPS = 60;
    static public PlayerData I
    {
        get
        {
            if (pInstance != null)
            {
                return pInstance;
            }
            pInstance = new PlayerData();
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
        public int vNodPoint;
        public int vUsingNodPoint;
        public float vDefaultATK;
        public float vFinalATK;

    };

}
