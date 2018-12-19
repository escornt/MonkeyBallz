using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {

    // Update is called once per frame
    public AudioSource audio;
    public Vector3 rotationVector;
    public bool isUsed = false;
    public int speed = 70;
    private Vector3 initialScale;
    private bool played = false;

    private void Start()
    {
        initialScale = transform.localScale;
    }
    public IEnumerator Disapear()
    {
        //for (int i = 0; i < speed; i++)
        //{
        //    gameObject.transform.Rotate(rotationVector * i * Time.deltaTime * 40);
        //    gameObject.transform.localScale -= new Vector3(initialScale.x / speed, initialScale.y / speed , initialScale.z / speed);
        //    yield return null;
        //}
        gameObject.SetActive(false);
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (audio && !played)
            {
                audio.Play();
                played = true;
            }
        }
    }

    public void MakeDisappear()
    {
        isUsed = true;
        StartCoroutine(Disapear());
    }

	void Update ()
    {
        transform.Rotate(rotationVector * Time.deltaTime * 40);
    }
}
