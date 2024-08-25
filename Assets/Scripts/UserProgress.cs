using UnityEngine;

public class UserProgress : MonoBehaviour
{
    public int Coins;
    public int Width;
    public int Height;
    public int Speed;

    public static UserProgress Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else { Destroy(gameObject); }
    }
}
