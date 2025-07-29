using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public GameObject objek;

    public void whenButtonClicked()
    {
        if (objek.activeInHierarchy == true)
            objek.SetActive(false);
        else
            objek.SetActive(true);
    }
}
