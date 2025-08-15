using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;        // Referensi ke Player
    public Vector3 offset;          // Jarak antara kamera dan player (bisa diset di Inspector)
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
