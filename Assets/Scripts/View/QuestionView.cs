using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionView : MonoBehaviour
{
    [SerializeField]
    public QuestionView view;
    [SerializeField]
    private Text questionText;
    [SerializeField]
    private Text rightText;
    [SerializeField]
    private GameObject first;
    [SerializeField]
    private GameObject second;

    private void Start()
    {
        first.gameObject.SetActive(true);
        second.gameObject.SetActive(false);
    }

    public void ShowQuestion(string question)
    {
        questionText.text = question;
    }

    public void ShowAnswer(int right, int wrong)
    {
        first.gameObject.SetActive(false);
        second.gameObject.SetActive(true);
        rightText.text = "Правильных ответов - " + right + " Неправильных ответов - " + wrong;
    }
}
