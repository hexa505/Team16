using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{

    public Item item;
    public Image itemImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*

    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }
    public void AddItem(Item _item)
    {
        item = _item;
        AddItem(item);
        itemImage.sprite = item.itemImage;
        SetColor(1);
    }
    public void SetSlotCount(int _count)
    {
        
    }

    private void ClearSlot()
    {
        item = null;
        itemImage.sprite = null;
        SetColor(0);
    }
    */
}
