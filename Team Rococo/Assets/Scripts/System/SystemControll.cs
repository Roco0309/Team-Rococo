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

    private (int, int) resolution;     //�ػ�
    private int fullScreenMode;        //��ü ȭ��
    private int framerate;             //�ֻ���
    private int textureQuality;        //�ؽ�ó
    private int shadowQuality;         //�׸���
    private int antiAliasing;          //��Ƽ�ٸ����
    private int vSync;                 //��������ȭ    
    private int anisotropicFiltering;  //���漺 ���͸�

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
