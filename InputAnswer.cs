using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputAnswer : MonoBehaviour
{
    private FirstPersonController fps;
    public ProblemsGenerations generator;
    
    public GameObject panel, correct, wrong;
    public TMP_InputField field;
    bool canType = true;
    
    private string playerAnswer;

    private void Start()
    {
        fps = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            fps.playerCanMove = true;
            fps.cameraCanMove = true;
            fps.enableHeadBob = true;
            panel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void ActivatePanel()
    {
        panel.SetActive(true);
        
        fps.cameraCanMove = false;
        fps.playerCanMove = false;
        fps.enableHeadBob = false;
        Cursor.lockState = CursorLockMode.None;
    }
    public void InputString()
    {
        playerAnswer = field.text;
        Debug.Log(playerAnswer);
    }
    public void ButtonEnter()
    {
        if (generator.cAnswer == playerAnswer && canType)
        {
            correct.SetActive(true);
            wrong.SetActive(false);
            canType = false;
        }
        else if (canType && playerAnswer != null && playerAnswer != "")
        {
            wrong.SetActive(true);
        }
    }
}
