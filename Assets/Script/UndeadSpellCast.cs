using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndeadSpellCast : MonoBehaviour
{ 
    public Vector3 minSpawnPos,maxSpawnPos;
    public GameObject undeadSpell;
    public GameObject undeadTroops;
    public int amounToSpawn;
    private bool isCasting;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isCasting)
        {
            StartCoroutine(castUndeadSpell());
        }
    }

    IEnumerator castUndeadSpell()
    {
        isCasting = true;
        Instantiate(undeadSpell,transform.position,transform.rotation);
        summoningUndead();
        yield return new WaitForSeconds(5f);
        isCasting = false;        
    }

    void summoningUndead()
    {
        for (int i = 1; i < amounToSpawn; i++ )
        {
          float randomX = Random.Range(minSpawnPos.x, maxSpawnPos.x);
          float randomY = Random.Range(minSpawnPos.y, maxSpawnPos.y);
          float randomZ = Random.Range(minSpawnPos.z, maxSpawnPos.z);

          Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);
          Instantiate(undeadTroops, randomPosition, Quaternion.identity); 
        }       
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube((minSpawnPos + maxSpawnPos) / 2, maxSpawnPos - minSpawnPos);
    }    
}
