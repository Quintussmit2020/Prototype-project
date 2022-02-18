using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwopFurnitureOnClick : MonoBehaviour
{
    public GameObject Crate;
    public GameObject Barrel;
    public GameObject AmmoBox;
    public GameObject Light;
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
            ClickCheck2();
            //Debug.Log("yup, clicked");
        }
    }

    private void ClickCheck2()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            string selectionName = selectionRenderer.name;

            if (selectionRenderer != null)
            {

                switch (selectionName)
                {
                    case "Scene01Icon":
                        SceneManager.LoadScene("Scene01");
                        break;
                    case "Scene02Icon":
                        SceneManager.LoadScene("Scene02");
                        break;
                    case "CrateIcon":
                        Crate.active = true;
                        Barrel.active = false;
                        AmmoBox.active = false;
                        break;
                    case "BarrelIcon":
                        Crate.active = false;
                        Barrel.active = true;
                        AmmoBox.active = false;
                        break;
                    case "AmmoBoxIcon":
                        Crate.active = false;
                        Barrel.active = false;
                        AmmoBox.active = true;
                        break;
                    case "AllHidden":
                        Crate.active = false;
                        Barrel.active = false;
                        AmmoBox.active = false;
                        break;
                    case "LightOn":
                        Light.active = true;
                        break;
                    case "LightOff":
                        Light.active = false;
                        break;
                    default:
                        print("Nothing selected");
                        break;
                }
            }
        }
    }

    
}
