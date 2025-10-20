using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class SystemControll : MonoBehaviour
{
    [SerializeField]
    List<UniversalRenderPipelineAsset> pipeLines;

    private (int, int) resolution;     //해상도
    private int fullScreenMode;        //전체 화면
    private int framerate;             //주사율
    private int textureQuality;        //텍스처
    private int shadowQuality;         //그림자
    private int antiAliasing;          //안티앨리어싱
    private int vSync;                 //수직동기화    
    private int anisotropicFiltering;  //비등방성 필터링

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPipeLine(int index)
    {
        QualitySettings.SetQualityLevel(index);
        QualitySettings.renderPipeline = pipeLines[index];
    }

    private void OnEnable()
    {
        resolution = SystemData.I.sLocalSetting.resolution;
        fullScreenMode = SystemData.I.sLocalSetting.fullScreenMode;
        framerate = SystemData.I.sLocalSetting.framerate;
        textureQuality = SystemData.I.sLocalSetting.textureQuality;
        shadowQuality = SystemData.I.sLocalSetting.shadowQuality;
        antiAliasing = SystemData.I.sLocalSetting.antiAliasing;
        vSync = SystemData.I.sLocalSetting.vSync;
        anisotropicFiltering = SystemData.I.sLocalSetting.anisotropicFiltering;
    }
}
