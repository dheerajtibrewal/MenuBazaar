using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchScreen : MonoBehaviour , IPointerDownHandler
{
    public MenuPanle menuPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //  void OnMouseDown() {
    //       menuPanel.MenuPanel.transform.position = MenuOrigPos.transform.position; 
    //       Debug.Log("Tap is Applied");
    //   }

       public void OnPointerDown (PointerEventData eventData) 
     {
         Debug.Log (" Was Clicked.");
         // menuPanel.MenuPanel.transform.position = MenuOrigPos.transform.position;
          menuPanel.moveAgain();
              
          
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
