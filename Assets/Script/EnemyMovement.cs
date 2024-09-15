using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform targetPoint;
    [SerializeField] private float moveSpeed = 2f;
    void Update()
    {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, moveSpeed * Time.deltaTime);
    }
}
