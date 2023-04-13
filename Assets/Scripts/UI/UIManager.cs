using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public List<GameObject> UIElements;

    public List<GameObject> RacingLights;

    private void OnEnable()
    {
        EventsManager.onFilterStart += showRacingUI;
    }

    private void OnDisable()
    {
        EventsManager.onFilterStart += showRacingUI;
    }

    private void Start()
    {
        showStartUI();
    }

    public void showStartUI()
    {
        HideAllUI();
        hideAllLights();
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

    private void showRacingUI()
    {
        HideAllUI();
        UIElements[2].SetActive(true);
        StartCoroutine(SpawnRacingLight());
    }


    private void HideAllUI()
    {
        foreach (var UI in UIElements)
        {
            UI.SetActive(false);
        }
    }

    private void hideAllLights() 
    {
        foreach (var Light in RacingLights)
        {
            Light.SetActive(false);
        }
    }

    IEnumerator SpawnRacingLight()
    {
        for (var i = 0; i < RacingLights.Count; i++)
        {
            yield return new WaitForSeconds(1f);
            RacingLights[i].SetActive(true);
        }
        yield return new WaitForSeconds(1f);
        hideAllLights();
        showInventoryUI();
    }

}
