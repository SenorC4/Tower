using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    // Start is called before the first frame update
    Resolution[] resolutions;
    public Dropdown resolutionDrop;
    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDrop.ClearOptions();

        List<string> options = new List<string>();
        int current = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                current = i;
            }
        }

        resolutionDrop.AddOptions(options);
        resolutionDrop.value = current;
        resolutionDrop.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");

        Debug.Log("load main menu");
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void setQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

    public void setFullScreen(bool full)
    {
        Screen.fullScreen = full;
    }
}
