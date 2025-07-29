using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAnim : MonoBehaviour
{

    public Animator anim;

    public void stopAnim()
    {
        anim.Play("Scene", -1, 0f);
        anim.gameObject.GetComponent<Animator>().enabled = false;
    }

    public void playAnim()
    {
        anim.gameObject.GetComponent<Animator>().enabled = true;
    }

}
