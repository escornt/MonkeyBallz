using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBound : MonoBehaviour {

    public Transform Player;
    private Vector3 startTransform;

    private void Start()
    {
        startTransform = new Vector3(Player.position.x, Player.position.y, Player.position.z);  
    }

    public void killPlayer()
    {
        Player.gameObject.GetComponent<PlayerScript>().nbLife--;
        Player.gameObject.GetComponent<PlayerScript>().UpdateLifeNbr();
        if (Player.gameObject.GetComponent<PlayerScript>().nbLife == 0)
            SceneManager.LoadScene("Main-Menu");
        Player.position = new Vector3(startTransform.x, startTransform.y, startTransform.z);
        Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            killPlayer();
        }
    }
}
