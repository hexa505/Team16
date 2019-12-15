using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showAnswer : MonoBehaviour
{
    public Text AnswerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AnswerText.text = Lab2.fireText;
    }
}
