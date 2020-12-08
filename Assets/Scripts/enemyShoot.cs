using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    [SerializeField] private int drawTime = 2;
    [SerializeField] Sprite Fabulous;
    private int patience;
    bool canShoot = false;
    // Start is called before the first frame update
    void Start()
    {
        patience = drawTime;
        StartCoroutine("Draw");
    }

    private IEnumerator Draw()

    {

        while (drawTime > 0 && canShoot)
        {

            print(drawTime);

            drawTime -= 1;

            yield return new WaitForSeconds(1f);

        }

        GetComponent<SpriteRenderer>().sprite = Fabulous;

    }
}
