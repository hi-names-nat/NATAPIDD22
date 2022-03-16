// Don't look until you've attempted to fix the existing files!
using UnityEngine;

public class Types_C : MonoBehaviour
{
    public float DistanceUp, DistanceForward, DistanceRight;
    public Quaternion Rotation;

    private void Update()
    {
        transform.position = new Vector3(DistanceRight, DistanceUp, DistanceForward);
        transform.rotation = Rotation;
    }
}