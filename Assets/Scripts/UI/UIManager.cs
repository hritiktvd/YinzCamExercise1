using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public List<GameObject> UIElements;

    private void OnEnable()
    {
        EventsManager.onFilterStart += showInventoryUI;
    }

    private void OnDisable()
    {
        EventsManager.onFilterStart += showInventoryUI;
    }

    private void Start()
    {
        showStartUI();
    }

    public void showStartUI()
    {
        HideAllUI();
        UIElements[0].SetActive(true);
    }
    public void HideStartUI()
    {
        HideAllUI();
        UIElements[0].SetActive(false);
        EventsManager.FilterStarted();
    }

    private void showInventoryUI()
    {
        HideAllUI();
        UIElements[1].SetActive(true);
    }


    private void HideAllUI()
    {
        foreach (var UI in UIElements)
        {
            UI.SetActive(false);
        }
    }
}
