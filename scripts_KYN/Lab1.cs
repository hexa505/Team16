using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

public class Lab1 : MonoBehaviour
{

    public static Stack<GameObject> history = new Stack<GameObject>();
    public static Stack<string> selected = new Stack<string>();
    public static int total_num = 0;
    public static float x = 0.25f;
    public static float z = 1.5f;
    public static int problem_num = 0;
    public static int LabNum;
    public GameObject Problems;
    public GameObject Structure;

    // Start is called before the first frame update
    void Start()
    {
        LabNum = 1;
        Debug.Log(problem_num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
