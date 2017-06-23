using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSwitch : MonoBehaviour {
    public Transform item;

    public void CLick(Transform T)
    {
        if (T.childCount > 0)
        {
            item = T.GetChild(0);
            item.SetParent(transform);
            item.position = T.position;
        }
    }
}
