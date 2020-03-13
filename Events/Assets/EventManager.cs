using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public static EventManager current;

    private void Awake()
    {
        current = this;
    }

    public event Action OnClickedButton;

    public void ButtonClicked()
    {
        if (OnClickedButton != null)
        {
            OnClickedButton();
        }
    }
}
