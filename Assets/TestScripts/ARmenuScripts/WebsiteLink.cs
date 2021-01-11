using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebsiteLink : MonoBehaviour
{

      public void OpenURL()
      {
          Application.OpenURL("https://thearchmate.com/");
         
      }
    public void OpenOffer()
      {
          Application.OpenURL("https://sites.google.com/view/offersplaza/menu");
         
      }

     public void OpenFeedback()
      {
          Application.OpenURL("https://docs.google.com/forms/d/1URt0PiTws4s6Xt7PyfqqqsFnA45FGcelthSbuT797cw/viewform?edit_requested=true");
         
      }
}
