using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direccion : MonoBehaviour
{
     
     public string URL;

     private void OnMouseDown()
     {
         Application.OpenURL(URL);
     }
}
