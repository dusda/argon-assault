using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds"), SerializeField] float levelLoadDelay = 1f;
    [SerializeField] GameObject deathFx;

    void OnTriggerEnter(Collider other)
    {
        print("player triggered something");
        StartDeathSequence();
    }

    void StartDeathSequence()
    {
        deathFx.SetActive(true);
        SendMessage("OnPlayerDeath");
        Invoke("Reload", levelLoadDelay);
    }

    void Reload()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
