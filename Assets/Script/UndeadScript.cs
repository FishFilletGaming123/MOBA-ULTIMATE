using System.Collections;
using UnityEngine;

public class UndeadScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;

    void Update()
    {
           GameObject targetObject = GameObject.FindWithTag("Enemy");   

           if (targetObject != null)
           {           
           Transform targetPos = targetObject.transform;                
           transform.position = Vector3.MoveTowards(transform.position, targetPos.position, moveSpeed * Time.deltaTime);
           }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }        
    }
}
