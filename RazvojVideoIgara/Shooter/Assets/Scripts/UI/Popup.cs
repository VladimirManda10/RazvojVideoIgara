using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField]
    private HPElement playerHealthBar;
    
    [SerializeField]
    private RectTransform contentHolder;
    
    [SerializeField]
    private Sprite playerImage;
    
    [SerializeField]
    private Sprite enemyImage;
    
    [SerializeField]
    private Color playerHealthColor;
    
    [SerializeField]
    private Color enemyHealthColor;

    [SerializeField]
    private GameObject prefab;

    private void OnEnable()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerHealthBar.setPlayerImage(playerImage);
        playerHealthBar.setHealthBar(player.Health / 100, playerHealthColor);
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in enemies){
            Enemy e = enemy.GetComponent<Enemy>();
            instantiateEnemyHealthBar(prefab,e);
        }

    }

    private void instantiateEnemyHealthBar(GameObject prefab,Enemy e)
    {
        GameObject enemyHealthBar = Instantiate(prefab, GameObject.FindGameObjectWithTag("Content").transform);
        if(enemyHealthBar != null)
        {
            HPElement enemyHPElement = enemyHealthBar.GetComponent<HPElement>();
            enemyHPElement.setPlayerImage(enemyImage);
            enemyHPElement.setHealthBar(e.Health / 100, enemyHealthColor);
        }
    }

}
