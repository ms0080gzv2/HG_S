using UnityEngine.Audio;
using UnityEngine;
using System.Collections.Generic;

public class SettingsMenu : MonoBehaviour
{

    //Set RESOLUTION 
    List<int> widths = new List<int>(){568, 960, 1280, 1920};
    List<int> heights = new List<int>(){320, 540, 800, 1000};

    public void SetScreenSize(int index)
    {
        bool fullScreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullScreen);
    }
    //END

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public AudioMixer settedAduio;
    public void SetVolume(float volume)
    {
        settedAduio.SetFloat("volume", volume); //have to use on tag, value
    }

    public void gameQuit()
    {
        Application.Quit();
    }
}
