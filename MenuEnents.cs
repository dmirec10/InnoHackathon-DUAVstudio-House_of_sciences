using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MenuEnents : MonoBehaviour
{
    public Image imagestart, imageexit, imageshop, imagechoosesubject;
    public Image imagemathematics, imagephysics, imagechemistry;
    public Image imageaddition, imagesubtraction, imagemultiplication, imagedivision;
    public Image imageoxides, imageacids, imagegrounds, imagesalts;
    public Color colorunbutton, colorbutton;
    public TMP_Text textchosensubjects;
    public GameObject panelmain, panelchoosesubject, panelmathematics, panelchemistry;
    public Animator animmain, animchoosesubject, animmathematics, animchemistry;
    private void Update()
    {
        /*if (Input.anyKey)
        {
                panelchoosesubject.SetActive(true);
                Invoke("AnimChooseSubjectsFalse", 1);
                panelmain.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            panelchoosesubject.SetActive(true);
        }*/
    }
    public void ButtonStart() //когда райкастр наведенен на кнопку start
    {
        imagestart.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            animmain.enabled = true;
        }
    }
    void UnButtonStart() //когда райкастр не наведенен на кнопку start
    {
        imagestart.color = colorunbutton;
    }
    void ButtonChooseSubject()
    {
        imagechoosesubject.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            panelchoosesubject.SetActive(true);
            Invoke("AnimChooseSubjectsFalse", 1);
            panelmain.SetActive(false);
        }
    }
    void UnButtonChooseSubject()
    {
        imagechoosesubject.color = colorunbutton;
    }
    void ButtonShop()
    {
        imageshop.color = colorbutton;
    }
    void UnButtonShop()
    {
        imageshop.color = colorunbutton;
    }
    void ButtonExit()
    {
        imageexit.color = colorbutton;
    }
    void UnButtonExit()
    {
        imageexit.color = colorunbutton;
    }
    void ButtonMathematics()
    {
        imagemathematics.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            panelmathematics.SetActive(true);
            Invoke("AnimMathematicsFalse", 1);
            panelchoosesubject.SetActive(false);
        }
    }
    void UnButtonMathematics()
    {
        imagemathematics.color = colorunbutton;
    }
    void ButtonPhysics()
    {
        imagephysics.color = colorbutton;
    }
    void UnButtonPhysics()
    {
        imagephysics.color = colorunbutton;
    }
    void ButtonChemistry()
    {
        imagechemistry.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            panelchemistry.SetActive(true);
            Invoke("AnimChemistryFalse", 1);
            panelchoosesubject.SetActive(false);
        }
    }
    void UnButtonChemistry()
    {
        imagechemistry.color = colorunbutton;
    }
    void ButtonAddition()
    {
        imageaddition.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Mathematics/Addition";
            panelmathematics.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonAddition()
    {
        imageaddition.color = colorunbutton;
    }
    void ButtonSubtraction()
    {
        imagesubtraction.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Mathematics/Subtraction";
            panelmathematics.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonSubtraction()
    {
        imagesubtraction.color = colorunbutton;
    }
    void ButtonMultiplication()
    {
        imagemultiplication.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Mathematics/Multiplication";
            panelmathematics.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonMultiplication()
    {
        imagemultiplication.color = colorunbutton;
    }
    void ButtonDivision()
    {
        imagedivision.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Mathematics/Division";
            panelmathematics.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonDivision()
    {
        imagedivision.color = colorunbutton;
    }
    void ButtonOxides()
    {
        imageoxides.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Chemistry/Oxides";
            panelchemistry.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonOxides()
    {
        imageoxides.color = colorunbutton;
    }
    void ButtonAcids()
    {
        imageacids.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Chemistry/Acids";
            panelchemistry.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonAcidsn()
    {
        imageacids.color = colorunbutton;
    }
    void ButtonGrounds()
    {
        imagegrounds.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Mhemistry/Grounds";
            panelchemistry.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonGrounds()
    {
        imagegrounds.color = colorunbutton;
    }
    void ButtonSalts()
    {
        imagesalts.color = colorbutton;
        if (Input.GetKeyDown(KeyCode.E))
        {
            textchosensubjects.text = "Chemistry/Salts";
            panelchemistry.SetActive(false);
            panelmain.SetActive(true);
        }
    }
    void UnButtonSalts()
    {
        imagesalts.color = colorunbutton;
    }
    void AnimChooseSubjectsFalse()
    {
        animchoosesubject.enabled = false;
    }
    void AnimMathematicsFalse()
    {
        animmathematics.enabled = false;
    }
    void AnimChemistryFalse()
    {
        animchemistry.enabled = false;
    }
}
