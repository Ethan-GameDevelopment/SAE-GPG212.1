using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuOn : StateBase
{
    public GameObject mainMenu;
    public GameObject gameplayUI;

    private void OnEnable()
    {
        mainMenu.SetActive(true);
        gameplayUI.SetActive(false);
    }
}
