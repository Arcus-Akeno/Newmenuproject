using UnityEngine;

public class fullscreentoggle : MonoBehaviour
{///this script is for switching between fullscreen and windowed 

  public void fullscreen(int dropdown)
  {
        if(dropdown == 0)
        {
            Screen.fullScreen = true;

        }
        else if (dropdown == 1)
        {
            Screen.fullScreen = false;
        }
        else if (dropdown == 2)
        {
            // borderless window goes here
        }
        else
        {
            Debug.Log("dropdown was " + dropdown);
        }
    
  }
}
