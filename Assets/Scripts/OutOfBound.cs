using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBound : MonoBehaviour {

    public Transform Player;
    private Vector3 startTransform;

    private void Start()
    {
        startTransform = new Vector3(Player.position.x, Player.position.y, Player.position.z);  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ball went out of bounds");
            Player.position = new Vector3(startTransform.x, startTransform.y, startTransform.z);
        }
    }
}
