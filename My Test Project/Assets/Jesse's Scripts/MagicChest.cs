using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagicChest : MonoBehaviour
{
    
    public GameObject sphere;
            
    [Header("Treasure UI")]
    public GameObject treasureUI;

    [Header("Particle UI")]
    public GameObject u1;
    public GameObject u2;
    public GameObject u3;

    [Header("Particle Objs")]
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;

    [Header("Magic Chest Objs")]
    public GameObject chest1;
    public GameObject chest2;
    public GameObject chest3;
    

    public void OnMouseDown()
    {
        Debug.Log("Trigger 2 success!");
        treasureUI.SetActive(true);
    }   

    //UI Particle Button Functions 
    public void Button1UI()
    {
        Debug.Log("Particle 1 success");
        treasureUI.SetActive(false);
        u1.SetActive(true);
        p1.SetActive(true);
        chest1.GetComponent<Animator>().enabled = false;        
    }

    public void Button2UI()
    {
        Debug.Log("Particle 2 success");
        treasureUI.SetActive(false);
        u2.SetActive(true);
        p2.SetActive(true);
        chest2.GetComponent<Animator>().enabled = false;       
    }

    public void Button3UI()
    {
        Debug.Log("Particle 3 success");
        treasureUI.SetActive(false);
        u3.SetActive(true);
        p3.SetActive(true);
        chest3.GetComponent<Animator>().enabled = false;        
    }

    public void GameOver() //game over function button
    {
        Debug.Log("Game Over! Shutdown!");
        Application.Quit();
    }

   

}
