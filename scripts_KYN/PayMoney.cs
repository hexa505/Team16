using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayMoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMoney.money -= 500;
        Debug.Log(ShowMoney.money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
