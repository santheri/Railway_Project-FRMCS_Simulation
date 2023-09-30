using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{   
    private Color oldColor = Color.white;
    [SerializeField] private string DemoScene;
    private string userInput;
    private bool userValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
 
    void Update () 
    {
    }
    void OnTriggerEnter(Collider other)
    {
        
        //Renderer render = GetComponent<Renderer>();
        //render.material.color = Color.green;
        SceneManager.LoadScene("DemoScene", LoadSceneMode.Single);

    }
       


    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
    }
}
