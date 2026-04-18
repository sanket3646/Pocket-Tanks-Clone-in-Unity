using UnityEngine;

public class EventBus : MonoBehaviour
{
    private void Awake()
    {
        transform.SetParent(null);
        DontDestroyOnLoad(gameObject);
    }
}
