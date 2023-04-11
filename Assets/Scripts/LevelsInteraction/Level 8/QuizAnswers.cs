using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizAnswers : MonoBehaviour
{
    [SerializeField] private GameObject _key;
    [SerializeField] private List<TMP_InputField> Keys = new List<TMP_InputField>();

    private void Update()
    {
        if (Keys[0].text == "������" && Keys[1].text == "�������"
            && Keys[2].text == "���" && Keys[3].text == "���")
            _key.SetActive(true);
    }
}
