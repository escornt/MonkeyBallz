using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelListScript : MonoBehaviour {

    public GameObject[] listLevel;
    public int indexLvl = 0;
    public float speed = 5;

    public IEnumerator moveStage(GameObject level, int way)
    {
        for (int i = 0; i < speed; i++)
        {
            level.transform.position += way * new Vector3(70.0f / speed, 0, 0);
            yield return null;
        }
    }

    public void nextLevel()
    {
        if (indexLvl + 1 >= listLevel.Length)
            return;
        indexLvl++;

        foreach (GameObject level in listLevel)
            StartCoroutine(moveStage(level, -1));
    }

    public void previousLevel()
    {
        if (indexLvl - 1 < 0)
            return;
        indexLvl--;

        foreach (GameObject level in listLevel)
            StartCoroutine(moveStage(level, 1));
    }

    public void playLevel()
    {
        SceneManager.LoadScene(listLevel[indexLvl].GetComponent<LevelSelectionScript>().nameLevel);
    }
}
