using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{

    public Color emissionColor;
    public float IntensityOn;
    public float IntensityOff;

    private void OnMouseDown()
    {
        Debug.Log("Clicked on " + name);

        

        if (GetComponent<Light>().enabled == false)
        {
            GetComponent<Light>().enabled = true;
            GetComponent<MeshRenderer>().enabled = false;
            //GetComponent<Light>().intensity = IntensityOn;

        }

        else 
        {
            GetComponent<Light>().enabled = false;
            //GetComponent<Light>().intensity = IntensityOn;
        }

        //récuperer la couleur de la lumiere
        Color lightColor = GetComponent<Light>().color;

        //modifie cette couleur en changeant chaque composante rgb de cette couleur:
        lightColor.r = 0f;
        lightColor.g = 0f;
        lightColor.b = 0f;
        
        //réassigne à la lumiere la couleur transformée:
        GetComponent<Light>().color = lightColor;
    }







}

//1ere option : tout désactiver
//gameObject.SetActive(false);

//2e option : desac le component light uniquement
//GetComponent<Light>().enabled = false;

//GetComponent<Light>().intensity = 0.5f;

//changer la couleur 'albedo' du material du lightbulb
//GetComponent<MeshRenderer>().material.color = Color.black;
//GetComponent<MeshRenderer>().material.color = new Color (0, 1, 0);

//changer la couleur 'emissive' du material du lightbulb
//GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", emissionColor);




//if (GetComponent<Light>().enabled == false)
//{
//    GetComponent<Light>().enabled = true;
//    GetComponent<MeshRenderer>().enabled = false;
   

//}

//else
//{
//    GetComponent<Light>().enabled = false;
   
//}
