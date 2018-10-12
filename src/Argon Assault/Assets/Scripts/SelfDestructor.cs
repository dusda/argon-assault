using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    void Start()
    {
        //todo allow customization
        Destroy(gameObject, 5f);
    }
}
