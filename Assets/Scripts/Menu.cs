using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public string menuName;
    [HideInInspector] public bool open;

    void Open()
    {
        open = true;
        gameObject.SetActive(true);
    }

    void Close()
    {
        
        gameObject.SetActive(false);
    }
}
