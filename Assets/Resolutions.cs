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
        FullScreenMode.options = Enum.GetNames(typeof(FullScreenMode)).ToList().Select(x => new TMP_Dropdown.OptionData(x)).ToList();
    }
    
    public void UpdateSettings()
    {
        if (int.TryParse(Width.text, out int width) && int.TryParse(Height.text, out int height) && int.TryParse(RefreshRate.text, out int refreshRate))
        {
            FullScreenMode fullScreenMode = (FullScreenMode) FullScreenMode.value;
            Debug.Log($"{width}, {height}, {fullScreenMode}, {refreshRate}");
            //Screen.SetResolution(width, height, fullScreenMode, refreshRate);
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
        UnityEngineScreenFullScreenAwake.text = $"UnityEngine.Screen.fullScreen: {UnityEngine.Screen.fullScreen}";
        UnityEngineScreenFullScreenModeAwake.text = $"UnityEngine.Screen.fullScreenMode: {UnityEngine.Screen.fullScreenMode}";
        UnityEngineApplicationTargetFrameRateAwake.text = $"UnityEngine.Application.targetFrameRate: {UnityEngine.Application.targetFrameRate}";
        UnityEngineQualtiySettingsVSyncCountAwake.text = $"UnityEngine.QualitySettings.vSyncCount: {UnityEngine.QualitySettings.vSyncCount}";
        UnityEngineScreenWidthHeightAwake.text = $"UnityEngine.Screen.width/height: {UnityEngine.Screen.width}x{UnityEngine.Screen.height}";
        UnityEngineDeviceScreenWidthHeightAwake.text = $"UnityEngine.Device.Screen.width/height/refreshRate: {UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})";
        UnityEngineScreenCurrentResolutionWidthHeightAwake.text = $"UnityEngine.Screen.currentResolution.width/height: {UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}";
        UnityEngineDisplayMainSystemWidthHeightAwake.text = $"UnityEngine.Display.main.systemWidth/systemHeight: {UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}";
        UnityEngineDisplayRenderingWidthHeightAwake.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: {UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}";
        UnityEngineScreenResolutionsAwake.text = "UnityEngine.Screen.resolutions: " + string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList());
        UnityEngineScreenSafeAreaAwake.text = $"UnityEngine.Screen.safeArea: {UnityEngine.Screen.safeArea.ToString()}";
    }
    
    private void Start()
    {
        UnityEngineScreenFullScreenStart.text = $"UnityEngine.Screen.fullScreen: {UnityEngine.Screen.fullScreen}";
        UnityEngineScreenFullScreenModeStart.text = $"UnityEngine.Screen.fullScreenMode: {UnityEngine.Screen.fullScreenMode}";
        UnityEngineApplicationTargetFrameRateStart.text = $"UnityEngine.Application.targetFrameRate: {UnityEngine.Application.targetFrameRate}";
        UnityEngineQualtiySettingsVSyncCountStart.text = $"UnityEngine.QualitySettings.vSyncCount: {UnityEngine.QualitySettings.vSyncCount}";
        UnityEngineScreenWidthHeightStart.text = $"UnityEngine.Screen.width/height: {UnityEngine.Screen.width}x{UnityEngine.Screen.height}";
        UnityEngineDeviceScreenWidthHeightStart.text = $"UnityEngine.Device.Screen.width/height/refreshRate: {UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})";
        UnityEngineScreenCurrentResolutionWidthHeightStart.text = $"UnityEngine.Screen.currentResolution.width/height: {UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}";
        UnityEngineDisplayMainSystemWidthHeightStart.text = $"UnityEngine.Display.main.systemWidth/systemHeight: {UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}";
        UnityEngineDisplayRenderingWidthHeightStart.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: {UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}";
        UnityEngineScreenResolutionsStart.text = "UnityEngine.Screen.resolutions: " +  string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList());
        UnityEngineScreenSafeAreaStart.text = $"UnityEngine.Screen.safeArea: {UnityEngine.Screen.safeArea.ToString()}";
    }
    
    private void OnEnable()
    {
        UnityEngineScreenFullScreenOnEnable.text = $"UnityEngine.Screen.fullScreen: {UnityEngine.Screen.fullScreen}";
        UnityEngineScreenFullScreenModeOnEnable.text = $"UnityEngine.Screen.fullScreenMode: {UnityEngine.Screen.fullScreenMode}";
        UnityEngineApplicationTargetFrameRateOnEnable.text = $"UnityEngine.Application.targetFrameRate: {UnityEngine.Application.targetFrameRate}";
        UnityEngineQualtiySettingsVSyncCountOnEnable.text = $"UnityEngine.QualitySettings.vSyncCount: {UnityEngine.QualitySettings.vSyncCount}";
        UnityEngineScreenWidthHeightOnEnable.text = $"UnityEngine.Screen.width/height: {UnityEngine.Screen.width}x{UnityEngine.Screen.height}";
        UnityEngineDeviceScreenWidthHeightOnEnable.text = $"UnityEngine.Device.Screen.width/height/refreshRate: {UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})";
        UnityEngineScreenCurrentResolutionWidthHeightOnEnable.text = $"UnityEngine.Screen.currentResolution.width/height: {UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}";
        UnityEngineDisplayMainSystemWidthHeightOnEnable.text = $"UnityEngine.Display.main.systemWidth/systemHeight: {UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}";
        UnityEngineDisplayRenderingWidthHeightOnEnable.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: {UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}";
        UnityEngineScreenResolutionsOnEnable.text = "UnityEngine.Screen.resolutions: " +  string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList());
        UnityEngineScreenSafeAreaOnEnable.text = $"UnityEngine.Screen.safeArea: {UnityEngine.Screen.safeArea.ToString()}";
    }
    
    private void Update()
    {
        UnityEngineScreenFullScreen.text = $"UnityEngine.Screen.fullScreen: {UnityEngine.Screen.fullScreen}";
        UnityEngineScreenFullScreenMode.text = $"UnityEngine.Screen.fullScreenMode: {UnityEngine.Screen.fullScreenMode}";
        UnityEngineApplicationTargetFrameRate.text = $"UnityEngine.Application.targetFrameRate: {UnityEngine.Application.targetFrameRate}";
        UnityEngineQualtiySettingsVSyncCount.text = $"UnityEngine.QualitySettings.vSyncCount: {UnityEngine.QualitySettings.vSyncCount}";
        UnityEngineScreenWidthHeight.text = $"UnityEngine.Screen.width/height: {UnityEngine.Screen.width}x{UnityEngine.Screen.height}";
        UnityEngineDeviceScreenWidthHeight.text = $"UnityEngine.Device.Screen.width/height/refreshRate: {UnityEngine.Device.Screen.width}x{UnityEngine.Device.Screen.height} ({UnityEngine.Screen.currentResolution.refreshRate})";
        UnityEngineScreenCurrentResolutionWidthHeight.text = $"UnityEngine.Screen.currentResolution.width/height: {UnityEngine.Screen.currentResolution.width}x{UnityEngine.Screen.currentResolution.height}";
        UnityEngineDisplayMainSystemWidthHeight.text = $"UnityEngine.Display.main.systemWidth/systemHeight: {UnityEngine.Display.main.systemWidth}x{UnityEngine.Display.main.systemHeight}";
        UnityEngineDisplayRenderingWidthHeight.text = $"UnityEngine.Display.main.renderingWidth/renderingHeight: {UnityEngine.Display.main.renderingWidth}x{UnityEngine.Display.main.renderingHeight}";
        UnityEngineScreenResolutions.text = "UnityEngine.Screen.resolutions: " + string.Join(",", UnityEngine.Screen.resolutions.ToList().Select(x => $"{x.width}x{x.height} ({x.refreshRate})").ToList());
        UnityEngineScreenSafeArea.text = $"UnityEngine.Screen.safeArea: {UnityEngine.Screen.safeArea.ToString()}";

        for (int i = 0; i < UnityEventGroups.Length; i++)
        {
            UnityEventGroups[i].SetActive(Event.value == i);
        }
    }
}
