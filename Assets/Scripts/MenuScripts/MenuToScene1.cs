﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToScene1 : MonoBehaviour
{
     public void Scene1()
	{
		SceneManager.LoadScene("ARscene1");
	}

     public void Scene2()
	{
		SceneManager.LoadScene("ARscene2");
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
