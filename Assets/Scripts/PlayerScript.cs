using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScript : MonoBehaviour {

    [SerializeField] public int nbKey = 0;
    public int nbLife = 3;
    public TextMeshProUGUI keyText;
    public TextMeshProUGUI lifeText;
    public TimerScript timer;
    // Use this for initialization
    void Start ()
    {
        UpdateKeyNbr();
        UpdateLifeNbr();
    }

    public void UpdateKeyNbr()
    {
        keyText.text = nbKey.ToString();
    }

    public void UpdateLifeNbr()
    {
        lifeText.text = nbLife.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            if (other.GetComponent<ItemScript>().isUsed == true)
                return;
            other.GetComponent<ItemScript>().MakeDisappear();
            nbKey++;
            UpdateKeyNbr();
        }
        if (other.tag == "Life")
        {
            if (other.GetComponent<ItemScript>().isUsed == true)
                return;
            other.GetComponent<ItemScript>().MakeDisappear();
            nbLife++;
            UpdateLifeNbr();
        }
        if (other.tag == "Clock")
        {
            if (other.GetComponent<ItemScript>().isUsed == true)
                return;
            timer.AddTime(10);
            other.GetComponent<ItemScript>().MakeDisappear();
        }
    }
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown("up"))
            transform.position += new Vector3(0, 0, -1);
        if (Input.GetKeyDown("down"))
            transform.position += new Vector3(0, 0, 1);
    }
}
