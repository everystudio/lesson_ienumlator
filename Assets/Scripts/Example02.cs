using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example02 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CallParent());
    }

    IEnumerator CallParent()
    {
        Debug.Log("CallParentが呼ばれました");
        yield return StartCoroutine(CallChild());
        Debug.Log("CallParentが終了します");
    }

    IEnumerator CallChild()
    {
        Debug.Log("CallChildが呼ばれました");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("CallChildが終了します");
    }
}
