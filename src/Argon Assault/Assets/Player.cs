using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField, Tooltip("In m/sec")] float xSpeed = 4f;
    [SerializeField, Tooltip("In m")] float xRange = 2.58f;
    [SerializeField, Tooltip("In m/sec")] float ySpeed = 4f;
    [SerializeField, Tooltip("In m")] float yRange = 2f;

    [SerializeField] float positionPitchFactor = -5f;
    [SerializeField] float controlPitchFactor = -15f;

    float xThrow, yThrow;

    void Update()
    {
        Translation();
        Rotation();
    }

    void Rotation()
    {
        float pitchFromPosition = transform.localPosition.y * positionPitchFactor;
        float pitchFromControlThrow = yThrow * controlPitchFactor;
        float pitch = pitchFromPosition + pitchFromControlThrow;
        float yaw = 0f;
        float roll = 0f;

        print("pfp: " + pitchFromPosition + ", pfct: " + pitchFromControlThrow);

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    void Translation()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xSpeed * xThrow * Time.deltaTime;
        float rawX = transform.localPosition.x + xOffset;
        float x = Mathf.Clamp(rawX, -xRange, xRange);

        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = ySpeed * yThrow * Time.deltaTime;
        float rawY = transform.localPosition.y + yOffset;
        float y = Mathf.Clamp(rawY, -yRange, yRange);

        transform.localPosition = new Vector3(x, y, transform.localPosition.z);
    }
}
