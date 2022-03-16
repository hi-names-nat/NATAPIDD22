using UnityEngine;

public class Types : MonoBehaviour
{
    public float DistanceUp, DistanceForward, DistanceRight;
    public Quaternion Rotation;

    private void Update()
    {
        transform.position = new Vector3(DistanceForward, DistanceRight, DistanceUp);
        Rotation = transform.rotation;
    }
}
