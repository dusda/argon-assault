using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField, Tooltip("In m/sec")] float xSpeed = 4f;
    [SerializeField, Tooltip("In m")] float xRange = 2.58f;
    [SerializeField, Tooltip("In m/sec")] float ySpeed = 4f;
    [SerializeField, Tooltip("In m")] float yRange = 2f;

    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xSpeed * xThrow * Time.deltaTime;
        float rawX = transform.localPosition.x + xOffset;
        float x = Mathf.Clamp(rawX, -xRange, xRange);

        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = ySpeed * yThrow * Time.deltaTime;
        float rawY = transform.localPosition.y + yOffset;
        float y = Mathf.Clamp(rawY, -yRange, yRange);

        transform.localPosition = new Vector3(
            x,
            y,
            transform.localPosition.z);
    }
}
