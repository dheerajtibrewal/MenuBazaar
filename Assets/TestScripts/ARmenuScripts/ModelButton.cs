using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelButton : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform;
    private RectTransform rectTransform;
    private Image image;
     private void Awake() {
         rectTransform = GetComponent<RectTransform>();
         image = GetComponent<Image>();
        
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        var screenPoint = Camera.main.WorldToScreenPoint(targetTransform.position );
        rectTransform.position = screenPoint;
        var viewportPoint = Camera.main.WorldToViewportPoint(targetTransform.position);
        var distanceFromCenter = Vector2.Distance(viewportPoint,Vector2.one*0.5f);
        var show = distanceFromCenter< 0.3f;
        image.enabled = show;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
}
