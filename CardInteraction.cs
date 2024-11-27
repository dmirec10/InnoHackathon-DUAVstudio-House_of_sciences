using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInteraction : MonoBehaviour
{
    [HideInInspector] public string currentAnswer;
    [HideInInspector] public bool canPickUpCard = true;

    // Start is called before the first frame update
    void Start()
    {
        currentAnswer = null;
    }
}
