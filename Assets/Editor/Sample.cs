using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test
{
    [MenuItem("Tools/Test")]
    static void A()
    {
        Debug.Log(DateTime.Now);
        EditorCoroutine.StartCoroutine(new EditorWaitForSeconds(3, () =>
        {
            Debug.Log(DateTime.Now);
        }));
    }
}
