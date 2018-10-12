using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadLevel", 1f);
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
