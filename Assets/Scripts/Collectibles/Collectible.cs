using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    private int _quantity;

    public int GetQuantity()
    {
        return _quantity;
    }

    private void SetQuantity(int pQuantity)
    {
        _quantity = pQuantity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerCollider"))
        {
            collision.gameObject.GetComponentInParent<Player>().AddCoin(_quantity);
            Destroy(gameObject);
        }
    }
}
