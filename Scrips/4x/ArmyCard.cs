using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyCard : MonoBehaviour
{
    public Text soldiersCountText; // Tekstobjektet som viser antall soldater p� kortet
    public Image cardImage; // Bildekomponenten som viser bildet p� kortet

    // Metode for � sette antall soldater p� kortet
    public void SetSoldiersCount(int count)
    {
        soldiersCountText.text = "Soldiers: " + count.ToString(); // Oppdater teksten p� kortet med antall soldater
    }

    // Metode for � sette bilde p� kortet
    public void SetCardImage(Sprite image)
    {
        cardImage.sprite = image; // Tilordne det angitte bildet til bildekomponenten p� kortet
    }
}
