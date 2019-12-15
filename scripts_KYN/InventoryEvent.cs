using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryEvent : MonoBehaviour
{
    public void selectElement(GameObject sphere)
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(name);
        GameObject Structure = GameObject.Find("Structure");

        if (Lab1.problem_num == 0)
        {
            if (Lab1.total_num == 4) return;
            GameObject molecule = Structure.transform.GetChild(Lab1.problem_num).transform.gameObject;
            GameObject element = molecule.transform.GetChild(Lab1.total_num).transform.gameObject;
            Debug.Log(element);
            Vector3 pos = element.transform.position;
            GameObject obj = Instantiate(sphere, pos, Quaternion.identity);
            Lab1.history.Push(obj);
            Lab1.selected.Push(name);
            element.SetActive(false);
            obj.SetActive(true);
        }

        else if (Lab1.problem_num == 1 || Lab1.problem_num == 2)
        {
            if (Lab1.total_num == 3) return;
            GameObject molecule = Structure.transform.GetChild(Lab1.problem_num).transform.gameObject;
            GameObject element = molecule.transform.GetChild(Lab1.total_num).transform.gameObject;
            Debug.Log(element);
            Vector3 pos = element.transform.position;
            GameObject obj = Instantiate(sphere, pos, Quaternion.identity);
            Lab1.history.Push(obj);
            Lab1.selected.Push(name);
            element.SetActive(false);
            obj.SetActive(true);
        }

        Lab1.total_num++;
        Debug.Log(Lab1.selected.Count);
    }

    public void undo()
    {
        if (Lab1.total_num == 0) return;
        Destroy(Lab1.history.Pop());
        Lab1.selected.Pop();
        Lab1.total_num--;
        GameObject Structure = GameObject.Find("Structure");
        GameObject molecule = Structure.transform.GetChild(Lab1.problem_num).transform.gameObject;
        GameObject element = molecule.transform.GetChild(Lab1.total_num).transform.gameObject;
        element.SetActive(true);
        Debug.Log(Lab1.selected.Count);
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
