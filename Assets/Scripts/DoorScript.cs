using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public bool isOpen = false;
    public Transform leftDoor;
    public Transform rightDoor;

    private IEnumerator OpenningDoor()
    {
        for (int i = 0; i < 70; i++)
        {
            Debug.Log("left " + leftDoor.rotation + " Right " + rightDoor.rotation);
            leftDoor.Rotate(Vector3.down * Time.deltaTime * i * 2);
            rightDoor.Rotate(Vector3.up * Time.deltaTime * i * 2);
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("New collisions " + other.tag);
        if (other.tag == "Player")
        {
            if (!isOpen && other.GetComponent<PlayerScript>().nbKey != 0)
            {
                other.GetComponent<PlayerScript>().nbKey--;
                other.GetComponent<PlayerScript>().UpdateKeyNbr();
                isOpen = true;
                StartCoroutine(OpenningDoor());
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
