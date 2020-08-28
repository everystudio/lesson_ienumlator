using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice02 : MonoBehaviour
{
    private bool m_bIsClicked;
    void Start()
    {
        StartCoroutine(Base());
    }
    public void ButtonClicked()
    {
        m_bIsClicked = true;
    }
    IEnumerator Base()
    {
        m_bIsClicked = false;
		#region 回答欄

		#endregion
		Goal();
        yield break;
    }
    void Goal()
    {
        Debug.Log("Goal");
    }
}
