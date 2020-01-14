using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWinner : MonoBehaviour {

    public Text gameOverText;

    static public string winner;

    private void Start()
    {
        gameOverText.text = winner + " Won!";
    }
}
