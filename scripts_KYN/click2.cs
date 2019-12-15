using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click2 : MonoBehaviour
{
    public void onClick(string name)
    {
        int index = Collect2.Inventory2.Count;
        Collect2.Inventory2.Add(name);
        if (index < Collect2.Inventory2.Count)
        {
            GameObject Grid = GameObject.Find("GridSetting");
            GameObject SlotImg = GameObject.Find("SlotImg");
            GameObject img = SlotImg.transform.FindChild(name).transform.gameObject;
            GameObject obj = Instantiate(img);
            obj.transform.parent = Grid.transform.GetChild(index).transform;
            obj.transform.localPosition = Vector3.zero;
            obj.SetActive(true);
        }
    }
}
