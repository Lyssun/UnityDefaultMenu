using UnityEngine;
using UnityEngine.UI;

/**
 * Let the Error message appear on the menu if we got an error.
 */

public class Error : MonoBehaviour {
    [SerializeField]
    [Tooltip("The Canvas of the error message")]
    private Text errorMsg;

    [SerializeField]
    private Settings _Settings;
    /**
     * Hide the error message if we don't have any error in playerPrefs.
     * Otherwise, that would print the message and delete the playerPrefs key
     */
    void Start()
    {
        if (_Settings.Error != string.Empty)
        {
            Destroy(errorMsg.transform.parent.gameObject, 3f);
            _Settings.ErrorResetValue();
        }
        else
        {
            errorMsg.transform.parent.gameObject.SetActive(false);
        }

    }


}
