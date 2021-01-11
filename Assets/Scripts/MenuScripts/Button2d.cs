using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2d : MonoBehaviour
{
   public void Scene1()
	{
		SceneManager.LoadScene("Grandmall");
	}

     public void Scene2()
	{
		SceneManager.LoadScene("HotelBiryan2");
	}

	 public void Scene3()
	{
		SceneManager.LoadScene("MaxRestro");
	}

	public void Scene4()
	{
		SceneManager.LoadScene("YoChina");
	}
}//class
