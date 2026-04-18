using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private void Awake()
    {
        transform.SetParent(null);
        DontDestroyOnLoad(gameObject);
    }


}
