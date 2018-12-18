using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

    public int speed = 10;
    public GameObject levelSelect;
    public GameObject mainMenu;

    public IEnumerator TurnMenu(GameObject menu, float endValue)
    {
        float mvt = (endValue - menu.transform.rotation.eulerAngles.x) / speed;

        for (int i = 0; i < speed; i++)
        {
            menu.transform.Rotate(new Vector3(mvt, 0, 0));
            yield return null;
        }
        gameObject.transform.rotation = Quaternion.Euler(endValue, 0, 0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelSelectSwitch()
    {
        StartCoroutine(TurnMenu(levelSelect, 0));
        StartCoroutine(TurnMenu(mainMenu, 90));
    }

    public void MenuSelection()
    {
        StartCoroutine(TurnMenu(levelSelect, -90));
        StartCoroutine(TurnMenu(mainMenu, 0));
    }

	// Update is called once per frame
	void Update () {
		
	}
}
