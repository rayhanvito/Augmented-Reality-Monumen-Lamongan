using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScene : MonoBehaviour
{
    public void Resetscene()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
