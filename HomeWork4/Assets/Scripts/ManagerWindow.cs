using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerWindow : MonoBehaviour
{
    [SerializeField] private Button _creditsButton;
    [SerializeField] private Button _cinematicButton;
    [SerializeField] private Toggle _enableChallengingToggle;
    [SerializeField] private Toggle _allowFriendsToSpectateToggle;
    [SerializeField] private Toggle _fullscreenToggle;
    [SerializeField] private Toggle _soundInBackgroundToggle;
    [SerializeField] private Dropdown _resolutionDropdown;
    [SerializeField] private Dropdown _qualityDropdown;
    [SerializeField] private Slider _masterVolumeSlider;
    [SerializeField] private Slider _musicVolumeSlider;

    private void Start()
    {
        _creditsButton.onClick.AddListener(OnClickCreditsButton);
        _cinematicButton.onClick.AddListener(OnClickCinematicButton);
        _enableChallengingToggle.onValueChanged.AddListener(OnValueChangedEnableChallengingToggle);
        _allowFriendsToSpectateToggle.onValueChanged.AddListener(OnValueChangedAllowFriendsToSpectateToggle);
        _fullscreenToggle.onValueChanged.AddListener(OnValueChangedFullscreenToggle);
        _soundInBackgroundToggle.onValueChanged.AddListener(OnValueChangedSoundInBackgroundToggle);
        _resolutionDropdown.onValueChanged.AddListener(OnValueChangedResolutionDropdown);
        _qualityDropdown.onValueChanged.AddListener(OnValueChangedQualityDropdown);
        _masterVolumeSlider.onValueChanged.AddListener(OnValueChangedMasterVolumeSlider);
        _musicVolumeSlider.onValueChanged.AddListener(OnValueChangedMusicVolumeSlider);
    }

    private void OnDestroy()
    {
        _creditsButton.onClick.RemoveListener(OnClickCreditsButton);
        _cinematicButton.onClick.RemoveListener(OnClickCinematicButton);
        _enableChallengingToggle.onValueChanged.RemoveListener(OnValueChangedEnableChallengingToggle);
        _enableChallengingToggle.onValueChanged.RemoveListener(OnValueChangedAllowFriendsToSpectateToggle);
        _fullscreenToggle.onValueChanged.RemoveListener(OnValueChangedFullscreenToggle);
        _soundInBackgroundToggle.onValueChanged.RemoveListener(OnValueChangedSoundInBackgroundToggle);
        _resolutionDropdown.onValueChanged.RemoveListener(OnValueChangedResolutionDropdown);
        _qualityDropdown.onValueChanged.RemoveListener(OnValueChangedQualityDropdown);
        _masterVolumeSlider.onValueChanged.RemoveListener(OnValueChangedMasterVolumeSlider);
        _musicVolumeSlider.onValueChanged.RemoveListener(OnValueChangedMusicVolumeSlider);
    }

    private void OnClickCreditsButton()
    {
        Debug.Log("On Click Credits Button");
    }

    private void OnClickCinematicButton()
    {
        Debug.Log("On Click Cinematic Button");
    }

    private void OnValueChangedEnableChallengingToggle(bool value)
    {
        Debug.Log($"On Value ChangedEnable Challenging Toggle Value = {value}");
    }

    private void OnValueChangedAllowFriendsToSpectateToggle(bool value)
    {
        Debug.Log($"On Value Changed Allow Friends To Spectate Toggle Value = {value}");
    }

    private void OnValueChangedFullscreenToggle(bool value)
    {
        Debug.Log($"On Value Changed Fullscreen Toggle Value = {value}");
    }

    private void OnValueChangedSoundInBackgroundToggle(bool value)
    {
        Debug.Log($"On Value Changed Sound In Background Toggle Value = {value}");
    }

    private void OnValueChangedResolutionDropdown(int value)
    {
        Debug.Log($"On Value Changed Resolution Dropdown Value = {value}");
    }

    private void OnValueChangedQualityDropdown(int value)
    {
        Debug.Log($"On Value Changed Quality Dropdown Value = {value}");
    }

    private void OnValueChangedMasterVolumeSlider(float value)
    {
        Debug.Log($"On Value Changed Master Volume Slider Value = {value}");
    }

    private void OnValueChangedMusicVolumeSlider(float value)
    {
        Debug.Log($"On Value Changed Music Volume Slider Value = {value}");
    }
}
