using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter2D(Collision2D collision)
     {
             string otherTag = collision.gameObject.tag;
        if(otherTag == "Enemy")
        {
            health -= 1;
            slider.value = health;
        }
        
           if(health <= 0)
            {
                Scene scene = SceneManager.GetActiveScene();
                 SceneManager.LoadScene(scene.name);
            }  
    }
}
