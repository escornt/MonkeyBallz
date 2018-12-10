using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCameraRotation : MonoBehaviour {

    public Transform Ball;
 
void Update()
    {

        transform.LookAt(Ball);

    }
}
