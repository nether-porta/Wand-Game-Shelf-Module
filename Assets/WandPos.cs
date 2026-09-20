using UnityEngine;

public class WandPos : MonoBehaviour
{
    public Transform orientation;

    void Update()
    {
        transform.rotation = orientation.rotation;
    }
}
