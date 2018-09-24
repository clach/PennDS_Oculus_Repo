using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBeam : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    private LineRenderer beam;
    private const float t = 400f;
    private const float BEAM_WIDTH = 0.01f;

	// Use this for initialization
	void Start () {
        beam = GetComponent<LineRenderer>();
        beam.startWidth = BEAM_WIDTH;
        beam.endWidth = BEAM_WIDTH;
	}
	
	// Update is called once per frame
	void Update () {
        CastBeam();
	}

    private void CastBeam()
    {
        beam.enabled = true;
        beam.SetPosition(0, transform.position);

        ray.origin = transform.position;
        ray.direction = transform.forward;

        beam.SetPosition(1, transform.position + transform.forward * t);

       // Debug.DrawLine(transform.position, transform.forward * t);
        //Debug.Log("transform forward = " + transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                Debug.Log(hit.transform.gameObject.name);
            }
        }
    }
}
