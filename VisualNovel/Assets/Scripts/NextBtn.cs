using TMPro;
using UnityEngine;

public class NextBtn : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI line;

    string text = "글자길이 측정중 글자길이 측정중 글자길이 측정중 " +
                "글자길이 측정중 글자길이 측정중 글자길이 측정중 글자길이 측정중 " +
                "글자길이 측정중 글자길이 측정중 글자길이 측";

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisPlayText(line, text);
        }
    }

    public void DisPlayText(TextMeshProUGUI line, string text)
    {
        line.text = text;
    }
}
