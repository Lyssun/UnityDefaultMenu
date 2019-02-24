using System;
using UnityEngine;

[CreateAssetMenu( menuName = "ScriptableObject/Settings", fileName = "Default_Settings")]
public class Settings : ScriptableObject,
    ISerializationCallbackReceiver
{
    #region Serialization
    public void OnAfterDeserialize()
    {
        SoundRunTimeValue = _SoundInitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
    #endregion

    #region Sound
    [Header("Sound Settings")]
    [SerializeField]
    private float _SoundInitialValue = 1f;

    public float SoundRunTimeValue { get; set; } = 1f;

    public void SoundResetValue() {
        SoundRunTimeValue = _SoundInitialValue;
    }

    public void SoundSaveValue()
    {
        _SoundInitialValue = SoundRunTimeValue;
    }
    #endregion

    #region Error
    public string Error { get; set; } = string.Empty;
    public void ErrorResetValue()
    {
        Error = string.Empty;
    }
    #endregion
}