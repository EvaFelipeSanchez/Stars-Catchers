using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public Canvas canvas;

    // Método para visibilizar el Canvas
    public void ShowCanvas()
    {
        canvas.enabled = true;
    }

    // Método para invisibilizar el Canvas
    public void HideCanvas()
    {
        canvas.enabled = false;
    }
}
