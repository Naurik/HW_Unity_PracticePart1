using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour
{
    [SerializeField]
    private QuestionView questionView;
    private QuestionClass[] root;
    [SerializeField]
    private int countQuestion, rightAnswer, wrongAnswer;

    private void Start()
    {
        countQuestion = 0;
    }

    public void NewData(Root root)
    {
        this.root = root.questions;
        Debug.Log(this.root[0].name_ru);
        Show();
    }

    public void Show()
    {
        questionView.ShowQuestion(root[countQuestion].name_ru);
    }

    public void OnClick(bool answer)
    {
        if (countQuestion < root.Length)
        {
            if (root[countQuestion].right_answer == answer)
            {
                rightAnswer++;
            }
            else
            {
                wrongAnswer++;
            }
            if (countQuestion == root.Length - 1)
                questionView.ShowAnswer(rightAnswer, wrongAnswer);
            else
            {
                countQuestion++;
                questionView.ShowQuestion(root[countQuestion].name_ru);
            }
        }
    }
}


