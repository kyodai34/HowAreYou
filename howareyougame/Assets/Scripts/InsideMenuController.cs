using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class InsideMenuController : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject saveMenu;
    public bool isOpen = false;
    public bool isSaveOpen = false;

    public string dangertext = "мы ещё не закончили, так что не надо уходить от разговора";
    public string currentText = "";
    public float typewriterSpeed = 0.2f;
    public Text textComponent;
    public GameObject exitMenuButton;
    public GameObject textExit;
    public Text exitText;
    
    private void Start()
    {
        menu.SetActive(isOpen);
        saveMenu.SetActive(false);
        GameObject textGameObject = GameObject.Find("Text mob");
        textComponent = textGameObject.GetComponent<Text>();
        exitText = textExit.GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isSaveOpen)
        {
            isOpen = !isOpen;
        }
        menu.SetActive(isOpen);
    }

    public void ContinueButton()
    {
        isOpen = false;
    }

    public void SaveGame()
    {
        isOpen = false;
        isSaveOpen = true;
        saveMenu.SetActive(true);
        
    }

    public void BackButton()
    {
        isOpen = true;
        isSaveOpen = false;
        saveMenu.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void ExitMainMenu()
    {
        isOpen = false;
        StartCoroutine(TypewriterCoroutine());
        exitMenuButton.SetActive(false);
        exitText.text = "Выйти";
    }
    
    private IEnumerator TypewriterCoroutine()
    {
        foreach (char character in dangertext)
        {
            currentText += character;
            textComponent.text= currentText;
            yield return new WaitForSeconds(typewriterSpeed);
        }
    }
}
