using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    private GameObject panel;
    private TextMeshProUGUI textPro;
    private void Awake()
    {
        panel = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
        textPro = panel.GetComponentInChildren<TextMeshProUGUI>();
        if (panel != null)
        {
            panel.SetActive(false);
        }
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OpenUi();
        }
        
    }

    private void OpenUi()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.transform.CompareTag("Celestials"))
            {
                Debug.Log(hit.transform.gameObject.name);
                panel.SetActive(true);
                textPro.text = hit.transform.gameObject.name;
                Time.timeScale = 0;
            }
        }
    }



    public void CloseUi()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }


}
