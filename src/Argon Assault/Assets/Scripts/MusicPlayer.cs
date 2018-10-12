using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    void Awake()
    {
        //more than one music player? kill yourself
        int count = FindObjectsOfType<MusicPlayer>().Length;

        if (count > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(this);
    }
}
