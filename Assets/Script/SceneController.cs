using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneController : MonoBehaviour
{
    AudioController audioController;

    private void Start()
    {
        audioController = GameObject.FindWithTag("Music").GetComponent<AudioController>();
    }

    public void loadScene(string url)
    {
        audioController.PlaySFX(audioController.buttonOpen);
        SceneManager.LoadScene(url);
    }

    public void OpenPopup(Lean.Gui.LeanWindow leanWindow)
    {
        leanWindow.TurnOn();
        audioController.PlaySFX(audioController.buttonOpen);
    }

    public void ClosePopup(Lean.Gui.LeanWindow leanWindow)
    {
        leanWindow.TurnOff();
        audioController.PlaySFX(audioController.buttonClose);
    }
}
