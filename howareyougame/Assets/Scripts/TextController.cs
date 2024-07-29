using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{
    public string fullText = "Ну здравствуй. Мой дорогой и горячо любимый пиздюк";
    public float typewriterSpeed = 0.1f;
    public GameObject firstAnswer;
    public GameObject secondAnswer;
    public GameObject foodOrder;

    public Text textComponent;
    private string currentText = "";

    private void Start()
    {
        firstAnswer.SetActive(false);
        secondAnswer.SetActive(false);
        foodOrder.SetActive(false);
        GameObject textGameObject = GameObject.Find("Text mob");
        textComponent = textGameObject.GetComponent<Text>();
        StartCoroutine(TypewriterCoroutine());
    }

    private IEnumerator TypewriterCoroutine()
    {
        foreach (char character in fullText)
        {
            currentText += character;
            textComponent.text= currentText;
            yield return new WaitForSeconds(typewriterSpeed);
        }
        firstAnswer.SetActive(true);
        secondAnswer.SetActive(true);
        foodOrder.SetActive(true);
    }
}