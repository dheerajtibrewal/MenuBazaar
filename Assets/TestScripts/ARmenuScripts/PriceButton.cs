using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceButton : MonoBehaviour
{
    bool value;
public GameObject price;
//public GameObject HT;

public void showPrice(){
    {if (value == false){
        price.SetActive(true);
       
        value = true;
    }else{
         price.SetActive(false);
        
         value = false;
    }
}
}
    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    // void OnMouseDown()
    // {if (value == false){
    //     price.SetActive(true);
    //     HT.SetActive(true);
    //     value = true;
    // }else{
    //      price.SetActive(false);
    //      HT.SetActive(false);
    //      value = false;
    // }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
if (Physics.Raycast (ray, 100)) {
print ("Hit something");
}
    }
}
