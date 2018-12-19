using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalReached : MonoBehaviour
{
    public GameObject goalText;
    public string nextLevel = "Level2";
    public AudioSource yaySound;
    private bool played = false;

    private void Start()
    {
        goalText.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<PlayerScript>().nbKey > 0)
            {
                if (yaySound && !played)
                {
                    yaySound.Play();
                    played = true;
                }
                goalText.SetActive(true);
                StartCoroutine(LoadLevelAfterDelay(3.0f));
            }
        }
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextLevel);
    }
}
