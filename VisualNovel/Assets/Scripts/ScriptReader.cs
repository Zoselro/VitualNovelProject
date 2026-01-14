using System.IO;
using UnityEngine;

public class ScriptReader : MonoBehaviour
{
    private string csvFilePath = "Scripts/DialogueScript.csv";

    [SerializeField] private Sprite normal;
    [SerializeField] private Sprite happy;
    [SerializeField] private Sprite angry;
    [SerializeField] private Sprite sad;
    public enum Emotion
    {
        Normal,
        Happy,
        Angry,
        Sad,
        Disappointed
    }

    struct CharState
    {
        string name;
        string script;
        Emotion emotion;
    }

    public void ReadCSV(string path)
    {
        using (StreamReader sr = new StreamReader(new FileStream(Application.dataPath + "/" + path, FileMode.Open))) // 파일 생성후 열기
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] result = line.Split(',');
                for (int i = 0; i < result.Length; i++)
                    Debug.Log(result[i]);
            }
            sr.Close();
        }
    }
}
