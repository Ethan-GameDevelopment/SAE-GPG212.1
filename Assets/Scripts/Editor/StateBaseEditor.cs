using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(StateBase),true)]
public class StateBaseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Toggle Menu"))
        {
            (target as StateBase)?.stateManager.ChangeState(target as StateBase);
        }
    }
}

