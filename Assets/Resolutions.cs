using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.UI;

public class Resolutions : MonoBehaviour
{
    public TMP_Dropdown Event;
    public TMP_Dropdown FullScreenMode;

    public TMP_InputField Width;
    public TMP_InputField Height;
    public TMP_InputField RefreshRate;

    public GameObject[] UnityEventGroups;
    
    public enum UnityEventFunction
    {
        Awake,
        Start,
        OnEnable,
        Update
    }
    
    private void InitalizeSettings()
    {
        PlayerPrefs.DeleteAll();
        
        Event.options = Enum.GetNames(typeof(UnityEventFunction)).ToList().Select(x => new TMP_Dropdown.OptionData(x)).ToList();
        Event.value = Event.options.Count - 1;
        FullScreenMode.options = Enum.GetNames(typeof(FullScreenMode)).ToList().Select(x => new TMP_Dropdown.OptionData(x)).ToList();

        Width.text = Screen.currentResolution.width.ToString();
        Height.text = Screen.currentResolution.height.ToString();
        RefreshRate.text = Screen.currentResolution.refreshRate.ToString();
        FullScreenMode.value = (int) Screen.fullScreenMode;
    }
    
    public void UpdateSettings()
    {
        if (int.TryParse(Width.text, out int width) && int.TryParse(Height.text, out int height) && int.TryParse(RefreshRate.text, out int refreshRate))
        {
            FullScreenMode fullScreenMode = (FullScreenMode) FullScreenMode.value;
            Screen.SetResolution(width, height, fullScreenMode, refreshRate);
        }
        else
        {
            Debug.LogError("Failed to parse settings.");
        }
    }

    [Header("Awake")]
    public TextMeshProUGUI UnityEngineScreenFullScreenAwake;
    public TextMeshProUGUI UnityEngineScreenFullScreenModeAwake;
    public TextMeshProUGUI UnityEngineApplicationTargetFrameRateAwake;
    public TextMeshProUGUI UnityEngineQualtiySettingsVSyncCountAwake;
    public TextMeshProUGUI UnityEngineScreenWidthHeightAwake; 
    public TextMeshProUGUI UnityEngineDeviceScreenWidthHeightAwake;
    public TextMeshProUGUI UnityEngineScreenCurrentResolutionWidthHeightAwake;
    public TextMeshProUGUI UnityEngineDisplayMainSystemWidthHeightAwake;
    public TextMeshProUGUI UnityEngineDisplayRenderingWidthHeightAwake;
    public TextMeshProUGUI UnityEngineScreenResolutionsAwake;
    public TextMeshProUGUI UnityEngineScreenSafeAreaAwake;
    
    [Header("Start")]
    public TextMeshProUGUI UnityEngineScreenFullScreenStart;
    public TextMeshProUGUI UnityEngineScreenFullScreenModeStart;
    public TextMeshProUGUI UnityEngineApplicationTargetFrameRateStart;
    public TextMeshProUGUI UnityEngineQualtiySettingsVSyncCountStart;
    public TextMeshProUGUI UnityEngineScreenWidthHeightStart; 
    public TextMeshProUGUI UnityEngineDeviceScreenWidthHeightStart;
    public TextMeshProUGUI UnityEngineScreenCurrentResolutionWidthHeightStart;
    public TextMeshProUGUI UnityEngineDisplayMainSystemWidthHeightStart;
    public TextMeshProUGUI UnityEngineDisplayRenderingWidthHeightStart;
    public TextMeshProUGUI UnityEngineScreenResolutionsStart;
    public TextMeshProUGUI UnityEngineScreenSafeAreaStart;
    
    [Header("OnEnable")]
    public TextMeshProUGUI UnityEngineScreenFullScreenOnEnable;
    public TextMeshProUGUI UnityEngineScreenFullScreenModeOnEnable;
    public TextMeshProUGUI UnityEngineApplicationTargetFrameRateOnEnable;
    public TextMeshProUGUI UnityEngineQualtiySettingsVSyncCountOnEnable;
    public TextMeshProUGUI UnityEngineScreenWidthHeightOnEnable; 
    public TextMeshProUGUI UnityEngineDeviceScreenWidthHeightOnEnable;
    public TextMeshProUGUI UnityEngineScreenCurrentResolutionWidthHeightOnEnable;
    public TextMeshProUGUI UnityEngineDisplayMainSystemWidthHeightOnEnable;
    public TextMeshProUGUI UnityEngineDisplayRenderingWidthHeightOnEnable;
    public TextMeshProUGUI UnityEngineScreenResolutionsOnEnable;
    public TextMeshProUGUI UnityEngineScreenSafeAreaOnEnable;
    
    [Header("Update")]
    public TextMeshProUGUI UnityEngineScreenFullScreen;
    public TextMeshProUGUI UnityEngineScreenFullScreenMode;
    public TextMeshProUGUI UnityEngineApplicationTargetFrameRate;
    public TextMeshProUGUI UnityEngineQualtiySettingsVSyncCount;
    public TextMeshProUGUI UnityEngineScreenWidthHeight; 
    public TextMeshProUGUI UnityEngineDeviceScreenWidthHeight;
    public TextMeshProUGUI UnityEngineScreenCurrentResolutionWidthHeight;
    public TextMeshProUGUI UnityEngineDisplayMainSystemWidthHeight;
    public TextMeshProUGUI UnityEngineDisplayRenderingWidthHeight;
    public TextMeshProUGUI UnityEngineScreenResolutions;
    public TextMeshProUGUI UnityEngineScreenSafeArea;

    private void Awake()
    {
        InitalizeSettings();
        UnityEngineScreenFullScreenAwake.text = $"UnityEngine.Screen.fullScreen: <b>{UnityEngine.Screen.fullScreen}</b>";
        UnityEngineScreenFullScreenModeAwake.text = $"UnityEngine.Screen.fullScreenMode: <b>{UnityEngine.Screen.fullScreenMode}</b>";
        UnityEngineApplicationTargetFrameRateAwake.text = $"UnityEngine.Application.targetFrameRate: <b>{UnityEngine.Application.targetFrameRate}</b>";
        UnityEngineQualtiySettingsVSyncCountAwake.text = $"UnityEngine.QualitySettings.vSyncCount: <b>{UnityEngine.QualitySettings.vSyncCount}</b>";
        UnityEngineScreenWidthHeightAwake.text = $"UnityEngine.Screen.width/height: <b>{UnityEngine.Screen.width}x{UnityEngine.Screen.height}</b>";
        UnityEngineDeviceScreenWidthHeightAwake.text = $"UnityEngine.Device.Screen.width/height/refreshRate: <b>{UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})</b>";
        UnityEngineScreenCurrentResolutionWidthHeightAwake.text = $"UnityEngine.Screen.currentResolution.width/height: <b>{UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}</b>";
        UnityEngineDisplayMainSystemWidthHeightAwake.text = $"UnityEngine.Display.main.systemWidth/systemHeight: <b>{UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}</b>";
        UnityEngineDisplayRenderingWidthHeightAwake.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: <b>{UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}</b>";
        UnityEngineScreenResolutionsAwake.text = $"UnityEngine.Screen.resolutions:\n<b>{string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList())}</b>";
        UnityEngineScreenSafeAreaAwake.text = $"UnityEngine.Screen.safeArea: <b>{UnityEngine.Screen.safeArea.ToString()}</b>";
    }
    
    private void Start()
    {
        UnityEngineScreenFullScreenStart.text = $"UnityEngine.Screen.fullScreen: <b>{UnityEngine.Screen.fullScreen}</b>";
        UnityEngineScreenFullScreenModeStart.text = $"UnityEngine.Screen.fullScreenMode: <b>{UnityEngine.Screen.fullScreenMode}</b>";
        UnityEngineApplicationTargetFrameRateStart.text = $"UnityEngine.Application.targetFrameRate: <b>{UnityEngine.Application.targetFrameRate}</b>";
        UnityEngineQualtiySettingsVSyncCountStart.text = $"UnityEngine.QualitySettings.vSyncCount: <b>{UnityEngine.QualitySettings.vSyncCount}</b>";
        UnityEngineScreenWidthHeightStart.text = $"UnityEngine.Screen.width/height: <b>{UnityEngine.Screen.width}x{UnityEngine.Screen.height}</b>";
        UnityEngineDeviceScreenWidthHeightStart.text = $"UnityEngine.Device.Screen.width/height/refreshRate: <b>{UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})</b>";
        UnityEngineScreenCurrentResolutionWidthHeightStart.text = $"UnityEngine.Screen.currentResolution.width/height: <b>{UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}</b>";
        UnityEngineDisplayMainSystemWidthHeightStart.text = $"UnityEngine.Display.main.systemWidth/systemHeight: <b>{UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}</b>";
        UnityEngineDisplayRenderingWidthHeightStart.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: <b>{UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}</b>";
        UnityEngineScreenResolutionsStart.text = $"UnityEngine.Screen.resolutions:\n<b>{string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList())}</b>";
        UnityEngineScreenSafeAreaStart.text = $"UnityEngine.Screen.safeArea: <b>{UnityEngine.Screen.safeArea.ToString()}</b>";
    }
    
    private void OnEnable()
    {
        UnityEngineScreenFullScreenOnEnable.text = $"UnityEngine.Screen.fullScreen: <b>{UnityEngine.Screen.fullScreen}</b>";
        UnityEngineScreenFullScreenModeOnEnable.text = $"UnityEngine.Screen.fullScreenMode: <b>{UnityEngine.Screen.fullScreenMode}</b>";
        UnityEngineApplicationTargetFrameRateOnEnable.text = $"UnityEngine.Application.targetFrameRate: <b>{UnityEngine.Application.targetFrameRate}</b>";
        UnityEngineQualtiySettingsVSyncCountOnEnable.text = $"UnityEngine.QualitySettings.vSyncCount: <b>{UnityEngine.QualitySettings.vSyncCount}</b>";
        UnityEngineScreenWidthHeightOnEnable.text = $"UnityEngine.Screen.width/height: <b>{UnityEngine.Screen.width}x{UnityEngine.Screen.height}</b>";
        UnityEngineDeviceScreenWidthHeightOnEnable.text = $"UnityEngine.Device.Screen.width/height/refreshRate: <b>{UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})</b>";
        UnityEngineScreenCurrentResolutionWidthHeightOnEnable.text = $"UnityEngine.Screen.currentResolution.width/height: <b>{UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}</b>";
        UnityEngineDisplayMainSystemWidthHeightOnEnable.text = $"UnityEngine.Display.main.systemWidth/systemHeight: <b>{UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}</b>";
        UnityEngineDisplayRenderingWidthHeightOnEnable.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: <b>{UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}</b>";
        UnityEngineScreenResolutionsOnEnable.text = $"UnityEngine.Screen.resolutions:\n<b>{string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList())}</b>";
        UnityEngineScreenSafeAreaOnEnable.text = $"UnityEngine.Screen.safeArea: <b>{UnityEngine.Screen.safeArea.ToString()}</b>";
    }
    
    private void Update()
    {
        UnityEngineScreenFullScreen.text = $"UnityEngine.Screen.fullScreen: <b>{UnityEngine.Screen.fullScreen}</b>";
        UnityEngineScreenFullScreenMode.text = $"UnityEngine.Screen.fullScreenMode: <b>{UnityEngine.Screen.fullScreenMode}</b>";
        UnityEngineApplicationTargetFrameRate.text = $"UnityEngine.Application.targetFrameRate: <b>{UnityEngine.Application.targetFrameRate}</b>";
        UnityEngineQualtiySettingsVSyncCount.text = $"UnityEngine.QualitySettings.vSyncCount: <b>{UnityEngine.QualitySettings.vSyncCount}</b>";
        UnityEngineScreenWidthHeight.text = $"UnityEngine.Screen.width/height: <b>{UnityEngine.Screen.width}x{UnityEngine.Screen.height}</b>";
        UnityEngineDeviceScreenWidthHeight.text = $"UnityEngine.Device.Screen.width/height/refreshRate: <b>{UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})</b>";
        UnityEngineScreenCurrentResolutionWidthHeight.text = $"UnityEngine.Screen.currentResolution.width/height: <b>{UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}</b>";
        UnityEngineDisplayMainSystemWidthHeight.text = $"UnityEngine.Display.main.systemWidth/systemHeight: <b>{UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}</b>";
        UnityEngineDisplayRenderingWidthHeight.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: <b>{UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}</b>";
        UnityEngineScreenResolutions.text = $"UnityEngine.Screen.resolutions:\n<b>{string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList())}</b>";
        UnityEngineScreenSafeArea.text = $"UnityEngine.Screen.safeArea: <b>{UnityEngine.Screen.safeArea.ToString()}";

        for (int i = 0; i < UnityEventGroups.Length; i++)
        {
            UnityEventGroups[i].SetActive(Event.value == i);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
