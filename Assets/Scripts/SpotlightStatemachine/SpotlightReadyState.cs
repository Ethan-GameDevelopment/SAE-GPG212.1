using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightReadyState : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        gameObject.GetComponent<Light>().color = Color.red;
        // set movement speed as whatever
        // set interactable = true
    }

    private void Update()
    {
        throw new NotImplementedException();
    }

    private void OnDisable()
    {
        throw new NotImplementedException();
    }
}
