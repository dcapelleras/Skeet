using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] Transform dispenser;
    [SerializeField] Vector3 offset= Vector3.zero;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, dispenser.position + offset, 0.5f);
    }
}
