using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTerrain : MonoBehaviour {

    public float speed = 40f;
    public float smooth = 40f;
    Quaternion baseRotation;

    private void Start()
    {
        baseRotation = transform.rotation;
    }

    void Update()
    {

        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(Input.GetAxis("Vertical") * Vector3.forward * speed * Time.deltaTime);
            transform.Rotate(Input.GetAxis("Horizontal") * Vector3.right * speed * Time.deltaTime);
        }
        else
            transform.rotation = Quaternion.RotateTowards(transform.rotation, baseRotation, smooth * Time.deltaTime);
    }
}
