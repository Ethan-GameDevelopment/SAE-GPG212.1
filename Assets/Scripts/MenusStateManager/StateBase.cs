using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase : MonoBehaviour
{
    public MenuStateManager stateManager;

    public void Awake()
    {
        stateManager = GetComponent<MenuStateManager>();
    }
}
