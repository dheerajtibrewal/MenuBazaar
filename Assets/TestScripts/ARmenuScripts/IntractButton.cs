 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.Events;
 using UnityEngine.UI;

public class IntractButton : MonoBehaviour
{
    public GameObject definedButton;
     public UnityEvent OnClick = new UnityEvent();
     
     bool buttPressed;
     public Material normalMat;
     public Material highBut;
     Renderer rend;
     public GameObject gify;
    
    
     Vector3 start;
 
     // Use this for initialization
     void Start () {
         definedButton = this.gameObject;
         rend = GetComponent<Renderer>();
        // start = gify.transform.position;
     }
     
     // Update is called once per frame
     void Update () {
         var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit Hit;
         
         if (Input.GetMouseButtonDown(0))
         {
             if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
             {
                 Debug.Log("Button Clicked");
                 if(buttPressed == false){
                 
                 buttPressed = true;
                 rend.material = highBut;
               //  gify.transform.Translate(xValue*speed*Time.deltaTime,0,0);
                 gify.SetActive(true);

                 }else
                 {
                     
                     buttPressed = false;
                     rend.material = normalMat;
                    // gify.transform.position = start;
                      gify.SetActive(false);
                 }
                 OnClick.Invoke();
             }
         }    
     }
}
