using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // this is an image that we drag in
    [SerializeField] Sprite shootingSprite;
    // Start is called before the first frame update
    bool canShoot = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Press Space to shoot
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            print("Bang Bang");
            // Change Sprite to Sprite holding a weapon

            GetComponent<SpriteRenderer>().sprite = shootingSprite;

            // Randomize Weapons
            // Check for repeated weapon
        }
    }
}
