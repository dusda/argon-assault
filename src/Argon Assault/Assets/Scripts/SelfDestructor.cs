using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    [SerializeField, Tooltip("in seconds")] float lifeTime = 5f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
