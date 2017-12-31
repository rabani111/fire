using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

    public Text scoreText;
    public Text ammoText;
    private int score;
    private int ammo;

    void Start() 
    {
        score = 0;
        ammo = 0;
        UpdateScore();
        UpdateAmmo();
    }


    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    public void AddAmmo(int newAmmoValue)
    {
        
        ammo += newAmmoValue;
        UpdateAmmo();
    }


    void UpdateScore()
    {
        scoreText.text= "Score: " + score;
    }
    public int getAmmo()
    {
        return this.ammo;
    }
    void UpdateAmmo()
    {
        ammoText.text = "Ammo: " + ammo;
    }

}