using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    [SerializeField] Menu[] menus;

    public void OpenMenu(string menuName)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            if(menus[i].menuName == menuName)
            {
                OpenMenu(menus[i]);
            }
        }
    }

    public void OpenMenu(Menu menu)
    {
       
    }
}
