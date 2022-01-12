using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOutScript : MonoBehaviour
{
    public GameObject Object;

    private bool _zoomIn;
    private bool _zoomOut;

    public float Scale = 0.1f;

    void Update()
      {
     if(_zoomIn)
       {
     Object.transform.localScale += new Vector3(Scale, Scale, Scale);   
    }   
    if(_zoomOut)
      {
     Object.transform.localScale -= new Vector3(Scale, Scale, Scale);   
    }
    }
    public void OnPressZoomIn()
      {
     _zoomIn = true;   
    }

    public void OnReleaseZoomIn()
      {
     _zoomIn = false;   
    }

    public void OnPressZoomOut()
      {
     _zoomOut = true;   
    }

    public void OnReleaseZoomOut()
      {
     _zoomOut = false;   
    }
   
}
