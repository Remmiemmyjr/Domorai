using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ButtonType
{
    BATTLE_OPTIONS,
    EXIT,
}

public class ButtonManager : MonoBehaviour
{
    public ButtonType buttonType;
    public GameObject toDisable;
    public GameObject toEnable;
    
    void Start()
    {
        //toEnable.SetActive(false);
        //toDisable.SetActive(true);
    }
    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    toDisable.SetActive(true);
        //    toEnable.SetActive(false);
        //}
    }

    public void OnButtonClicked()
    {
        switch(buttonType)
        {
            case ButtonType.BATTLE_OPTIONS:
                toDisable.SetActive(false);
                toEnable.SetActive(true);
                break;

            case ButtonType.EXIT:
                Application.Quit();
                Debug.Log("Exited!");
                break;
        }

        
    }
}
