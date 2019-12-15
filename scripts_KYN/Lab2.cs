using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Element
{
    public string name;
    public int num;

    public Element(string name, int num)
    {
        this.name = name;
        this.num = num;
    }
}
*/

public class Lab2 : MonoBehaviour
{

    public static Stack<string> fireAnswer = new Stack<string>();
    public static string subject;
    public static bool correct = true;
    public static bool isIon = false;
    public static int lab2_problem_num;
    public static string fireText = "Answer:";
    public static string failFlag = "NaCl";
    public static bool noFire = false;
    public static bool fireFailed = false;

    // Start is called before the first frame update
    void Start()
    {
        // 랜덤 넘버 만들어서 problem start
        lab2_problem_num = 0; //NaCl
        Lab1.LabNum = 2;
        //Problems.transform.GetChild(problem_num).transform.gameObject.SetActive(true);
        //Structure.transform.GetChild(problem_num).transform.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
