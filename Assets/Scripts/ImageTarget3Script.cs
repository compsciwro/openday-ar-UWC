using UnityEngine;

public class TapRotateStep : MonoBehaviour
{
    public float rotationStep = 45f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            transform.Rotate(0, rotationStep, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, rotationStep, 0);
        }
    }
}

