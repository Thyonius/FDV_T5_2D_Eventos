using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    Text text;
    bool isStartText;

    void Start()
    {
        text = gameObject.GetComponentInChildren<Text>();
        text.text = "START";
        isStartText = true;
    }

    public void ChangeText()
    {
        if (isStartText)
        {
            text.text = "STOP";
        }
        else
        {
            text.text = "START";
        }

        isStartText = !isStartText;
    }
}
