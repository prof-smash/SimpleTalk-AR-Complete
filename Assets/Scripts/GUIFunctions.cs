using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIFunctions : MonoBehaviour
{
    public Animator guiAnim;
    public Text pressedText;

    private int numOfPresses = 0;

    public void ShowOrHideButton()
    {
        guiAnim.SetTrigger("Visible");
    }

    public void ButtonAction()
    {
        numOfPresses++;
        pressedText.text = "Times Pressed: " + numOfPresses;
    }
}
