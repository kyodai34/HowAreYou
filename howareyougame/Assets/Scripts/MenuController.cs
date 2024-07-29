using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    /*[SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject prefabButton;
    [SerializeField] private GameObject position;*/
    
    public void StartTheGame()
    {
        /*menuCanvas.SetActive(false);*/
        Debug.Log("Mama");
        SceneManager.LoadScene(1);
    }
    
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Instantiate(prefabButton, position.transform );
        }
    }*/
}
