using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtionChange : MonoBehaviour
{
    public string type = "0";
    public string sceneName;
    [SerializeField] protected GameObject presentMenu;
    [SerializeField] protected GameObject nextMenu;
    void OnMouseUpAsButton()
    {

        if (type.Equals("level"))
        {
            SceneManager.LoadScene(sceneName);
        }

        if (type.Equals("quite"))
        {
            Application.Quit();
        }

        if (type.Equals("menuChange"))
        {
            presentMenu.gameObject.SetActive(false);
            nextMenu.SetActive(true);
        }

        
    }
}
