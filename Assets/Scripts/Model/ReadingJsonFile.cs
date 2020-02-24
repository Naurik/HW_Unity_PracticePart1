using UnityEngine;
using System.IO;

public class ReadingJsonFile : MonoBehaviour
{
    [SerializeField]
    private string path;
    [SerializeField]
    private string jsonString;
    [SerializeField]
    private QuestionController questionController;

    void Awake()
    {
        Serialize();
    }

    public void Serialize()
    {
        path = Application.streamingAssetsPath + "/Questions.json";
        jsonString = File.ReadAllText(path);
        Root root = JsonUtility.FromJson<Root>("{\"questions\":" + jsonString + "}");
        questionController.NewData(root);
    }
}

[System.Serializable]
public class Root
{
    public QuestionClass[] questions;
}

[System.Serializable]
public class QuestionClass
{
    public int id;
    public string name_ru;
    public bool right_answer;
}




