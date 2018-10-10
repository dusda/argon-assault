using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    void Update()
    {
        float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        print(horizontalThrow);
    }
}
