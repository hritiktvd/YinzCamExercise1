using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFilter : MonoBehaviour
{
    [SerializeField]
    private Renderer carMaterial, helmetMaterial;

    public void renderTeam1()
    {
        carMaterial.material.color = new Color32(255, 20, 130, 255);
        helmetMaterial.material.color = new Color32(220, 200, 30, 255);
    }

    public void renderTeam2()
    {
        carMaterial.material.color = new Color32(0, 255, 140, 255);
        helmetMaterial.material.color = new Color32(20, 110, 140, 255);
    }
}
