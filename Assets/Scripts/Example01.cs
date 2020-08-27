using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example01 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DelayLog());
    }

    IEnumerator DelayLog()
    {
        Debug.Log("5秒後にログが表示されます");
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Here!");
    }
}
