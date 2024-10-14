using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score;

    private void OnEnable() // kutsutaan kun skripti aktivoidaan (awaken ja startin välissä + mahdollista aktivoida/deaktivoida kesken pelin)
                            
    {
        print("score manager on OnEnable called");
        Actions.OnEnemyHit += UpdateScore;  // Lisätään UpdateScore -funktio OnEnemyHit-actioniin. UpdateScore-funktio kutsuttaan kun OnEnemyHit-action triggeröidään (invokataan)    
                                            // Huom. pelkkä funktion nimi, ei parametreja!
        //Actions.OnEnemyHit += //Muitakin funktioita voitaisiin lisätä OnEnemyHit:iin
    }

    private void OnDisable()
    {
        print("score manager on OnDisable called");
        Actions.OnEnemyHit -= UpdateScore; //poistetaan UpdateScore-funktio OnEnemyHit-actionista
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }
}
