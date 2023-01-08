using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagicChest : MonoBehaviour
{
           
    public GameObject sphere;
   
    bool isActive = false;
    bool isActiveUI = false;
    
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

    //public Vector3 target = new Vector3(0.939f, 0.446f, 2.87f);
    //public Vector3 altTarget = new Vector3(0.939f, 0.218f, 2.87f);
    // private int randomButton;

    // Start is called before the first frame update
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        Debug.Log("Trigger 2 success!");
        treasureUI.SetActive(true);
        isActive = true;
        
        //SphereMovement();
    }

    public void OnMouseExit()
    {
        //sphere.transform.position = new Vector3(0.939f, 0.218f, 2.87f);
    }

    public void Button1UI()
    {
        Debug.Log("Particle 1 success");
        treasureUI.SetActive(false);
        u1.SetActive(true);
        p1.SetActive(true);
        chest1.GetComponent<Animator>().enabled = false;
        EndGame();
    }

    public void Button2UI()
    {
        Debug.Log("Particle 2 success");
        treasureUI.SetActive(false);
        u2.SetActive(true);
        p2.SetActive(true);
        chest2.GetComponent<Animator>().enabled = false;
        EndGame();
    }

    public void Button3UI()
    {
        Debug.Log("Particle 3 success");
        treasureUI.SetActive(false);
        u3.SetActive(true);
        p3.SetActive(true);
        chest3.GetComponent<Animator>().enabled = false;
        EndGame();
    }

    public void EndGame()
    {
        Application.Quit();
    }

}
