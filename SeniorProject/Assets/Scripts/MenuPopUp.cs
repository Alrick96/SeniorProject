using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuPopUp : MonoBehaviour
{
    public GameObject SetScreen;


    public void ButtonClicked(){

        //if (SetScreen.activeInHierarchy == false)
        //{

        //    SetScreen.SetActive(true);

        //}
        //else {

        //    SetScreen.SetActive(false);

        //}

        if (SetScreen.activeInHierarchy == true)
        {

            SetScreen.SetActive(false);

        }
        else
        {

            SetScreen.SetActive(true);

        }


    }
}
