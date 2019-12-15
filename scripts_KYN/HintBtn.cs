using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintBtn : MonoBehaviour
{
    public void showHint()
    {
        ShowMoney.money -= 200;

        if (Lab1.LabNum == 1)
        {
            GameObject msg = GameObject.Find("Hint");
            Debug.Log(Lab1.problem_num);
            msg.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);

            Lab1.total_num = 0;
        }

        else if (Lab1.LabNum == 2)
        {
            if (Lab2.fireFailed)
            {
                GameObject msg = GameObject.Find("HintFire");
                msg.transform.GetChild(0).transform.gameObject.SetActive(true);
                return;
            }

            if (!Lab2.isIon)
            {
                GameObject msg = GameObject.Find("HintIon");
                msg.transform.GetChild(0).transform.gameObject.SetActive(true);
                return;
            }

            if (Lab2.lab2_problem_num == 0)
            {
                GameObject msg = GameObject.Find("Hint");
                msg.transform.GetChild(3).transform.gameObject.SetActive(true);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
