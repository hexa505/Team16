using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class InventoryEvent2 : MonoBehaviour
{
    public void selectElement(GameObject water)
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        Lab2.subject = name;
        if (name.Equals("NaCl")) Lab2.isIon = true;
        else Lab2.isIon = false;

        GameObject Element = GameObject.Find("Element");
        Element.transform.gameObject.SetActive(false);
        Element.transform.gameObject.SetActive(true);
        water.transform.gameObject.SetActive(true);

        Debug.Log(name);
        Debug.Log(Lab2.subject);
    }

    
    public void startExperiment()
    {
        if (!Lab2.isIon)
        {
            changescenes.PreviousScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Fail");
        }

        GameObject.Find("Effect").transform.GetChild(0).transform.gameObject.SetActive(true);

        if (Lab2.noFire)
        {
            Invoke("showProblem", 3f);
        }
        else
        {
            Invoke("fire", 3f);
            Invoke("showAlert", 4f);
            Debug.Log("invoke");
        }
    }

    void fire()
    {
        GameObject.Find("Effect").transform.GetChild(1).transform.gameObject.SetActive(true);
    }

    void showProblem()
    {
        Debug.Log("showProblem");
        if(Lab2.subject.Equals("NaCl"))
        {
            GameObject.Find("ProblemSet").transform.GetChild(0).transform.gameObject.SetActive(true);
        }
    }

    void showAlert()
    {
        GameObject.Find("Alert").transform.GetChild(1).transform.gameObject.SetActive(true);
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
