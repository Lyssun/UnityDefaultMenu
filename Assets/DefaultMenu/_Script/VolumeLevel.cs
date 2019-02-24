using UnityEngine;
using UnityEngine.UI;

/**
 * Allow the user to change the sound level
 */
public class VolumeLevel : MonoBehaviour {

    [SerializeField]
    private Slider _VolumeSlider;

    [SerializeField]
    private Settings _Settings;

    /**
     * Allows us to get and to set the slider value
     */
    public float Volume
    {
        get { return _VolumeSlider.value; }
        set { _VolumeSlider.value = value;}
    }
    /**
     * Get the value for the slider in the playerpref if that exist otherwise, that would be set to 1
     */
    void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
            Volume = _Settings.SoundRunTimeValue;
        else
        {
            _Settings.SoundRunTimeValue =  1.0f;
            Volume = 1f;
        }
    }


    /**
     * Save the value of the slider in the playerPref when disabled.
     */
    private void OnDisable()
    {
        _Settings.SoundRunTimeValue = Volume;
        _Settings.SoundSaveValue();
    }
}