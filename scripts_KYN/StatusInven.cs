using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusInven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Grid = GameObject.Find("GridSetting");
        GameObject SlotImg = GameObject.Find("SlotImg");

        int i = 0;
        foreach (string name in Collect1.Inventory1)
        {
            if (name != null)
            {
                GameObject img = SlotImg.transform.FindChild(name).transform.gameObject;
                GameObject obj = Instantiate(img);
                obj.transform.parent = Grid.transform.GetChild(i).transform;
                obj.transform.localPosition = Vector3.zero;
                obj.SetActive(true);
            }
            i++;
        }

        
        foreach (string name in Collect2.Inventory2)
        {
            if (name != null)
            {
                GameObject img = SlotImg.transform.FindChild(name).transform.gameObject;
                GameObject obj = Instantiate(img);
                obj.transform.parent = Grid.transform.GetChild(i).transform;
                obj.transform.localPosition = Vector3.zero;
                obj.SetActive(true);
            }
            i++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
