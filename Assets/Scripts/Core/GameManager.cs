using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        transform.SetParent(null); //added because DontDestroyOnLoad only works on unparented gameObjects
        DontDestroyOnLoad(gameObject);
    }
}
