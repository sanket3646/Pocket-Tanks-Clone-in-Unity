using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    private enum Scenes
    {
        MainMenu,
        MatchScene
    }
    private void Awake()
    {
        transform.SetParent(null);
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene((int)Scenes.MainMenu);

    }
  
    
}
