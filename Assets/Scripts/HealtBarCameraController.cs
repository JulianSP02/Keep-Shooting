using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBarCameraController : MonoBehaviour
{
    Transform targerCamera;

    void Awake()
    {
        targerCamera = Camera.main.transform;
    }

    void Update()
    {
        transform.rotation =
            Quaternion.LookRotation(transform.position - targerCamera.position);
    }
}
