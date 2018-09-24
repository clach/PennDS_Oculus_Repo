using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHere : MonoBehaviour {

    public GameObject InfoSlide;
    public GameObject Marker;
    
    public void ShowMarker(bool show)
    {
        Marker.SetActive(show);
    }

    public void ShowInfoSlide(bool show)
    {
        InfoSlide.SetActive(show);
    }
}
