using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * Method allowing to load the mediaplayer or to quit the application.
 */
public class Menu : MonoBehaviour
{
    [SerializeField]
    private Scene LaunchScene;

    /**
     * Load the mediaPlayer Scene
     */
	public void Jouer () {
        SceneManager.LoadScene(LaunchScene.name);
	}
	
    /**
     * Quit the application.
     */
    public void Quitter ()
    {
        Application.Quit();
    }
}
