using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{

    public void grab(GameObject obj)
    {
        Vector3 player = GameObject.Find("Player").transform.position;
        //Debug.Log(EventSystem.current.currentSelectedGameObject);
        obj.transform.gameObject.SetActive(false);
        GameObject.Find("Main Camera").transform.GetChild(1).transform.gameObject.SetActive(true);
        GameObject.Find("ProblemSet").transform.GetChild(1).transform.gameObject.SetActive(true);
        GameObject.Find("Status").transform.GetChild(0).transform.gameObject.SetActive(true);

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
