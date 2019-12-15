using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMoney : MonoBehaviour
{
    public static int money = 0;
    public Text CountText;
    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "$" + money.ToString();
        if(Reward.lab2Open)
        {
            GameObject.Find("2nd").GetComponent<Button>().interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
