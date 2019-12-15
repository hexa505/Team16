using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartLab1 : MonoBehaviour
{
    public GameObject Problems;
    public GameObject Structure;

    public void startLab1()
    {
        EventSystem.current.currentSelectedGameObject.SetActive(false);
        
        //NH3
        if(Lab1.problem_num == 0)
        {
            Problems.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);
            Structure.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);
        }
        //CO2
        else if (Lab1.problem_num == 1)
        {
            Problems.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);
            Structure.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);
        }
        //H2O
        else if (Lab1.problem_num == 2)
        {
            Problems.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);
            Structure.transform.GetChild(Lab1.problem_num).transform.gameObject.SetActive(true);
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
