using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public GameObject thing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Left Mouse Button
            ClickCheck();
            Debug.Log("yup, clicked");
        }
    }

    private void ClickCheck()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            var selectionMaterial = selectionRenderer.material;
            if (selectionRenderer != null)
            {
                thing.GetComponent<MeshRenderer>().material = selectionMaterial;
            }
        }
    }
}
