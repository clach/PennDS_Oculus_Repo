using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonUIInteraction : MonoBehaviour {

    protected Material oldHoverMat;
    public Material yellowMat;

    public void OnHoverEnter(Transform t) {
        oldHoverMat = t.gameObject.GetComponent<Renderer>().material;
        t.gameObject.GetComponent<Renderer>().material = yellowMat;
    }

    public void OnHoverExit(Transform t) {
        t.gameObject.GetComponent<Renderer>().material = oldHoverMat;
    }

    public void OnSelected(Transform t) {
    }
}
