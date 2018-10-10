using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField, Tooltip("In m/sec")]
    float xSpeed = 4f;

    [SerializeField, Tooltip("In m")]
    float xRange = 2.58f;

    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xSpeed * xThrow * Time.deltaTime;
        float rawX = transform.localPosition.x + xOffset;
        float x = Mathf.Clamp(rawX, -xRange, xRange);

        transform.localPosition = new Vector3(
            x,
            transform.localPosition.y,
            transform.localPosition.z);
    }
}
