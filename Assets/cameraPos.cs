using UnityEngine;

public class cameraPos : MonoBehaviour
{
    public Transform camerapos;

    void Update()
    {
        transform.position = camerapos.position;
    }
}
