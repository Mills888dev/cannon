using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public Text scoreDisplay; 
    public Animator scoreAnimator;
    public int TwoStar;
    public int threeStar;
    public int nextLevel = 0;
    public void EndLevel()
    {        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;
            if (numProjectiles <= threeStar)
            {
                print("1");
                scoreDisplay.text = "three stars";
                scoreAnimator.SetInteger("Stars", 3);

            }
                else if (numProjectiles <= TwoStar)
            {
                print("2");
                scoreDisplay.text = "two stars";
                scoreAnimator.SetInteger("Stars", 2);

            }
            else
            {
                print("3");
                scoreDisplay.text = "one stars";
                scoreAnimator.SetInteger("Stars", 1);

            }
            Invoke("NextLevel",2);
        }
    
    }
    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
