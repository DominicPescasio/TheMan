using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]

public class PowerUpBloc : MonoBehaviour
{
    [SerializeField]
    private Sprite _inactiveSprite;

    [SerializeField]
    private GameObject _powerUp;

    private bool _used;

    private void OnCollisionEnter2D(Collision2D other)
    {
        var player = other.collider.GetComponent<Player>();
        if(!_used && player != null && other.contacts[0].normal.y > 0)
        {
            //spawn power up
            GetComponent<SpriteRenderer>()
        }
    }


}
