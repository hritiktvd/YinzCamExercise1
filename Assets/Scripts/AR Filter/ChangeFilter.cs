using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFilter : MonoBehaviour
{
    [SerializeField]
    private Renderer carMaterial, helmetMaterial;

    [SerializeField]
    private Button helmetButton;

    [SerializeField]
    private RectTransform highlightedFilter;

    public GameObject Helmet;
    private bool isHelmetON;

    private void Start()
    {
        isHelmetON = true;
        ColorBlock colorBlock = helmetButton.colors;
        colorBlock.normalColor = new Color32(54, 245, 236, 255);
        helmetButton.colors = colorBlock;
        highlightedFilter.anchoredPosition = new Vector3(-200f, 145f, 0f);
    }

    public void RenderTeam1()
    {
        carMaterial.material.color = new Color32(255, 20, 130, 255);
        helmetMaterial.material.color = new Color32(220, 200, 30, 255);
        highlightedFilter.anchoredPosition = new Vector3(-200f, 145f, 0f);
    }

    public void RenderTeam2()
    {
        carMaterial.material.color = new Color32(0, 255, 140, 255);
        helmetMaterial.material.color = new Color32(20, 110, 140, 255);
        highlightedFilter.anchoredPosition = new Vector3(200f, 145f, 0f);
    }

    public void HelmetMode()
    {
        ColorBlock colorBlock = helmetButton.colors;
        if (isHelmetON)
        {
            isHelmetON = false;
            Helmet.SetActive(false);
            colorBlock.selectedColor = new Color32(241, 241, 44, 255);
            helmetButton.colors = colorBlock;
        }

        else if(!isHelmetON)
        {
            isHelmetON = true;
            Helmet.SetActive(true);
            colorBlock.selectedColor = new Color32(54, 245, 236, 255);
            helmetButton.colors = colorBlock;
        }
        //reference the button component in a switch case to change color when pressed. also can use the switch case to toggle the helmet on and off 
    }
}
