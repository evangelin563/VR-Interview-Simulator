using UnityEngine;

public class FreezeTransform : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    [SerializeField] private bool freezePosition = true;
    [SerializeField] private bool freezeRotation = true;

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void LateUpdate() // Use LateUpdate to avoid conflicting with XR updates
    {
        if (freezePosition && Vector3.Distance(transform.position, initialPosition) > 0.01f)
        {
            transform.position = initialPosition;
            Debug.LogWarning("Transform position was changed. Resetting to initial value.");
        }

        if (freezeRotation && Quaternion.Angle(transform.rotation, initialRotation) > 0.1f)
        {
            transform.rotation = initialRotation;
            Debug.LogWarning("Transform rotation was changed. Resetting to initial value.");
        }
    }
}
