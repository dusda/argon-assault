using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    AudioSource _music;

    void Start()
    {
        _music = GetComponent<AudioSource>();
        Invoke("LoadLevel", 1f);
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
