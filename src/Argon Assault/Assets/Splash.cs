using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    AudioSource _music;

    void Awake()
    {
        _music = GetComponent<AudioSource>();
        DontDestroyOnLoad(_music);
    }

    void Start()
    {
        Invoke("LoadLevel", 1f);
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
