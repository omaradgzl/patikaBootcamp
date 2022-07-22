using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    private GameObject panel;  //panel object 
    private TextMeshProUGUI textPro; // text to display
    private void Awake()
    {
        panel = GameObject.Find("Canvas").transform.GetChild(0).gameObject; // getting panel object
        textPro = panel.GetComponentInChildren<TextMeshProUGUI>(); // getting text component
        if (panel != null)
        {
            panel.SetActive(false); // deactivate panel at start
        }
        
    }

    void Update()
    {
        // region that checks if left mouse clicked
        #region CheckInput
        if (Input.GetMouseButtonDown(0))
        {
            OpenUi();
        }
        #endregion
    }

    private void OpenUi()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // send a ray from camera to mouse position 
        if (Physics.Raycast(ray, out hit, 100.0f))         //check if ray hit something or not
        {
            if (hit.transform.CompareTag("Celestials") || hit.transform.name.Equals("Sun"))  //  compare the tag of object that ray hit --->i just hate that i needed to add this "or" statement but f it i love my first mecanim
            {
                //Debug.Log(hit.transform.gameObject.name);
                panel.SetActive(true);                                                  // activate panel
                textPro.text = hit.transform.gameObject.name;                       // set text as name of hit object
                
            }
        }
    }



    public void CloseUi()
    {
        // function that closes panel , called from button component 
        panel.SetActive(false); 
        
    }


}
