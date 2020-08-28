using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice01 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CallA());
    }

    IEnumerator CallA()
    {
        Debug.Log("CallAが呼ばれました");
        yield break;
        Debug.Log("CallAが終了しました");
    }
}
