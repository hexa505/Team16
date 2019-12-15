using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public static bool lab2Open = false;
    // Start is called before the first frame update
    void Start()
    {
        ShowMoney.money += 1000;
        Debug.Log(ShowMoney.money);

        if(Lab1.LabNum == 1)
        {
            GameObject msg = GameObject.Find("SuccessMsg");
            Debug.Log(Lab1.problem_num);
            msg.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);
            Debug.Log(msg.transform.GetChild(Lab1.problem_num));
            lab2Open = true;


            Lab1.total_num = 0;
            if (Lab1.problem_num == 2) Lab1.problem_num = 0;
            else Lab1.problem_num++;
        }

        else if(Lab1.LabNum == 2)
        {
            if(Lab2.lab2_problem_num == 0)
            {
                GameObject msg = GameObject.Find("SuccessMsg");
                msg.transform.GetChild(3).transform.gameObject.SetActive(true);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
