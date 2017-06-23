using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryClick : MonoBehaviour {
    public bool boll;
    public Transform item;
    public Transform canvas;

    void Update()
    {
        if (boll == true)
        {

            item.position = Input.mousePosition;
        }


    }
    public void CLick(Transform t)
    {
        if (item == null)
        {
            if (t.childCount > 0)
            {
                item = t.GetChild(0);
                item.SetParent(canvas);
                boll = true;
            }
        }
        else
        {
            if (t.childCount > 0)
            {
                item.SetParent(t);
                item.position = t.position;
                item = t.GetChild(0);
                item.SetParent(canvas);
            }
            else
            {
                item.SetParent(t);
                item.position = t.position;
                item = null;
                boll = false;
            }
        }
    }



}

