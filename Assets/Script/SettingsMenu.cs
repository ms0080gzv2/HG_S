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

    public void pause()
    {
        bool pauseEnabled = false;
        if(Input.GetKeyDown("escape"))
        {
 
            //check if game is already paused
            if(pauseEnabled == true)
            {
                //unpause the game
                pauseEnabled = false;
                Time.timeScale = 1;
                AudioListener.volume = 1;
                Screen.showCursor = false;
            }
 
            //else if game isn't paused, then pause it
            else if(pauseEnabled == false)
            {
                pauseEnabled = true;
                AudioListener.volume = 0;
                Time.timeScale = 0;
                Screen.showCursor = true;
            }
        }

    }


}
