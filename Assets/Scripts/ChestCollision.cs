using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestCollision : MonoBehaviour
{
    public Text gameText;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("MainCamera"))
            gameText.text = "Near object";
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("MainCamera"))
            gameText.text = "Object Found!";
    }
}
