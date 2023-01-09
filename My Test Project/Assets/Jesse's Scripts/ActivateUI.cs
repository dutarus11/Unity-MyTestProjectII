using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ActivateUI : MonoBehaviour
{
    public GameObject sphere;

    [Header("Main UI Objs")]
    public GameObject mainUI;
    public GameObject weaponUI;
    public GameObject pointsUI;
    public GameObject instrumentUI;
    
    [Header("Weapon Objs")]
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public float speed = 10;
    public Vector3 target = new Vector3(0.939f, 0.446f, 2.87f);
    public Vector3 altTarget = new Vector3(0.939f, 0.218f, 2.87f);
   
    public void OnMouseDown()
    {
        Debug.Log("Trigger success!");
        mainUI.SetActive(true);         
    }
       
    public void OnUIClick()
    {
        Debug.Log("Success on UI");
        weaponUI.SetActive(true);       
        mainUI.SetActive(false);                       
    }

    public void OnPointsUIClick()
    {
        Debug.Log("Success on Point UI");        
        pointsUI.SetActive(true);
        mainUI.SetActive(false);
    }

    public void OnInstrumentUIClick()
    {
        Debug.Log("Success on Instrument UI");
        instrumentUI.SetActive(true);
        mainUI.SetActive(false);
    }



}
