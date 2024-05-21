using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBattle : MonoBehaviour
{
    public GameObject popupPanel;

    void Start()
    {
        // Skjul popup-vinduet n�r spillet starter
        popupPanel.SetActive(false);
    }

    // Kalles n�r spilleren klikker p� en spesifikk tile
    public void OnTileClicked()
    {
        // Vis popup-vinduet n�r en tile klikkes
        popupPanel.SetActive(true);
    }

    // Kalles n�r spilleren klikker p� "Start Battle" -knappen i popup-vinduet
    public void StartBattleButtonClicked()
    {
        SceneManager.LoadScene("Battle"); // Laster inn kampscenen
       
    }
   
    // Kalles n�r spilleren klikker p� "Leave" -knappen i popup-vinduet
    public void LeaveButtonClicked()
    {
        // Skjul popup-vinduet n�r spilleren forlater
        popupPanel.SetActive(false);
    }
}
