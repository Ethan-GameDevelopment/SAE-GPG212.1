using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuOff : StateBase
{
    public GameObject mainMenu;
    public GameObject gameplayUI;

    private void OnEnable()
    {
        mainMenu.SetActive(false);
        gameplayUI.SetActive(true);
    }
}