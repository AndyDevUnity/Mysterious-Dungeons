using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizAnswers : MonoBehaviour
{
    [SerializeField] private GameObject _key;
    [SerializeField] private List<TMP_InputField> Keys = new List<TMP_InputField>();

    private void Update()
    {
        if (Keys[0].text == "€блоко" && Keys[1].text == "морской"
            && Keys[2].text == "им€" && Keys[3].text == "сон")
            _key.SetActive(true);
    }
}
